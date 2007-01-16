@echo off
echo start > log.txt
cd 94
for %%f in (*.red) do for %%g in (*.red) do call ..\rtest.cmd %%f %%g -k -r 5 -F 4321
cd ..
cd pspace
for %%f in (*.red) do for %%g in (*.red) do call ..\rtest.cmd %%f %%g -k -r 5 -F 4321
cd ..
cd icws
for %%f in (*.red) do for %%g in (*.red) do call ..\rtest.cmd %%f %%g -k -r 5 -F 4321 -8 -s 8192 -p 64
cd ..
echo done >> log.txt
