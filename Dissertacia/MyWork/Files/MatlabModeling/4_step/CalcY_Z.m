function [ y, z ] = CalcY_Z( rotationAngle,offset,clcFlag )
%UNTITLED Summary of this function goes here
%   Detailed explanation goes here
persistent yP;
if isempty(yP)
     yP=0;
end

persistent zP;
if isempty(zP)
     zP=0;
end


pi = 3.1415926535;
twoPi = 2*pi;
halfPi = pi/2;
threeTwoPi = (3*pi)/2;

if (rotationAngle > twoPi)
    angleR = mod(rotationAngle,(twoPi));   
else
    angleR = rotationAngle;    
end

if (angleR < halfPi)    
  zP = zP + offset*sin(angleR);
  yP = yP + offset*cos(angleR);
elseif (angleR >= halfPi && angleR < pi )
    angleR = pi - angleR;
  zP = zP+ offset*sin(angleR);
  yP = yP -1*offset*cos(angleR);
elseif(angleR >= pi && angleR < threeTwoPi )
  angleR =  angleR - pi;
  zP =zP -1*offset*sin(angleR);
  yP = yP -1*offset*cos(angleR);
elseif (angleR >= threeTwoPi)
  angleR = twoPi - angleR; 
  zP = zP -1*offset*sin(angleR);
  yP =yP + offset*cos(angleR);
else
    zP=zP;
    yP=yP;
end
if (clcFlag ==1)    
    yP = 0;
    zP = 0;  
end

y = yP;
z = zP;

end

