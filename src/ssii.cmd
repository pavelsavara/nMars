echo ..\%~n1.html
type header > ..\%~n1.html
type %1 >> ..\%~n1.html
type menu >> ..\%~n1.html
type footer >> ..\%~n1.html