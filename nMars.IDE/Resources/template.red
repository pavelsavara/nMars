;redcode
;name Template Warrior
;author YourName OrNickName
;strategy Some Description
;created using nMars, see http://nmars.sourceforge.net/
;to customize templates place file template.red next to nMars executables
;assert CORESIZE==8000

        ORG start
start   MOV.I      $start,       $next        ; copy this instruction to next address
next    END