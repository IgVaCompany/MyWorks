function [ L ] = Calc_L_UndoAlfa( a,b, alfa )
%UNTITLED3 Summary of this function goes here
%   Detailed explanation goes here
PI = 3.141592653589793238462643;
angleInRad = alfa*(PI/180);
L =sqrt( a*a + b*b - 2*a*b*cos(angleInRad));

end

