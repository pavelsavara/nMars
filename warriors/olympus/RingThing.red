;redcode-94
;name Ring Thing
;author Simon Duff (sduff@cs.rmit.edu.au)
;strategy Continuously Launching 3pt Imp Rings
;strategy   A Field driven Imps by the way
;assert CORESIZE==80

	ORG	start

        spl     imp-26    
start   spl     -1        
        spl     imp+27    
imp     mov.i   #27,    *0
