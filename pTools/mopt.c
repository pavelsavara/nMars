#define ID "mopt v1.2 - multiple constant optimizer for corewar (c) 1994-96 Stefan Strack\n"
/* $Log: mopt.c,v $
 * Revision 1.3  1996/06/04  07:33:15  stst
 * target size option
 *
 * Revision 1.1  1995/05/27  15:45:42  stst
 * BCC version now with large core support
 *
 * Revision 1.0  1994/05/21  21:42:40  stst
 * Initial revision
 * */
#include <stdio.h>
#include <ctype.h>
#include <string.h>
#include <stdlib.h>
#if defined(__MSDOS__) && !defined(__GO32__)
#include <alloc.h>
#include <dos.h>
#include <mem.h>
#define MALLOC (char far *) farmalloc
#define FAR far
#define MEMSET _fmemset
#else
#include <malloc.h>
#include <signal.h>
#define MALLOC malloc
#define FAR
#define MEMSET memset
#endif

#define MAXLINE 128
#define MAXCONS 10
#define NBEST 20
#define FOLD(n) (((((n)) % coreSize) + coreSize) % coreSize)
#define E(str,res) (!eval_expr(str,&res) ? res : \
    (fprintf(stderr,"Expression error: \"%s\"\n",str), exit(1), 0))
#define TERMINAL(s) (((s)=='\n') || ((s)=='\r') || ((s)==0))
#define NOEOL(s) do {\
    register char *ch=(s);\
    while (*ch && (*ch != '\n') && (*ch != '\r')) ++ch;\
    *ch=0; } while(0)

typedef long ADDR_T;

typedef struct {
  ADDR_T  ptr;
  struct {
    char    start[MAXLINE], stop[MAXLINE], step[MAXLINE];
    ADDR_T  cur, norm;
  }       offs, incr;
}       consStruct;
typedef struct {
  long    score;
  struct {
    ADDR_T  offs, incr;
  }       cons[MAXCONS];
}       bestStruct;


consStruct cons[MAXCONS];
bestStruct best[NBEST];
int     consNum;
ADDR_T  coreSize;
long    TargetSize;                /* used to be a constant */
char FAR *core;
char   *defCoreSize = "8000";
char   *defTargetSize = "100";

/* prototypes */
#if defined(__STDC__)  ||  defined(__MSDOS__)
long    mopt(void);
void    iterate(int consP);
void    print_best(void);
void    sighandler(int dummy);
extern int eval_expr(char *expr, long *result);
#else
long    mopt();
void    iterate();
void    print_best();
void    sighandler();
extern int eval_expr();
#endif

long
mopt()
{
  ADDR_T  i, j, idx, counter = 0, dist;
  long    accum = 0;
  int     consP = 0;

  for (i = 0; i < consNum; ++i) {
    if (!cons[i].incr.cur)        /* this is legal, e.g. -100,100,5 */
      return 0L;
    cons[i].offs.norm = cons[i].ptr = FOLD(cons[i].offs.cur);
  }
  /* clear core array */
  MEMSET(core, 0, coreSize);

  while (1) {
    if (!consP)                        /* to prevent asymmetries, all bombs hit
                                 * simultaneously */
      for (i = 0; i < consNum; ++i)
        if (!core[cons[i].ptr])
          core[cons[i].ptr] = 1;
    idx = cons[consP].ptr;
    if (core[idx] == 1) {
      core[idx] = 2;
      for (i = (idx - 1 + coreSize) % coreSize, j = (idx + 1) % coreSize, dist = 0;        /* search only until
                                                                                         * TargetSize */
           !core[i] && !core[j] && dist <= TargetSize; --i, ++j, ++dist) {
        if (!i)
          i = coreSize;
        if (j == coreSize - 1)
          j = -1;
      }
      accum += dist * ((coreSize - counter) >> 8);        /* score with decreasing
                                                         * gap weight */
    }
    cons[consP].ptr = cons[consP].ptr + cons[consP].incr.cur;
    while (cons[consP].ptr < 0)        /* faster than FOLD */
      cons[consP].ptr += coreSize;
    while (cons[consP].ptr >= coreSize)
      cons[consP].ptr -= coreSize;
    ++counter;
    if (cons[consP].ptr == cons[consP].offs.norm)
      return accum;
    if (++consP == consNum)
      consP = 0;
  }
}


main()
{
  int     idx, sc1, sc2;
  char    buf1[MAXLINE], buf2[MAXLINE];

  printf(ID);
  do {
    printf("Core size: [%s] ", defCoreSize);
    fgets(buf1, MAXLINE, stdin);
    NOEOL(buf1);
    idx = 0;
    while (isspace(buf1[idx]))
      ++idx;
    if (TERMINAL(buf1[idx]))
      strcpy(buf1, defCoreSize);
  } while (sscanf(buf1, "%ld", &coreSize) != 1 || coreSize <= 0);
  do {
    printf("Target size: [%s] ", defTargetSize);
    fgets(buf1, MAXLINE, stdin);
    NOEOL(buf1);
    idx = 0;
    while (isspace(buf1[idx]))
      ++idx;
    if (TERMINAL(buf1[idx]))
      strcpy(buf1, defTargetSize);
  } while (sscanf(buf1, "%ld", &TargetSize) != 1 || TargetSize <= 0);
  idx = 1;
  while (idx <= MAXCONS) {
    if (idx > 1) {
      printf("   Offset value or generator #%d: ", idx);
      if (!fgets(buf1, MAXLINE, stdin) || buf1[0] <= 13)
        break;
    } else
      strcpy(buf1, "0");
    printf("Increment value or generator #%d: ", idx);
    if (!fgets(buf2, MAXLINE, stdin) || buf2[0] <= 13)
      break;
    if (((sc1 = sscanf(buf1, "%[^,;]%*[,;]%[^,;]%*[,;]%[^,;]", cons[idx - 1].offs.start,
                       cons[idx - 1].offs.stop,
                       cons[idx - 1].offs.step)) == 1 ||
         sc1 == 3) &&
        ((sc2 = sscanf(buf2, "%[^,;]%*[,;]%[^,;]%*[,;]%[^,;]", cons[idx - 1].incr.start,
                       cons[idx - 1].incr.stop,
                       cons[idx - 1].incr.step)) == 1 ||
         sc2 == 3)) {
      if (sc1 == 1) {
        strcpy(cons[idx - 1].offs.stop, "0");
        strcpy(cons[idx - 1].offs.step, "0");
      }
      if (sc2 == 1) {
        strcpy(cons[idx - 1].incr.stop, "0");
        strcpy(cons[idx - 1].incr.step, "0");
      }
      ++idx;
    } else
      printf("Bad format. Examples:\n\t3\n\tb=a/2\n\tc=2,c<100,c=c+2\n");
  }                                /* while(1) */
  consNum = idx - 1;

  if ((core = MALLOC(coreSize)) == NULL) {
    fprintf(stderr, "Cannot allocate core memory\n");
    return 1;
  }
#if  defined(unix) && !defined(__GO32__)
#ifdef SIGINT
  signal(SIGINT, sighandler);
#endif
#else
#if defined(__MSDOS__) && !defined(__GO32__)
  ctrlbrk((int (*) (void)) sighandler);
#endif
#endif

  printf("Hit ^C to see the best so far\n");

  iterate(0);
  printf("The best:\n");
  print_best();
  return 0;
}

void
iterate(consP)
  int     consP;
{
  int     cmp, i;
  long    temp, dummy;

  if (consP == consNum) {
    if ((temp = mopt()) > best[NBEST - 1].score) {        /* sort into top 20 */
      for (cmp = NBEST - 2; cmp >= 0 && temp > best[cmp].score; --cmp) {
        best[cmp + 1].score = best[cmp].score;
        for (i = 0; i < consNum; ++i) {
          best[cmp + 1].cons[i].offs = best[cmp].cons[i].offs;
          best[cmp + 1].cons[i].incr = best[cmp].cons[i].incr;
        }
      }
      best[cmp + 1].cons[0].offs = cons[0].offs.cur;
      printf("%-5ld ", best[cmp + 1].cons[0].incr = cons[0].incr.cur);
      for (i = 1; i < consNum; ++i)
        printf("%-5ld %-5ld ", best[cmp + 1].cons[i].offs = cons[i].offs.cur,
               best[cmp + 1].cons[i].incr = cons[i].incr.cur);
      printf(" -> %f\n", (float) (best[cmp + 1].score = temp) / coreSize);
      fflush(stdout);
    }
  } else {                        /* iterate */
    E(cons[consP].offs.start, cons[consP].offs.cur);
    do {
      E(cons[consP].incr.start, cons[consP].incr.cur);
      do {
        iterate(consP + 1);
        E(cons[consP].incr.step, cons[consP].incr.cur);
      } while (E(cons[consP].incr.stop, dummy));
      E(cons[consP].offs.step, cons[consP].offs.cur);
    } while (E(cons[consP].offs.stop, dummy));
  }                                /* else */
}

void
print_best()
{
  int     i, j;
  for (j = 0; j < NBEST; ++j)
    if (best[j].score > 0) {
      printf("%-5ld ", best[j].cons[0].incr);
      for (i = 1; i < consNum; ++i)
        printf("%-5ld %-5ld ", best[j].cons[i].offs,
               best[j].cons[i].incr);
      printf(" -> %f\n", (float) best[j].score / coreSize);
    }
}

void
sighandler(dummy)
  int     dummy;
{
  char    buf[11];

  printf("The best so far:\n");
  print_best();
  printf("(c)ontinue or (q)uit? ");
  fgets(buf, 10, stdin);
  if (tolower(buf[0]) == 'q')
    exit(dummy);
  else
    return;
}
