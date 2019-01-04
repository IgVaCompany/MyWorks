function [ offset,angleOffset,x,y,z,insL,qtyCalcPoints,checkTime,stopCalc ] = CalcFunction_v_0( time, velocityInsertion, velocityRotation)
%CALCFUNCTION_V_0 Summary of this function goes here
%   Detailed explanation goes here
numPoint = 100000; %100000 qty of parts of needle 

persistent qtyOfNumPoints; % save passed steps
if isempty(qtyOfNumPoints)
     qtyOfNumPoints=0;
end

persistent remainder; 
if isempty(remainder)
     remainder=0;
end

maxL = 0.1;
stepL = maxL/numPoint;
maxTime = maxL/velocityInsertion; 
dT = maxTime/numPoint;

persistent timeOutOfModelSave; % save time from last out of model send 
if isempty(timeOutOfModelSave)
     timeOutOfModelSave=0;
end

persistent dT_outOfModel; % calc time step out of model
if isempty(dT_outOfModel)
     dT_outOfModel=0;
end

dT_outOfModel = (time + remainder) -timeOutOfModelSave;

persistent insertionL; % inner needle 
if isempty(insertionL)
     insertionL=0;
end
persistent rotationL; % rotation needle 
if isempty(rotationL)
     rotationL=0;
end
modelSteps = fix(dT_outOfModel/dT);
remainder = rem(dT_outOfModel,dT);


pointsL = stepL:stepL:maxL;

persistent offsetP;
if isempty(offsetP)
     offsetP=0;
end

persistent angleOffsetP;
if isempty(angleOffsetP)
     angleOffsetP=0;
end

persistent xP;
if isempty(xP)
     xP=0;
end

persistent yP;
if isempty(yP)
     yP=0;
end

persistent zP;
if isempty(zP)
     zP=0;
end

pi = 3.1415926535;
alfaG = 45;
gammaG = 90-alfaG;
gammaR = (gammaG*pi)/180;
alfaR = (alfaG*pi)/180;
%E = 2*(10^8);
E = 2*(10^11);
d = 0.001;
dIn = 0.0008;
rOut = d/2;
rIn  = dIn/2;
thick = rOut-rIn;
DD = 2*(rIn+thick);
%s = pi*(d/2)*(d/2);
rho = 1000;%1500;
cF = 0.82;%0.82;%1.15;

if (time<=maxTime) % && dT_outOfModel>dT time<=maxTime qtyOfNumPoints <= numPoint
    stopCalc = 0;
    for i = 1:modelSteps        
        qtyOfNumPoints = qtyOfNumPoints + 1;
        insertionL = insertionL + dT*velocityInsertion;
        rotationL = rotationL +dT*velocityRotation;
        s = ((pi*rOut*rOut)*insertionL)^(2/3);
        envF  = cF*s*((rho*velocityInsertion*velocityInsertion)/2  );  
        envFp = envF*cos(gammaR);
        iIx   = (pi*(DD^3)*thick)/8;
        offsetP = offsetP + 1000*(envFp*((insertionL)^3))/(3*E*iIx(1,1)); %product on 1000 for convert m to mm      
        xP = insertionL;
        [yP,zP] = CalcY_Z(rotationL,offsetP);
    end         
else
    stopCalc = 1;
end

offset = offsetP;
angleOffset = qtyOfNumPoints;
x = xP;
y = yP;
z = zP;
insL = insertionL;
qtyCalcPoints = qtyOfNumPoints;

timeOutOfModelSave = time;
checkTime = timeOutOfModelSave;
end

