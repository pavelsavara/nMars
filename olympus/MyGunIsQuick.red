;redcode
;name MyGunIsQuick
;author P.Kline
;assert CORESIZE == 80
;strategy stone then imp
;title is from a Mike Hammer novel

m0       mov    mm   ,{mm
         djn.a  -1   ,mm
         spl    #0   ,<-5
mm       mov    -7   ,1
