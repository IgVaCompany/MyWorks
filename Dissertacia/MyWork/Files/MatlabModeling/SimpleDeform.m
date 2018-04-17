m  = 0.000221;
pi = 3.1415926535;
g  = 9.8;
maxL = 0.1;
E = 2*(10^11);
d = 0.001;
dIn = 0.0008;

Q  = m*g;
q  = Q/maxL;
iIxs = ((maxL)*((d^3) - (dIn^3)))/12;

yBs  = 1000*(q*(maxL^4))/(8*E*iIxs);





