;name John's Paris
org sbomb
ptr    spl    {200, >4200
bomb   dat    {10,>4010
sbomb  spl    #20, <3900    ;execution begins here
go     mov    sbomb, >   ptr
       mov    sbomb, }   ptr
       djn.a  $go, <-100
