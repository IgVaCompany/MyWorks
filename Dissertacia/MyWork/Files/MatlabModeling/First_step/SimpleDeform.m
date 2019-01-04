m  = 0.000221;
pi = 3.1415926535;
g  = 9.8;
maxL = 0.1;
E = 2*(10^11);
d = 0.001;
dIn = 0.0008;
rOut = d/2;
rIn  = dIn/2;
thick = rOut-rIn;
DD = 2*(rIn+thick);
Q  = m*g;
q  = Q/maxL;
iIxs = (pi*(DD^3)*thick)/8;

yBs  = 1000*(q*(maxL^4))/(8*E*iIxs);
tetaR = (q*(maxL^3))/(6*E*iIxs);
tetaG = tetaR*(180/pi);






