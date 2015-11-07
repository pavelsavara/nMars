cp MakefileServer Makefile
make clean
make all
cp MakefileConsole Makefile
make clean
make all
cp MakefileSDL Makefile
make clean
make all


echo !!Package
VER=9.3
OS=FreeBSD
#OS=Linux.i386
PKG=0.$VER-a.$OS

rm -rf pMarsBinary.$PKG
mkdir pMarsBinary.$PKG
cp pmars-c pMarsBinary.$PKG
cp pmars-cs pMarsBinary.$PKG
cp pmars-sdl pMarsBinary.$PKG
cd pMarsBinary.$PKG
ln -s pmars-c pmars
cd ..
rm pMars.$PKG.tar.gz
tar cvfz pMars.$PKG.tar.gz pMarsBinary.$PKG
~/upload $OS $VER pMars.$PKG.tar.gz
