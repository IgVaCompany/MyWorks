function [ Left,Front,Right,TotalQtyInQueOut] = TraficLogic( Red,Yellow,Green,TotalQtyInQue,ParamToTurnLeft,ParamToGoFront,ParamToGoRight)
%UNTITLED4 Summary of this function goes here
%   Detailed explanation goes here
Left = 0;
Front = 0;
Right = 0;
TotalQtyInQueOut=TotalQtyInQue;
if Yellow==1 && Red == 0
 Left   = CarsMovedThrowCrossRoad(TotalQtyInQue,ParamToTurnLeft);
 TotalQtyInQueOut = MoveCarsFrontAndRight(TotalQtyInQue,ParamToTurnLeft);
end;
if Green == 1 
    Left=0;
    Front = CarsMovedThrowCrossRoad(TotalQtyInQue, ParamToGoFront);
    TotalQtyInQueOut = MoveCarsFrontAndRight(TotalQtyInQue,ParamToGoFront);
    Right = CarsMovedThrowCrossRoad(TotalQtyInQue, ParamToGoRight);
    TotalQtyInQueOut = MoveCarsFrontAndRight(TotalQtyInQue,ParamToGoRight);
end 
if Red ==1
    Left=0;
    Front=0;
    Right =0;
    TotalQtyInQueOut = TotalQtyInQue; 
end

end

