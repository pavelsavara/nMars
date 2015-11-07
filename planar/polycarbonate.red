;redcode
;name Polycarbonate
;author Planar
;strategy paper
;assert CORESIZE == 8000

        org     boot

dist0	equ	5689
dist1	equ	1021
dist2	equ	3607

away    equ     500


launch: spl     1, <-100
        spl     1, <-200
        spl     1, <-300
        spl     1, <-400

        spl     @0, <dist0
        mov.i   }-1, >-1
;;        mod.x   #1, #1
;;        spl     1, <-100
;;        spl     1, <-200
;;        spl     1, <-300
silk:   spl     @0, <dist1
        mov.i   }-1, >-1
        mov.i   bomb, >100
        mov.i   bomb, >4000
        mov.i   bomb, >-dist1-5
        mov.i   {silk, <1
        djn     @0, <dist2

bomb:   dat     <2667, <5334
last:   dat     <2667, <5334

boot:   mov     last, away
    FOR last-launch
        mov     {boot, <boot
    ROF
        jmp     @boot

i   FOR MAXLENGTH-CURLINE
        FOR (i%3 == 0)
        dat     #1, $1
        ROF
        FOR (i%3 == 1)
        dat     $1, @1
        ROF
        FOR (i%3 == 2)
        dat     @1, #1
        ROF
    ROF

        end


no bootstrap:
Results: 33 104 63   opponents/CIA.txt
Results: 38 94 68    opponents/DamageIncorporated.txt
Results: 0 58 142    opponents/Gigolo.txt
Results: 14 24 162   opponents/Impishv0.2.txt
Results: 41 32 127   opponents/NineSevenSix.txt
Results: 41 104 55   opponents/Probe.txt
Results: 41 27 132   opponents/SandstormQ0.6c.txt
Results: 31 104 65   opponents/Torcht18.txt
Results: 31 85 84    opponents/Tornado3.0.txt


boot & decoy:
Results: 39 105 56   opponents/CIA.txt
Results: 46 85 69    opponents/DamageIncorporated.txt
Results: 0 60 140    opponents/Gigolo.txt
Results: 19 27 154   opponents/Impishv0.2.txt
Results: 39 58 103   opponents/NineSevenSix.txt
Results: 43 110 47   opponents/Probe.txt
Results: 57 42 101   opponents/SandstormQ0.6c.txt
Results: 44 104 52   opponents/Torcht18.txt
Results: 22 98 80    opponents/Tornado3.0.txt
Results: 9 37 154    opponents/bluecandle[2].txt
win 15.9%  lose 36.3%  tie 47.8%  score 95.5


boot & decoy + bombe
Results: 27 119 54   opponents/CIA.txt
Results: 47 97 56    opponents/DamageIncorporated.txt
Results: 2 52 146    opponents/Gigolo.txt
Results: 14 23 163   opponents/Impishv0.2.txt
Results: 43 38 119   opponents/NineSevenSix.txt
Results: 44 109 47   opponents/Probe.txt
Results: 42 39 119   opponents/SandstormQ0.6c.txt
Results: 46 118 36   opponents/Torcht18.txt
Results: 39 91 70    opponents/Tornado3.0.txt
Results: 10 37 153   opponents/bluecandle[2].txt
win 15.7%  lose 36.1%  tie 48.1%  score 95.3


boot & decoy + bombe en 2eme partie
Results: 53 95 52    opponents/CIA.txt
Results: 50 78 72    opponents/DamageIncorporated.txt
Results: 11 53 136   opponents/Gigolo.txt
Results: 41 5 154    opponents/Impishv0.2.txt
Results: 40 36 124   opponents/NineSevenSix.txt
Results: 67 94 39    opponents/Probe.txt
Results: 44 38 118   opponents/SandstormQ0.6c.txt
Results: 48 91 61    opponents/Torcht18.txt
Results: 52 71 77    opponents/Tornado3.0.txt
Results: 24 25 151   opponents/bluecandle[2].txt
win 21.5%  lose 29.3%  tie 49.2%  score 113.7


boot & decoy + bombe en 2eme partie + bombes 2667
24.0 49.5 26.5 opponents/CIA.txt
25.5 40.0 34.5 opponents/DamageIncorporated.txt
6.0 26.5 67.5 opponents/Gigolo.txt
12.0 4.0 84.0 opponents/Impishv0.2.txt
24.5 16.5 59.0 opponents/NineSevenSix.txt
26.0 54.5 19.5 opponents/Probe.txt
25.0 22.0 53.0 opponents/SandstormQ0.6c.txt
20.5 51.0 28.5 opponents/Torcht18.txt
24.0 38.5 37.5 opponents/Tornado3.0.txt
11.0 12.0 77.0 opponents/bluecandle[2].txt
win 19.9%  lose 31.4%  tie 48.7%  score 108.2


boot & decoy + 2 bombes en 2eme partie + bombes 2667
33.0 42.0 25.0 opponents/CIA.txt
27.0 39.5 33.5 opponents/DamageIncorporated.txt
11.0 34.0 55.0 opponents/Gigolo.txt
14.0 6.5 79.5 opponents/Impishv0.2.txt
26.0 22.0 52.0 opponents/NineSevenSix.txt
28.0 48.0 24.0 opponents/Probe.txt
31.0 18.0 51.0 opponents/SandstormQ0.6c.txt
28.0 41.0 31.0 opponents/Torcht18.txt
32.0 32.0 36.0 opponents/Tornado3.0.txt
10.0 13.5 76.5 opponents/bluecandle[2].txt
win 24.0%  lose 29.6%  tie 46.4%  score 118.3


regroupement par djn
28.0 43.5 28.5 opponents/CIA.txt
28.5 30.0 41.5 opponents/DamageIncorporated.txt
2.5 52.0 45.5 opponents/Gigolo.txt
8.5 21.0 70.5 opponents/Impishv0.2.txt
16.5 27.0 56.5 opponents/NineSevenSix.txt
30.5 53.0 16.5 opponents/Probe.txt
30.5 22.0 47.5 opponents/SandstormQ0.6c.txt
26.0 44.5 29.5 opponents/Torcht18.txt
26.0 41.5 32.5 opponents/Tornado3.0.txt
6.5 20.5 73.0 opponents/bluecandle[2].txt
win 20.4%  lose 35.5%  tie 44.1%  score 105.2


sans regroupement
35.0 57.5 07.5 opponents/CIA.txt
29.5 57.0 13.5 opponents/DamageIncorporated.txt
05.0 58.0 37.0 opponents/Gigolo.txt
06.5 27.5 66.0 opponents/Impishv0.2.txt
18.5 42.0 39.5 opponents/NineSevenSix.txt
23.5 71.0 05.5 opponents/Probe.txt
24.5 36.5 39.0 opponents/SandstormQ0.6c.txt
35.0 51.5 13.5 opponents/Torcht18.txt
31.5 51.0 17.5 opponents/Tornado3.0.txt
06.0 48.0 46.0 opponents/bluecandle[2].txt
win 21.5%  lose 50.0%  tie 28.5%  score 93.0


regroupement par 1 x 4
08.0 53.5 38.5 opponents/CIA.txt
21.5 26.5 52.0 opponents/DamageIncorporated.txt
02.0 36.0 62.0 opponents/Gigolo.txt
00.0 16.0 84.0 opponents/Impishv0.2.txt
06.0 32.0 62.0 opponents/NineSevenSix.txt
12.0 55.0 33.0 opponents/Probe.txt
06.5 29.0 64.5 opponents/SandstormQ0.6c.txt
18.5 41.5 40.0 opponents/Torcht18.txt
12.5 43.5 44.0 opponents/Tornado3.0.txt
01.5 15.0 83.5 opponents/bluecandle[2].txt
win 8.8%  lose 34.8%  tie 56.4%  score 82.9


regroupement 1 x 8
29.5 41.5 29.0 opponents/CIA.txt
29.0 30.0 41.0 opponents/DamageIncorporated.txt
04.5 40.5 55.0 opponents/Gigolo.txt
09.0 20.0 71.0 opponents/Impishv0.2.txt
13.5 23.0 63.5 opponents/NineSevenSix.txt
29.0 54.0 17.0 opponents/Probe.txt
28.0 31.5 40.5 opponents/SandstormQ0.6c.txt
34.5 35.0 30.5 opponents/Torcht18.txt
27.0 31.5 41.5 opponents/Tornado3.0.txt
06.0 18.5 75.5 opponents/bluecandle[2].txt
win 21.0%  lose 32.5%  tie 46.5%  score 109.5


regroupement 1 x 8
33.5 42.0 24.5 opponents/CIA.txt
32.0 30.0 38.0 opponents/DamageIncorporated.txt
04.5 44.0 51.5 opponents/Gigolo.txt
10.5 23.0 66.5 opponents/Impishv0.2.txt
12.5 24.5 63.0 opponents/NineSevenSix.txt
30.0 45.5 24.5 opponents/Probe.txt
29.5 29.0 41.5 opponents/SandstormQ0.6c.txt
29.5 36.5 34.0 opponents/Torcht18.txt
25.5 35.5 39.0 opponents/Tornado3.0.txt
08.0 14.0 78.0 opponents/bluecandle[2].txt
win 21.6%  lose 32.4%  tie 46.0%  score 110.7


regroupement 1 x 8, 3 bombes
32.5 42.0 25.5 opponents/CIA.txt
31.0 30.5 38.5 opponents/DamageIncorporated.txt
03.0 50.5 46.5 opponents/Gigolo.txt
08.5 20.0 71.5 opponents/Impishv0.2.txt
15.0 27.0 58.0 opponents/NineSevenSix.txt
30.5 47.5 22.0 opponents/Probe.txt
31.0 30.0 39.0 opponents/SandstormQ0.6c.txt
39.0 35.0 26.0 opponents/Torcht18.txt
30.0 34.0 36.0 opponents/Tornado3.0.txt
12.0 13.5 74.5 opponents/bluecandle[2].txt
win 23.3%  lose 33.0%  tie 43.8%  score 113.5


regroupement 1 x 8, 3 bombes
36.0 41.0 23.0 opponents/CIA.txt
34.0 31.5 34.5 opponents/DamageIncorporated.txt
07.0 47.0 46.0 opponents/Gigolo.txt
09.0 23.0 68.0 opponents/Impishv0.2.txt
19.5 23.5 57.0 opponents/NineSevenSix.txt
34.0 40.5 25.5 opponents/Probe.txt
29.0 31.0 40.0 opponents/SandstormQ0.6c.txt
33.5 37.5 29.0 opponents/Torcht18.txt
26.0 30.5 43.5 opponents/Tornado3.0.txt
11.5 23.0 65.5 opponents/bluecandle[2].txt
win 23.9%  lose 32.9%  tie 43.2%  score 115.0


regroupement 1 x 8, 4 bombes
24.5 41.0 34.5 opponents/CIA.txt
31.5 27.0 41.5 opponents/DamageIncorporated.txt
02.5 34.5 63.0 opponents/Gigolo.txt
04.5 09.5 86.0 opponents/Impishv0.2.txt
10.0 22.5 67.5 opponents/NineSevenSix.txt
28.5 47.0 24.5 opponents/Probe.txt
16.5 30.5 53.0 opponents/SandstormQ0.6c.txt
30.0 30.5 39.5 opponents/Torcht18.txt
20.0 38.0 42.0 opponents/Tornado3.0.txt
06.0 15.5 78.5 opponents/bluecandle[2].txt
win 17.4%  lose 29.6%  tie 53.0%  score 105.2


paper classique, 3 bombes
28.5 43.0 28.5 opponents/CIA.txt
34.0 30.0 36.0 opponents/DamageIncorporated.txt
05.0 30.5 64.5 opponents/Gigolo.txt
04.5 15.5 80.0 opponents/Impishv0.2.txt
16.5 21.5 62.0 opponents/NineSevenSix.txt
33.0 49.0 18.0 opponents/Probe.txt
39.0 17.0 44.0 opponents/SandstormQ0.6c.txt
36.0 43.0 21.0 opponents/Torcht18.txt
22.5 38.5 39.0 opponents/Tornado3.0.txt
10.0 18.5 71.5 opponents/bluecandle[2].txt
win 22.9%  lose 30.6%  tie 46.5%  score 115.2


regroupement 1 x 8, 3 bombes, seulement 3 dats (au lieu de 6)
26.5 42.5 31.0 opponents/CIA.txt
32.5 31.0 36.5 opponents/DamageIncorporated.txt
04.5 31.0 64.5 opponents/Gigolo.txt
06.5 13.0 80.5 opponents/Impishv0.2.txt
14.5 21.0 64.5 opponents/NineSevenSix.txt
37.5 34.5 28.0 opponents/Probe.txt
34.5 24.0 41.5 opponents/SandstormQ0.6c.txt
30.0 38.0 32.0 opponents/Torcht18.txt
28.0 36.0 36.0 opponents/Tornado3.0.txt
14.0 17.5 68.5 opponents/bluecandle[2].txt
win 22.9%  lose 28.9%  tie 48.3%  score 116.8


regroupement 1 x 8, core-clear au lieu de bombes
24.0 52.0 24.0 opponents/CIA.txt
33.0 31.5 35.5 opponents/DamageIncorporated.txt
08.5 23.5 68.0 opponents/Gigolo.txt
06.0 22.5 71.5 opponents/Impishv0.2.txt
21.0 25.0 54.0 opponents/NineSevenSix.txt
26.5 54.0 19.5 opponents/Probe.txt
32.0 20.5 47.5 opponents/SandstormQ0.6c.txt
32.0 37.5 30.5 opponents/Torcht18.txt
24.5 39.5 36.0 opponents/Tornado3.0.txt
11.0 26.5 62.5 opponents/bluecandle[2].txt
win 21.9%  lose 33.3%  tie 44.9%  score 110.5


regroupement 2 x 8, 3 bombes dont une sur l'oncle
34.0 50.5 15.5 opponents/CIA.txt
29.0 40.5 30.5 opponents/DamageIncorporated.txt
06.5 37.5 56.0 opponents/Gigolo.txt
04.5 20.0 75.5 opponents/Impishv0.2.txt
19.0 24.5 56.5 opponents/NineSevenSix.txt
26.5 54.0 19.5 opponents/Probe.txt
34.5 24.0 41.5 opponents/SandstormQ0.6c.txt
32.0 43.0 25.0 opponents/Torcht18.txt
21.5 45.5 33.0 opponents/Tornado3.0.txt
15.0 27.5 57.5 opponents/bluecandle[2].txt
win 22.3%  lose 36.7%  tie 41.0%  score 107.8


regroupement 2 x 4, 3 bombes dont une sur l'oncle
25.5 46.0 28.5 opponents/CIA.txt
32.0 30.0 38.0 opponents/DamageIncorporated.txt
02.5 38.5 59.0 opponents/Gigolo.txt
04.5 20.0 75.5 opponents/Impishv0.2.txt
13.5 23.0 63.5 opponents/NineSevenSix.txt
26.0 54.0 20.0 opponents/Probe.txt
23.0 27.5 49.5 opponents/SandstormQ0.6c.txt
22.5 40.0 37.5 opponents/Torcht18.txt
19.0 37.0 44.0 opponents/Tornado3.0.txt
08.0 22.0 70.0 opponents/bluecandle[2].txt
win 17.6%  lose 33.8%  tie 48.5%  score 101.5


regroupement 1 x 16, 3 bombes dont une sur l'oncle
35.0 48.5 16.5 opponents/CIA.txt
30.5 41.5 28.0 opponents/DamageIncorporated.txt
05.5 37.5 57.0 opponents/Gigolo.txt
10.0 20.5 69.5 opponents/Impishv0.2.txt
17.0 34.5 48.5 opponents/NineSevenSix.txt
28.0 58.5 13.5 opponents/Probe.txt
39.0 24.0 37.0 opponents/SandstormQ0.6c.txt
30.0 43.0 27.0 opponents/Torcht18.txt
23.0 47.5 29.5 opponents/Tornado3.0.txt
16.5 28.5 55.0 opponents/bluecandle[2].txt
win 23.4%  lose 38.4%  tie 38.1%  score 108.5


regroupement 1 x 8, 3 bombes (oncle) et un seul dat
29.0 45.5 25.5 opponents/CIA.txt
29.5 29.0 41.5 opponents/DamageIncorporated.txt
06.0 33.5 60.5 opponents/Gigolo.txt
05.5 20.5 74.0 opponents/Impishv0.2.txt
27.5 16.5 56.0 opponents/NineSevenSix.txt
31.5 42.5 26.0 opponents/Probe.txt
31.0 20.5 48.5 opponents/SandstormQ0.6c.txt
29.5 45.5 25.0 opponents/Torcht18.txt
27.0 40.5 32.5 opponents/Tornado3.0.txt
11.0 23.5 65.5 opponents/bluecandle[2].txt
win 22.8%  lose 31.8%  tie 45.5%  score 113.7


regroupement 1 x 8, 3 bombes (oncle) et 2 dat
32.0 41.5 26.5 opponents/CIA.txt
34.5 28.0 37.5 opponents/DamageIncorporated.txt
05.5 32.0 62.5 opponents/Gigolo.txt
06.0 17.0 77.0 opponents/Impishv0.2.txt
20.0 21.5 58.5 opponents/NineSevenSix.txt
28.5 52.0 19.5 opponents/Probe.txt
33.5 24.0 42.5 opponents/SandstormQ0.6c.txt
32.0 39.5 28.5 opponents/Torcht18.txt
25.0 38.0 37.0 opponents/Tornado3.0.txt
11.0 16.0 73.0 opponents/bluecandle[2].txt
win 22.8%  lose 30.9%  tie 46.3%  score 114.7


idem, deuxieme bombe en 100 (au lieu de 2000)
36.0 38.5 25.5 opponents/CIA.txt
35.5 26.0 38.5 opponents/DamageIncorporated.txt
02.5 31.0 66.5 opponents/Gigolo.txt
06.5 15.5 78.0 opponents/Impishv0.2.txt
18.0 22.0 60.0 opponents/NineSevenSix.txt
38.5 36.5 25.0 opponents/Probe.txt
34.0 18.0 48.0 opponents/SandstormQ0.6c.txt
30.5 40.5 29.0 opponents/Torcht18.txt
22.5 37.0 40.5 opponents/Tornado3.0.txt
10.0 18.5 71.5 opponents/bluecandle[2].txt
win 23.4%  lose 28.4%  tie 48.3%  score 118.5


idem, deuxieme bombe sur le cousin
29.0 44.5 26.5 opponents/CIA.txt
30.5 32.0 37.5 opponents/DamageIncorporated.txt
05.0 37.0 58.0 opponents/Gigolo.txt
00.5 20.0 79.5 opponents/Impishv0.2.txt
16.5 25.5 58.0 opponents/NineSevenSix.txt
26.5 52.5 21.0 opponents/Probe.txt
33.0 28.5 38.5 opponents/SandstormQ0.6c.txt
35.0 43.0 22.0 opponents/Torcht18.txt
26.5 38.0 35.5 opponents/Tornado3.0.txt
12.5 19.0 68.5 opponents/bluecandle[2].txt
win 21.5%  lose 34.0%  tie 44.5%  score 109.0


premiere bombe en 100 et deuxieme sur le cousin
36.0 39.5 24.5 opponents/CIA.txt
37.5 25.5 37.0 opponents/DamageIncorporated.txt
04.5 40.5 55.0 opponents/Gigolo.txt
05.5 13.0 81.5 opponents/Impishv0.2.txt
20.0 16.0 64.0 opponents/NineSevenSix.txt
27.5 45.5 27.0 opponents/Probe.txt
31.0 22.5 46.5 opponents/SandstormQ0.6c.txt
29.0 38.5 32.5 opponents/Torcht18.txt
24.0 38.0 38.0 opponents/Tornado3.0.txt
09.5 17.5 73.0 opponents/bluecandle[2].txt
win 22.4%  lose 29.6%  tie 47.9%  score 115.2


idem avec regroupement par djn
30.5 39.5 30.0 opponents/CIA.txt
28.5 36.0 35.5 opponents/DamageIncorporated.txt
04.5 44.0 51.5 opponents/Gigolo.txt
06.5 16.0 77.5 opponents/Impishv0.2.txt
21.0 24.0 55.0 opponents/NineSevenSix.txt
31.5 47.0 21.5 opponents/Probe.txt
38.0 22.0 40.0 opponents/SandstormQ0.6c.txt
31.0 49.0 20.0 opponents/Torcht18.txt
27.5 35.5 37.0 opponents/Tornado3.0.txt
17.5 13.5 69.0 opponents/bluecandle[2].txt
win 23.6%  lose 32.6%  tie 43.7%  score 114.7


avec mov/jmp pour la derniere copie
28.5 44.5 27.0 opponents/CIA.txt
21.5 43.0 35.5 opponents/DamageIncorporated.txt
17.0 30.5 52.5 opponents/Gigolo.txt
21.5 11.0 67.5 opponents/Impishv0.2.txt
25.5 21.5 53.0 opponents/NineSevenSix.txt
33.5 44.0 22.5 opponents/Probe.txt
35.5 16.5 48.0 opponents/SandstormQ0.6c.txt
29.0 46.5 24.5 opponents/Torcht18.txt
23.0 38.0 39.0 opponents/Tornado3.0.txt
24.0 11.0 65.0 opponents/bluecandle[2].txt
win 25.9%  lose 30.6%  tie 43.5%  score 121.2


avec mov/djn pour la derniere copie
27.5 42.0 30.5 opponents/CIA.txt
34.0 35.5 30.5 opponents/DamageIncorporated.txt
03.5 30.0 66.5 opponents/Gigolo.txt
09.0 06.0 85.0 opponents/Impishv0.2.txt
27.5 18.0 54.5 opponents/NineSevenSix.txt
25.5 46.5 28.0 opponents/Probe.txt
27.5 15.0 57.5 opponents/SandstormQ0.6c.txt
20.0 46.5 33.5 opponents/Torcht18.txt
28.5 29.0 42.5 opponents/Tornado3.0.txt
14.5 10.5 75.0 opponents/bluecandle[2].txt
win 21.8%  lose 27.9%  tie 50.4%  score 115.6


avec djn @0, <dist2
34.0 49.0 17.0 opponents/CIA.txt
28.5 39.0 32.5 opponents/DamageIncorporated.txt
16.5 34.0 49.5 opponents/Gigolo.txt
23.5 11.5 65.0 opponents/Impishv0.2.txt
34.0 20.5 45.5 opponents/NineSevenSix.txt
36.5 45.0 18.5 opponents/Probe.txt
32.0 14.5 53.5 opponents/SandstormQ0.6c.txt
22.0 49.0 29.0 opponents/Torcht18.txt
30.5 34.0 35.5 opponents/Tornado3.0.txt
17.5 17.5 65.0 opponents/bluecandle[2].txt
win 27.5%  lose 31.4%  tie 41.1%  score 123.6


avec un core-clear a deux mov
16.5 42.0 41.5 opponents/CIA.txt
24.0 27.0 49.0 opponents/DamageIncorporated.txt
01.0 17.5 81.5 opponents/Gigolo.txt
05.0 19.5 75.5 opponents/Impishv0.2.txt
10.0 33.5 56.5 opponents/NineSevenSix.txt
15.5 59.5 25.0 opponents/Probe.txt
12.0 39.0 49.0 opponents/SandstormQ0.6c.txt
21.5 48.0 30.5 opponents/Torcht18.txt
13.0 47.0 40.0 opponents/Tornado3.0.txt
02.5 27.0 70.5 opponents/bluecandle[2].txt
win 12.1%  lose 36.0%  tie 51.9%  score 88.2


sans regroupement
34.0 52.0 14.0 opponents/CIA.txt
37.0 38.5 24.5 opponents/DamageIncorporated.txt
13.5 36.0 50.5 opponents/Gigolo.txt
18.5 19.0 62.5 opponents/Impishv0.2.txt
25.5 19.5 55.0 opponents/NineSevenSix.txt
33.0 48.5 18.5 opponents/Probe.txt
34.0 09.0 57.0 opponents/SandstormQ0.6c.txt
21.0 53.0 26.0 opponents/Torcht18.txt
33.0 36.0 31.0 opponents/Tornado3.0.txt
16.5 17.5 66.0 opponents/bluecandle[2].txt
win 26.6%  lose 32.9%  tie 40.5%  score 120.3
