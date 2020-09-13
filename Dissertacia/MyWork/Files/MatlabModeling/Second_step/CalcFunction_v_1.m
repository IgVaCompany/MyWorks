function [ offset,angleOffset,x,y,z,insL,qtyCalcPoints,checkTime,stopCalc ] =...
    CalcFunction_v_1( time, velocityInsertion, velocityRotation,clcFlag)
%CALCFUNCTION_V_0 Summary of this function goes here
%   Detailed explanation goes here
%cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeling\dll\Vusual\New\Assets');
numPoint = 100000; %100000 qty of parts of needle 
pi = 3.1415926535;
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
RotationLength = maxTime*velocityRotation;
angleForCalc = RotationLength/numPoint;
dT = maxTime/numPoint;
% if (velocityRotation ~= 0)
%     dT = angleForCalc/velocityRotation;
% else
%     dT = maxTime/numPoint;
% end

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

persistent offset_YZ;
if isempty(offset_YZ)
     offset_YZ=0;
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
        rotationL = rotationL + angleForCalc;
        s = ((pi*rOut*rOut)*insertionL)^(2/3);
        envF  = cF*s*((rho*velocityInsertion*velocityInsertion)/2  );  
        envFp = envF*cos(gammaR);
        iIx   = (pi*(DD^3)*thick)/8;
        offsetLocal =  1000*(envFp*((insertionL)^3))/(3*E*iIx(1,1)); %product on 1000 for convert m to mm
        offsetP = offsetP + offsetLocal; %product on 1000 for convert m to mm      
        xP = insertionL;
        %offsetLocal =  1000*(envFp*((insertionL)^3))/(3*E*iIx(1,1)); %product on 1000 for convert m to mm 
        [yP,zP] = CalcY_Z(rotationL,offsetLocal,clcFlag);
        offset_YZ = sqrt(yP*yP +zP*zP);
    end         
else
    stopCalc = 1;
end



if (clcFlag == 1)
    xP = 0;
    yP = 0;
    zP = 0;
    qtyOfNumPoints = 0;
    remainder = 0;
    timeOutOfModelSave = 0;
    dT_outOfModel = 0;
    insertionL = 0;
    rotationL = 0;
    offsetP = 0;
    offset_YZ = 0;
    angleOffsetP = 0;
end

%offset = offsetP;
offset = offset_YZ;
angleOffset = rotationL;

insL = insertionL;
qtyCalcPoints = qtyOfNumPoints;

timeOutOfModelSave = time;
checkTime = timeOutOfModelSave;

x = xP;
y = yP;
z = zP;


end

