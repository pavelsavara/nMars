;redcode
;name Consort
;author Robert Hale
;contact rghale@market1.com
;assert 1
;strategy       A simple bubble sort.
;strategy       Optimized to be long and slow.  ;) 
;strategy       Ok maybe not so long but it is a N^2 sort.
 
 
inc     add.f   #1, comp
comp    slt.b   ITEMLIST, ITEMLIST+1
done    jmp     loop, #1
 
swap    mov.i   *comp, tEnd+1
	mov.i   @comp, *comp
	mov.i   tEnd+1, @comp
	mov.ab  #0, done
 
loop    djn     inc, #ITEMS-1
 
check   jmn.b   tEnd+1, done
 
;reset flag, counter and pointers
	mov.ab  #1, done
	mov.ab  #ITEMS-1, loop
	sub.a   #ITEMS-2, comp
	sub.ab  #ITEMS-2, comp
tEnd    jmp     comp
 
	end     comp
