function [ y, z ] = CalcY_Z( rotationAngle,offset )
%UNTITLED Summary of this function goes here
%   Detailed explanation goes here
pi = 3.1415926535;
if rotationAngle>360
    angleR = (mod(rotationAngle,360)*pi)/180;
    angleG = mod(rotationAngle,360);
else
    angleR = (rotationAngle*pi)/180;
    angleG = rotationAngle;
end

if (angleG < 90)    
  z = offset*sin(angleR);
  y = offset*cos(angleR);
elseif (angleG >= 90 && angleG < 180 )
    angleR = 1.57079632675 - angleR;
  z = offset*sin(angleR);
  y = -1*offset*cos(angleR);
elseif(angleG >=180 && angleG < 270 )
  angleR =  angleR - 1.57079632675;
  z = -1*offset*sin(angleR);
  y = -1*offset*cos(angleR);
elseif (angleG >= 270)
  angleR = pi - angleR; 
  z = -1*offset*sin(angleR);
  y = offset*cos(angleR);
else
    z=0;
    y=0;
end
end

