m = 0.000221;
pi = 3.1415926535;
alfaG = 45;
gammaG = 90-45;
gammaR = (gammaG*pi)/180;
E = 2*(10^11);
d = 0.001;
dIn = 0.0008;
s = pi*(d/2)*(d/2);
rho = 1300;

vIn = 0.003; %0.018
numPoint = 10000000;
maxL = 0.1;
stepL = maxL/numPoint;
pointsL = stepL:stepL:maxL;

maxTime = maxL/vIn; 
dT = maxTime/length(pointsL);
pointsT  =dT:dT:maxTime;

needleF = zeros(1,length(pointsL));
needleF(1,1) = (m*vIn);

for i=2:length(pointsL)
  needleF(1,i)= (m*vIn)/(pointsT(1,i)-pointsT(1,i-1));  
end

cF = zeros(1,length(pointsL));
for i=1:length(pointsL)
    cF(1,i)  = (2*(needleF(1,i)))/(rho*vIn*vIn*s);  
end

envF  = zeros(1,length(pointsL));
envFp = zeros(1,length(pointsL));
for i=1:length(pointsL)
    envF(1,i)  = cF(1,i)*s*( (rho*vIn*vIn)/2  );  
    envFp(1,i) = envF(1,i)*cos(gammaR);
end


%%
yB = zeros(1,length(pointsL));
tetaBr = zeros(1,length(pointsL));
tetaBg = zeros(1,length(pointsL));
iIx = zeros(1,length(pointsL));

iIx(1,1)   = ((pointsL(1,1))*((d^3) - (dIn^3)))/12;
yB(1,1)    = 1000*(envFp(1,1)*((pointsL(1,1))^3))/(3*E*iIx(1,1));
tetaBr(1,1) = (envFp(1,1)*((pointsL(1,1))^2))/(2*E*iIx(1,1));

% for i=2:length(t)
% iIx(1,i) = (L(1,i)*(d^3))/12;
% yB(1,i) = yB(1,i-1) + (F *((L(1,i))^3))/(3*(E*iIx(1,i)));
% tetaB(1,i) = (F*((L(1,i))^2))/(2*E*iIx(1,i));
% end

for i=2:length(pointsL)
    iIx(1,i)   = (pointsL(1,i)*((d^3) - (dIn^3)))/12;
    yB(1,i)    = yB(1,i-1)+1000*(envFp(1,i)*((pointsL(1,i))^3))/(3*E*iIx(1,i));
    tetaBr(1,i) = (envFp(1,i)*((pointsL(1,i))^2))/(2*E*iIx(1,i));
    tetaBg(1,i) = (tetaBr(1,i)*pi)/180;
end
%%
%  vZ    = zeros(1,length(pointsL));
%  horiz = zeros(1,length(pointsL));
% 
% for i=1:length(pointsL)
%     vZ(1,i) = (envFp(1,i)*( (((pointsL(1,i))^3)/6) - ( ((pointsL(1,i))^2)*((pointsL(1,i))/2) + (((pointsL(1,i))^3)/3) ) ))/(E*iIx(1,i));
%     horiz(1,i) = 0;
% end
%  plot (pointsL,vZ, pointsL, horiz);