function [ GoTo ] = CarsMovedThrowCrossRoad(TotalQtyInQueue, ParamMove  )
%UNTITLED2 Summary of this function goes here
%   Detailed explanation goes here
if TotalQtyInQueue == 0
    GoTo = 0;
elseif ParamMove>TotalQtyInQueue && TotalQtyInQueue>0
    GoTo = TotalQtyInQueue;
else 
    GoTo = ParamMove;
end

end

