function [ QtyTurnLeft ] = CalcQtyTurnLeft( TotalQtyInQueue,ParamForOneTurn )
%UNTITLED3 Summary of this function goes here
%   Detailed explanation goes here
rest = rem(TotalQtyInQueue,3);

if rest == 0 
    QtyTurnLeft = TotalQtyInQueue/3;
        if QtyTurnLeft > ParamForOneTurn
            QtyTurnLeft = ParamForOneTurn;
        else 
            QtyTurnLeft = TotalQtyInQueue/3;
        end
       
else 
    QtyTurnLeft =  (TotalQtyInQueue-rest)/3;   
    if QtyTurnLeft > ParamForOneTurn
         QtyTurnLeft = ParamForOneTurn;
    else 
        QtyTurnLeft = (TotalQtyInQueue-rest)/3; 
    end
end


end

