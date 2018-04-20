%m = 0.000221;
pi = 3.1415926535;
alfaG = 60;
gammaG = 90-alfaG;
gammaR = (gammaG*pi)/180;
E = 2*(10^11);
d = 0.001;
rOut = d/2;
dIn  = 0.0008;
rIn  = dIn/2;
thick = rOut-rIn;
DD = 2*(rIn+thick);

%s = pi*(d/2)*(d/2);
rho = [1500, 1300, 1100, 1000, 900];

vIn = [0.003, 0.006, 0.009, 0.012, 0.015,0.018, 0.021, 0.024, 0.027, 0.03]; %0.018
numPoint = 10000000;
maxL = 0.1;
stepL = maxL/numPoint;
pointsL = stepL:stepL:maxL;
cF = 1.15;%0.82;%1.15;
yBend = zeros(length(vIn),length(rho));
%%
for k = 1:length(rho)
    
    for h = 1:length(vIn)

        maxTime = maxL/vIn(1,h); 
        dT = maxTime/length(pointsL);
        pointsT  =dT:dT:maxTime;
        s = zeros(1,length(pointsL));
        
        for i=1:length(pointsL)
            s(1,i) = pi*(d/2)*(d/2)*pointsL(1,i);
        end

        envF  =  zeros(1,length(pointsL));
        envFp =  zeros(1,length(pointsL));
        
        for i=1:length(pointsL)
            envF(1,i)  = cF*s(1,i)*( (rho(1,k)*vIn(1,h)*vIn(1,h))/2  );  
            envFp(1,i) = envF(1,i)*cos(gammaR);
        end

        yB = zeros(1,length(pointsL));
        tetaBr = zeros(1,length(pointsL));
        tetaBg = zeros(1,length(pointsL));
        iIx = zeros(1,length(pointsL));

        iIx(1,1)   =  (pi*(DD^3)*thick)/8; %((pointsL(1,1))*((d^3) - (dIn^3)))/12;
        yB(1,1)    = 1000*(envFp(1,1)*((pointsL(1,1))^3))/(3*E*iIx(1,1));
        tetaBr(1,1) = (envFp(1,1)*((pointsL(1,1))^2))/(2*E*iIx(1,1));

        for i=2:length(pointsL)
            iIx(1,i)   = (pi*(DD^3)*thick)/8;%(pointsL(1,i)*((d^3) - (dIn^3)))/12;
            yB(1,i)    = yB(1,i-1) + 1000*(envFp(1,i)*((pointsL(1,i))^3))/(3*E*iIx(1,i));
            tetaBr(1,i) = (envFp(1,i)*((pointsL(1,i))^2))/(2*E*iIx(1,i));
            tetaBg(1,i) = (tetaBr(1,i)*pi)/180;
        end
        yBend(h,k) = yB(1,length(pointsL));
    end
end

%  vZ    = zeros(1,length(pointsL));
%  horiz = zeros(1,length(pointsL));
% 
% for i=1:length(pointsL)
%     vZ(1,i) = (envFp(1,i)*( (((pointsL(1,i))^3)/6) - ( ((pointsL(1,i))^2)*((pointsL(1,i))/2) + (((pointsL(1,i))^3)/3) ) ))/(E*iIx(1,i));
%     horiz(1,i) = 0;
% end
%  plot (pointsL,vZ, pointsL, horiz);