;name Gate
;author Walter Hofmann <walterh@gmx.de>

	org start
	
data	dat $0, $0
	dat $0, $0
start	jmp $start, <data
	end
