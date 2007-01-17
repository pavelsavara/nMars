echo ..\%~n1.shtml
type header > ..\%~n1.shtml
type %1 >> ..\%~n1.shtml
type menu >> ..\%~n1.shtml
type footer >> ..\%~n1.shtml