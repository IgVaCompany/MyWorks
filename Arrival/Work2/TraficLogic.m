function [ Left,Front,Right,TotalQtyInQueOut] = TraficLogic( Red,Yellow,Green,TotalQtyInQue,ParamToTurnLeft,ParamToGoFront,ParamToGoRight)
%UNTITLED4 Summary of this function goes here
%   Detailed explanation goes here
 Left=0;
 Front=0;
 Right =0;
if Yellow==1 && Red == 0
    Left   = CarsMovedThrowCrossRoad(TotalQtyInQue,ParamToTurnLeft);
    Front=0;
    Right =0;
end;
if Green == 1 
    Left=0;
    Front = CarsMovedThrowCrossRoad(TotalQtyInQue, ParamToGoFront);
    Right = CarsMovedThrowCrossRoad(TotalQtyInQue, ParamToGoRight);
end 
if Red ==1
    Left=0;
    Front=0;
    Right =0;
end
TotalOut = Left + Front + Right;

if TotalOut>=TotalQtyInQue
    TotalOut = 0;
else
    TotalOut = TotalQtyInQue - Left - Front - Right;
end    
TotalQtyInQueOut = TotalOut;
end

