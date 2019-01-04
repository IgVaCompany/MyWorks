m = 0.000221;
pi = 3.1415926535;
alfaG = 45;
gammaG = 90-45;
gammaR = (gammaG*pi)/180;
E = 2*(10^11);
k = 10;
deform = 0.001;
F = k*deform;
Fp = F*cos(gammaR);

numPoint = 1000;

d = 0.001;
dT = 0.0001;
maxL = 0.1;
stepL = maxL/numPoint;
pointsL = 0:stepL:maxL;

vIn = 0.003; %0.018

maxTime = maxL/vIn; 
t = dT:dT:maxTime;
L = zeros(1,length(t));

%%
for i = 1:length(L)
 L(1,i) = t(i)*vIn;
end 
%plot (t,L);

%%
yB = zeros(1,length(pointsL));
tetaBr = zeros(1,length(pointsL));
tetaBg = zeros(1,length(pointsL));
iIx = zeros(1,length(pointsL));

iIx(1,1)   = (L(1,1)*(d^3))/12;
yB(1,1)    = (Fp*((L(1,1))^3))/(3*E*iIx(1,1));
tetaBr(1,1) = (Fp*((L(1,1))^2))/(2*E*iIx(1,1));

% for i=2:length(t)
% iIx(1,i) = (L(1,i)*(d^3))/12;
% yB(1,i) = yB(1,i-1) + (F *((L(1,i))^3))/(3*(E*iIx(1,i)));
% tetaB(1,i) = (F*((L(1,i))^2))/(2*E*iIx(1,i));
% end

for i=2:length(pointsL)
    iIx(1,i)   = (L(1,i)*(d^3))/12;
    yB(1,i)    = (Fp*((L(1,i))^3))/(3*E*iIx(1,i));
    tetaBr(1,i) = (Fp*((L(1,i))^2))/(2*E*iIx(1,i));
    tetaBg(1,i) = (tetaBr(1,i)*pi)/180;
end

%%
vZ    = zeros(1,length(pointsL));
horiz = zeros(1,length(pointsL));

for i=1:length(pointsL)
    vZ(1,i) = (Fp*( (((L(1,i))^3)/6) - ( ((L(1,i))^2)*((L(1,i))/2) + (((L(1,i))^3)/3) ) ))/(E*iIx(1,i));
    horiz(1,i) = 0;
end
plot (L,vZ, L, horiz);