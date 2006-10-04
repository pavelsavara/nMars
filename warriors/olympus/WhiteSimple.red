;contact jwilkinson@mail.utexas.edu
;NSFCWT Round 2
;redcode-94
;name WhiteSimple
;author John K. Wilkinson
;strategy Uhhh... well this gets about 60/10/40.
;strategy I guess I just have to hope that no one does
;strategy too much better than that. :)

org loop-1

      dat #10,   #10+3740
      dat #10,   #10+3740
      dat #10,   #10+3740
      spl #10,   #10+3740
      spl #10,   #10+3740
      spl #10,   #10+3740
loop: mov @3, >-6
      mov @2, }-7
      djn -2, {-5000
      dat  0, -4
