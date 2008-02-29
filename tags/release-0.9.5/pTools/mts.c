/*
 * $Log: mts.c,v $
 * Revision 1.0  1994/05/23  16:36:32  stst
 * Initial revision
 *
 *
 * mts.c:
 *
 * MTS / MARS Tournament Scheduler 4/29/94 V1.61 (c) by Stefan Strack
 *
 * usage: mts [< commandfile]
 *
 * Works with any MARS that outputs the result to stdout. Result output must
 * contain # # # (interpreted as win loss tie) or # # [\n] # # (KotH format,
 * interpreted as win tie loss tie). Two types of tournament schedule
 * supported. Self-battles optional. Gives timing information. Parses
 * warriors for ;name and ;author.
 *
 * return code:
 *  0    - normal
 *  1..? - signal code (recovery file saved)
 *  99   - MARS error (recovery file saved)
 *  -1   - other error (recovery file not saved)
 *
 *  v1.4: Unique tempfile -> several mts can run in the same directory
 *  v1.5: Small fix for DOS % done display
 *  v1.6: command file from argument (for pshell)
 *  v1.61: small fix (name/author no longer truncated)
 */
#include <stdio.h>
#if defined(__MSDOS__) || defined(__STDC__)
#include <stdlib.h>
#endif
#include <string.h>
#include <ctype.h>
#include <time.h>
#ifdef __MSDOS__
#include <dos.h>
#else
#include <signal.h>
#endif
#if defined(HAVE_UNISTD_H)
#include <unistd.h>
#endif
#define PROGRAMID "MARS Tournament Scheduler version 1.61, 4/29/94\n"
#define MAXLINE 128
#define MAXNAME 23
#define MAXFILEN 50
#define MAXWARRIORS 200
#define SCORESFILE "scores.mts"
#define STATEFILE "_recover.mts"
#define CMDLINE "pmars -b -r 100"
#define NOFILE "nul"
#if defined(__MAC__)
#define STDOUT console
#else
#define STDOUT stdout
#endif
#define TERMINAL(s) ((*(s)=='\n') || (*(s)=='\r') || (*(s)==0))
#define VERBOSE(s) if (verbose=='y') { printf s; fflush(STDOUT); }
#define PERCENT(a,b) ((int) ((float) (a) / (float) (b)*100.0 + 0.5))
#define BAD_STATE do { fprintf(stderr,"Recovery file is corrupted\n") \
             ;exit(-1);} while(0)
#define NOEOL(s) do {\
    register char *ch=(s);\
    while (*ch && (*ch != '\n') && (*ch != '\r')) ++ch;\
    *ch=0; } while(0)

#if defined(__STDC__) || defined(__MSDOS__)
typedef void   *pointer_t;
#else
typedef char   *pointer_t;
#endif

typedef struct {
  char            filename[MAXFILEN + 1], name[MAXNAME + 1], author[MAXNAME + 1];
  int             wins, losses, ties, score;
}               warriorStruct;

typedef int     index2_t;


/* function prototypes */
#if defined(__MSDOS__) || defined(__STDC__)
void            fight(int w1, int w2);
int             get_score(FILE * fp, int *win, int *loss, int *tie);
char           *userinput(char *prompt, char *defInp, char *buf);
int             get_warriors(FILE * fp, int i);
char           *get_info(FILE * fp, char *keyword, char *buf);
void            sort_by_score(void);
void            results(FILE * out_fp);
void            put_commands(FILE * fp);
void            get_state(FILE * fp);
void            recovery_abort(int);
int             main(int argc,char *argv[]);
void            dialog(void);
#else
void            fight();
int             get_score();
char           *userinput();
int             get_warriors();
char           *get_info();
void            sort_by_score();
void            results();
void            put_commands();
void            get_state();
void            recovery_abort();
void            dialog();
#endif

warriorStruct   warrior[MAXWARRIORS];   /* contains warrior info */
index2_t        wI = 0, wJ = 0, widx[MAXWARRIORS];  /* index into warrior[]
                             * for sorting */
int             nWarriors, nBattles, battle = 0;
FILE           *any_fp, *cmd_fp;
long            elapsedTime, startTime, stopTime, totalRounds;
char            commandline[MAXLINE + 1], scorefile[MAXLINE + 1], commandfile[MAXLINE + 1],
                schedule, selffight, verbose, resuming, tempfile[20];

/*---------------------------------------------------------------------------
 fight - call MARS and analyze output
 ---------------------------------------------------------------------------*/
void
fight(w1, w2)
  index2_t        w1, w2;
{
  int             win, loss, tie;
  char            syscall[MAXLINE + 1];

  /* this is OS dependent */
  sprintf(syscall, "%s %s %s > %s", commandline, warrior[w1].filename
      ,warrior[w2].filename, tempfile);
  unlink(tempfile);
  if (system(syscall)) {
    fprintf(stderr, "System call\n\"%s\"\nreturns with exitcode != 0\n", syscall);
    recovery_abort(99);
  }
  if ((any_fp = fopen(tempfile, "r")) == NULL) {
    fprintf(stderr, "Cannot open output capture file %s\n", tempfile);
    recovery_abort(99);
  }
  if (get_score(any_fp, &win, &loss, &tie)) {
    fprintf(stderr, "Capture file %s does not contain result number triplet or quadruplet\n", tempfile);
    recovery_abort(99);
  }
  fclose(any_fp);
  warrior[w1].wins += win;
  warrior[w1].losses += loss;
  warrior[w1].ties += tie;
  warrior[w2].wins += loss;
  warrior[w2].losses += win;
  warrior[w2].ties += tie;
  warrior[w1].score += win * 3 + tie;
  warrior[w2].score += loss * 3 + tie;
  ++battle;
  VERBOSE(("\nBattle %d of %d (%d%%) is finished:\n%s by %s scores %d (%d %d %d)\n\
%s by %s scores %d (%d %d %d)\n",
       battle, nBattles, PERCENT(battle, nBattles),
    warrior[w1].name, warrior[w1].author, win * 3 + tie, win, loss, tie,
     warrior[w2].name, warrior[w2].author, loss * 3 + tie, loss, win, tie));
}
/*---------------------------------------------------------------------------
 get_score - scan for generic score, win loss ties or win ties loss ties
 ---------------------------------------------------------------------------*/
int
get_score(fp, win, loss, tie)
  FILE           *fp;
  int            *win, *loss, *tie;
{
  int             spare, num;
  do {
  } while (((num = fscanf(fp, "%*[^0-9] %d %d %d %d", win, loss, tie, &spare)) != EOF)
       && (num != 3) && (num != 4));
  if (num == 3)         /* win loss ties */
    return 0;
  if ((num == 4) && (*loss == spare)) { /* KotH format: win ties\nloss ties */
    *loss = *tie;
    *tie = spare;
    return 0;
  } else
    return 1;
}
/*---------------------------------------------------------------------------
 put_commands - save commands for input redirection
 ---------------------------------------------------------------------------*/
void
put_commands(fp)
  FILE           *fp;
{
  index2_t        i;

  fprintf(fp, "%s\n", (schedule == 'r' ? "Round-robin" : "First warrior fights rest"));
  fprintf(fp, "%s (warriors fight self)\n", (selffight == 'y' ? "Yes" : "No"));
  fprintf(fp, "%s\n", commandline);
  fprintf(fp, "%s (verbose output)\n", (verbose == 'y' ? "Yes" : "No"));
  fprintf(fp, "%s\n", scorefile);
  fprintf(fp, "%s\n", commandfile);
  for (i = 0; i < nWarriors; ++i)
    fprintf(fp, "%s\n", warrior[i].filename);
}
/*---------------------------------------------------------------------------
 userinput - display prompt, return input string or default
 ---------------------------------------------------------------------------*/
char           *
userinput(prompt, defInp, buf)
  char           *prompt, *defInp, *buf;
{
  if (cmd_fp == stdin)
    fprintf(STDOUT,"%s [%s] ", prompt, defInp);
  if (!fgets(buf, MAXLINE, cmd_fp)) {
    fprintf(stderr, "Premature EOF\n");
    exit(-1);
  }
  NOEOL(buf);
  while (isspace(*buf))
    ++buf;
  if (TERMINAL(buf))
    strcpy(buf, defInp);
  return buf;
}
/*---------------------------------------------------------------------------
 get_warriors - collect warrior array for tournament
 ---------------------------------------------------------------------------*/
int
get_warriors(fp, i)
  FILE           *fp;
  index2_t        i;
{
  char            inbuf[MAXFILEN + 1];
  FILE           *new_fp;
  while (fgets(inbuf, MAXFILEN, fp) && !TERMINAL(inbuf) && (i < MAXWARRIORS)) {
    NOEOL(inbuf);
    while (isspace(*inbuf))
      strcpy(inbuf, inbuf + 1);
    if (*inbuf == '@') {
      if ((new_fp = fopen(inbuf + 1, "r")) == NULL) {
    fprintf(stderr, "Cannot open listfile %s\n", inbuf + 1);
    exit(-1);
      }
      i = get_warriors(new_fp, i);
      fclose(new_fp);
    } else {
      if ((any_fp = fopen(inbuf, "r")) == NULL) {
    fprintf(stderr, "Cannot open warrior %s\n", inbuf);
    exit(-1);
      }
      strcpy(warrior[i].filename, inbuf);
      get_info(any_fp, "name", warrior[i].name);
      if (!*(warrior[i].name))
    strcpy(warrior[i].name, warrior[i].filename);
      rewind(any_fp);
      get_info(any_fp, "author", warrior[i].author);
      if (!*(warrior[i].author))
    strcpy(warrior[i].author, "Anonymous");
      fclose(any_fp);
      warrior[i].wins = 0;
      warrior[i].losses = 0;
      warrior[i].ties = 0;
      warrior[i].score = 0;
      ++i;
    }
  }
  return i;
}
/*---------------------------------------------------------------------------
 get_info - scan warrior for keyword (name, author, ..)
 ---------------------------------------------------------------------------*/
char           *
get_info(fp, keyword, buf)
  FILE           *fp;
  char           *keyword, *buf;
{
  char            inbuf[MAXLINE];
  int             i, j;

  while (fgets(inbuf, MAXLINE, fp)) {
    i = 0;
    j = 0;
    while ((inbuf[++i] != '\n') && (tolower(inbuf[i]) != tolower(*keyword)));
    if (inbuf[i] == '\n')
      continue;
    while ((inbuf[++i] != '\n') && (keyword[++j]) && (tolower(inbuf[i]) == tolower(keyword[j])));
    if (!keyword[j]) {
      NOEOL(inbuf + i);
      while (isspace(inbuf[i]))
    ++i;
      strcpy(buf, inbuf + i);
      *(buf + MAXNAME) = 0;   
      return buf;
    }
  }
  *buf = 0;
  return buf;
}
/*---------------------------------------------------------------------------
 sort_by_score - sort the warrior index array by decreasing score
         yeah, bubblesort, so sue me
 ---------------------------------------------------------------------------*/
void
sort_by_score()
{
  char            sorted;
  index2_t        tmp, i;

  for (tmp = 0; tmp < nWarriors; ++tmp)
    widx[tmp] = tmp;
  do {
    sorted = 1;
    for (i = 0; i < nWarriors - 1; ++i)
      if (warrior[widx[i]].score < warrior[widx[i + 1]].score) {
    tmp = widx[i];
    widx[i] = widx[i + 1];
    widx[i + 1] = tmp;
    sorted = 0;
      }
  } while (!sorted);
}
/*---------------------------------------------------------------------------
 results - report rank list
 ---------------------------------------------------------------------------*/
void
results(out_fp)
  FILE           *out_fp;
{
  index2_t        i;
  int             hrs, mins, secs;
  long        totalTime;

  totalTime = elapsedTime + stopTime - startTime;
  hrs = (int) totalTime / 3600;
  mins = (int) (totalTime - (hrs * 3600)) / 60;
  secs = (int) (totalTime - (hrs * 3600) - (mins * 60));
  fprintf(out_fp, "\nElapsed time: %ld seconds (%02d:%02d:%02d)\n",
      totalTime, hrs, mins, secs);
  fprintf(out_fp, "\n\
Rank    Name                    Author                   %%W  %%L  %%T   Score\n\
___________________________________________________________________________\n");
  for (i = 0; i < nWarriors; ++i) {
    totalRounds = warrior[i].wins + warrior[i].losses + warrior[i].ties;
    fprintf(out_fp, "%3d     %-23s %-23s %3d %3d %3d   %-6d\n", i + 1, warrior[widx[i]].name,
        warrior[widx[i]].author,
        PERCENT(warrior[widx[i]].wins, totalRounds),
        PERCENT(warrior[widx[i]].losses, totalRounds),
        PERCENT(warrior[widx[i]].ties, totalRounds),
        warrior[widx[i]].score);
  }
}
/*---------------------------------------------------------------------------
 recovery_abort - save state if terminating signal was raised
 ---------------------------------------------------------------------------*/
void
recovery_abort(sigtype)
  int             sigtype;
{
  index2_t        a;
  FILE           *fp;

  elapsedTime += time(0L) - startTime;
  if ((fp = fopen(STATEFILE, "w")) == NULL) {
    fprintf(stderr, "Cannot save recovery file %s\n", STATEFILE);
    exit(-1);
  } else
    fprintf(stderr, "Caught termination signal - saving state to %s for recovery\n", STATEFILE);

  fprintf(fp, "%c%c\n%s\n%c\n%s\n%s\n%d %d %d %d %ld\n",
      schedule, selffight, commandline, verbose, scorefile, commandfile, nWarriors,
      wI, wJ, battle, elapsedTime);
  for (a = 0; a < nWarriors; ++a)
    fprintf(fp, "%s\n%s\n%s\n%d %d %d %d\n",
        warrior[a].filename,
        warrior[a].name,
        warrior[a].author,
        warrior[a].wins,
        warrior[a].losses,
        warrior[a].ties,
        warrior[a].score);
  unlink(tempfile);
  exit(sigtype);
}
/*---------------------------------------------------------------------------
 get_state - resume from saved state
 ---------------------------------------------------------------------------*/
void
get_state(fp)
  FILE           *fp;
{
  index2_t        a;
  if (fscanf(fp, "%c%c\n%[^\n]\n%c\n%[^\n]\n%[^\n]\n%d %d %d %d %ld\n",
         &schedule, &selffight, commandline, &verbose, scorefile, commandfile, &nWarriors,
         &wI, &wJ, &battle, &elapsedTime) != 11)
    BAD_STATE;
  for (a = 0; a < nWarriors; ++a)
    if (fscanf(fp, "%[^\n]\n%[^\n]\n%[^\n]\n%d %d %d %d\n",
           warrior[a].filename,
           warrior[a].name,
           warrior[a].author,
           &warrior[a].wins,
           &warrior[a].losses,
           &warrior[a].ties,
           &warrior[a].score) != 7)
      BAD_STATE;
}
/*---------------------------------------------------------------------------
 dialog - get input from user
 ---------------------------------------------------------------------------*/
void
dialog()
{
  char            inbuf[MAXLINE + 1];

  do {
  }
  while (((schedule = tolower(*userinput("\nRound-robin or First warrior fights rest (R/F)?", "R", inbuf))) != 'r')
     && (schedule != 'f'));

  do {
  }
  while (((selffight = tolower(*userinput("\nInclude self-fights (Y/N)?", "Y", inbuf))) != 'y')
     && (selffight != 'n'));

  strcpy(commandline, userinput("\nMARS command line:", CMDLINE, inbuf));

  do {
  }
  while (((verbose = tolower(*userinput("\nVerbose output (Y/N)?", "Y", inbuf))) != 'y')
     && (verbose != 'n'));

  strcpy(scorefile, userinput("\nSave scores to:", SCORESFILE, inbuf));

  strcpy(commandfile, userinput("\nSave these commands for recall to:", NOFILE, inbuf));

  /* get files */
  if (cmd_fp == stdin)
    fputs("\nEnter warrior or @listfile, one per line, empty line when done\n", STDOUT);
  nWarriors = get_warriors(cmd_fp, 0);
}
/*---------------------------------------------------------------------------
 main
 ---------------------------------------------------------------------------*/
int
main(argc,argv)
int argc;
char *argv[];
{

  index2_t        i;

#ifdef unix
#ifdef SIGHUP
  signal(SIGHUP, recovery_abort);
#endif
#ifdef SIGINT
  signal(SIGINT, recovery_abort);
#endif
#else
#if defined(__MSDOS__) || defined(MSDOS)
  ctrlbrk((int (*) (void)) recovery_abort);
#endif
#endif

#ifdef unix
  sprintf(tempfile,"%d.tmp",(int) getpid()); /* unique temporary file */
#else
  sprintf(tempfile,"%d.tmp",(int) time(0L)); /* (hopefully) unique temporary file */
#endif

  fputs(PROGRAMID, STDOUT);
  if ((any_fp = fopen(STATEFILE, "r")) != NULL) {
    fprintf(STDOUT,"Recovery file %s found - resuming interrupted tournament\n", STATEFILE);
    get_state(any_fp);
    fclose(any_fp);
    unlink(STATEFILE);
    resuming = 1;
  } else {
    cmd_fp = stdin;
    if ((argc>1) && ((cmd_fp=fopen(argv[1],"r")) == NULL)) {
      fprintf(stderr,"Cannot open command file %s\n",argv[1]);
      exit(-1);
    }
    dialog();
    if (cmd_fp != stdin) fclose(cmd_fp);
    resuming = 0;
  }

  if (strcmp(commandfile, NOFILE)) {
    unlink(commandfile);
    if ((any_fp = fopen(commandfile, "w")) == NULL) {
      fprintf(stderr, "Cannot open commandfile %s\n", commandfile);
      exit(-1);
    }
    put_commands(any_fp);
    fclose(any_fp);
  }
  if (schedule == 'r')
    for (nBattles = 0, i = (selffight == 'y' ? nWarriors : nWarriors - 1); i > 0; --i)
      nBattles += (int) i;
  else
    nBattles = (selffight == 'y' ? nWarriors : nWarriors - 1);
  if (nBattles == 0) {
    VERBOSE(("\nNo fight\nProgram exits normally\n"));
    exit(0);
  }
  VERBOSE(("\nStarting tournament\n"));
  startTime = time(0L);
  if (schedule == 'r')      /* wI,wJ may be reset by get_state */
    for (; wI < nWarriors; ++wI) {
      if (!resuming)
    wJ = (selffight == 'y' ? wI : wI + 1);
      else
    resuming = 0;
      for (; wJ < nWarriors; ++wJ)
    fight(wI, wJ);
    }
  else {
    if (!resuming)
      wJ = (selffight == 'y' ? 0 : 1);
    else
      resuming = 0;
    for (; wJ < nWarriors; ++wJ)
      fight(0, wJ);
  }
  stopTime = time(0L);
/*if (schedule == 'f')
    fprintf(STDOUT,"%s by %s scores %d\n%d%% wins, %d%% losses, %d%% ties\n",
       warrior[0].name, warrior[0].author, warrior[0].score,
       PERCENT(warrior[0].wins, totalRounds),
       PERCENT(warrior[0].losses, totalRounds),
       PERCENT(warrior[0].ties, totalRounds));
*/
  sort_by_score();
  results(STDOUT);
  if (strcmp(scorefile, "nul")) {
    unlink(scorefile);
    if ((any_fp = fopen(scorefile, "w")) == NULL) {
      fprintf(stderr, "Cannot open scorefile %s\n", scorefile);
      exit(-1);
    }
    results(any_fp);
  }
  unlink(STATEFILE);
  unlink(tempfile);
  return 0;
}               /* end main */
