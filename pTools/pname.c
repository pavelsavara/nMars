/* pname.c  automatic warrior naming program by Nandor Sieben     */
/* the program reads filenames from standard input                */
/* under DOS use dir /B *.red | pname to rename all your warriors */


#include "stdio.h"

#define MAXFILES 500
#define NAMELENGTH 80
#define FILENAMELENGTH 20
#define LINELENGTH 80
#define SHORTSIZE 8
#define ENDSIZE 3

#define ERROR_nothing 1
#define ERROR_io 10
#define ERROR_double 2
#define ERROR_samename 3
#define ERROR_write 10

char            names[MAXFILES][NAMELENGTH];
char            fileNames[MAXFILES][FILENAMELENGTH];
int             noFiles;
int 		errCode;

void
get_filenames()
{
  noFiles -= 1;
  do {
  }
  while (EOF != scanf("%s", fileNames[++noFiles]));
  --noFiles;
}

void
get_names()
{
  int             i,j;
  char            s[LINELENGTH];
  char           *ss;
  FILE           *in;

  if (noFiles == -1) {
    printf("Nothing to do");
    exit(ERROR_nothing);
  }
  for (i = 0; i <= noFiles; i++) {
   if ((in = fopen(fileNames[i], "r"))
	== NULL) {
      fprintf(stderr, "Cannot open file %s.\n", fileNames[i]);
      exit(ERROR_io);
    }
    names[i][0] = 0;
    while (!feof(in)) {
      fgets(s, LINELENGTH, in);
      for(ss=s;*(++ss)!=0;*ss=tolower(*ss));
      if (  (ss = (char *) strstr(s, ";name")) != NULL) {
	if (names[i][0] != 0) {
	  fprintf(stderr, "Duplicate name in file %s\n", fileNames[i]);
	  exit(ERROR_double);
	}
	do {
	} while (!isspace((++ss)[0]));
	do {
	} while (isspace((++ss)[0]));
	strcpy(names[i], ss);
	for(j=strlen(ss)-1;(j>0) && (isspace(ss[j]));--j) {
	  names[i][j]=0;
	}
      }
    }
    if (names[i][0] == 0) {
      fprintf(stderr, "No name in file %s\n", fileNames[i]);
      strncpy(names[i],fileNames[i],SHORTSIZE);
      if ( (ss=(char*)strchr(names[i],'.'))!=NULL)
	*ss=0;
    }
    fclose(in);
  }
}


void short_name(srt,lng)
char * srt;
char * lng;
{
int i;
if(strlen(lng)<SHORTSIZE) {
  strcpy(srt,lng);
}
else {
  strncpy(srt,lng,SHORTSIZE-ENDSIZE);
  srt[SHORTSIZE-ENDSIZE]=0;
  strcat(srt,lng+strlen(lng)-ENDSIZE);
}
  for(i=0; i<strlen(srt);++i) {
    if((!isalnum(srt[i]))||isspace(srt[i])) {
      srt[i]='_';
    }
  }
}



void check_duplicate() {
int i,j,k;
char s[NAMELENGTH];
for(i=0;i<noFiles;++i) {
  for(j=i+1;j<=noFiles;++j) {
    if((k=strcmp(names[i],names[j]))==0) {
      fprintf(stderr,"\nSame name in files %s and %s",fileNames[i],
	      fileNames[j]);
    }
    else
    if(k>0) {                             /* Sort */
      strcpy(s,names[i]);
      strcpy(names[i],names[j]);
      strcpy(names[j],s);
      strcpy(s,fileNames[i]);
      strcpy(fileNames[i],fileNames[j]);
      strcpy(fileNames[j],s);
    }
  }
}
}

void next_name(shrtName)
char * shrtName;
{
char s;
printf(" Renaming %s ---> ", shrtName);
while('z'<(s=(++(shrtName[strlen(shrtName)-1])))||'a'>s);
printf("%s\n",shrtName);
}

void archive(i,srtName)
int i;
char * srtName;
{
printf("name: %s \noldfile: %s \nnewfile: %s.red\n",names[i],fileNames[i],srtName);
}


void change_name() {
FILE *in, *out;
int i;
char shortName[FILENAMELENGTH];
char s[FILENAMELENGTH];
for(i=0;i<=noFiles;i++){
  short_name(shortName,names[i]);
  strcpy(s,shortName);
  strcat(s,".red");
  while ((in = fopen(s, "r"))!= NULL) {
    fclose(in);
/*    fprintf(stderr,"Warning: conflicting names %s",s); */
    next_name(shortName);
    strcpy(s,shortName);
    strcat(s,".red");
  }
  archive(i,shortName);
  strcat(shortName,".red");
  sprintf(s,"%dwar.wrk",i);
  if(rename(s,shortName)){
    fprintf(stderr,"Write error renaming file: %s %s %s",fileNames[i],s,shortName);
    exit(ERROR_write);
  }
}
}

void make_copy() {
int i;
char s[FILENAMELENGTH];
for(i=0;i<=noFiles;++i) {
  sprintf(s,"%dwar.wrk",i);
  if(rename(fileNames[i],s)){
    fprintf(stderr,"Write error writing file: %s",s);
    exit(ERROR_write);
  }
}
}

int
main()
{
  get_filenames();
  get_names();
  check_duplicate();
  make_copy();
  change_name();
  return (0);
}
