;name PSort v1.0
;author Philipp Offermann
;strategy sorts list at relative position ITEMLIST with length ITEMS
;url http://home.t-online.de/home/offermann
;assert CORESIZE==CORESIZE
		
		org start
		
start   slt.ab  #1,#ITEMS
data1   dat.f   ITEMLIST+3,ITEMLIST+1+3
init    mov.ab  #ITEMS-1,data1-2
		mov.i   data1,data1-3
runer   slt.b   >data1-3,}data1-3
		jmp.a   return
		mov.i   {data1-3,data1-1-3
		mov.i   <data1-3,}data1-3
		mov.i   data1-1-3,>data1-3
return  djn.b   runer,data1-2
		djn.a   init,init
ende    dat.f   #256,#256
		end
