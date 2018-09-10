function [ QtyMove ] = MoveCarsFrontAndRight( TotalQtyInQueue,ParamToMove )
%UNTITLED Summary of this function goes here
%   Detailed explanation goes here
if TotalQtyInQueue == 0
    QtyMove = 0;
elseif ParamToMove>TotalQtyInQueue && TotalQtyInQueue>0
    QtyMove = 0;
else
    QtyMove = TotalQtyInQueue - ParamToMove;
end
    

end

