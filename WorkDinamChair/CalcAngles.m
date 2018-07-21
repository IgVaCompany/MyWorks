function [Angle] = CalcAngles(a,b,L)
PI = 3.141592653589793238462643;
Angle = (180/PI)*acos( (a*a + b*b - L*L) / (2*a*b) );
end

