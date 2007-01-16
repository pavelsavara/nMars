@echo %*
..\pMars.0.9.2-server.exe %* >0.9.2.out 2>0.9.2.err
..\pMars.0.9.3-server.exe %* >0.9.3.out 2>0.9.3.err
diff 0.9.2.out 0.9.3.out >> ..\log.txt
diff 0.9.2.err 0.9.3.err >> ..\log.txt