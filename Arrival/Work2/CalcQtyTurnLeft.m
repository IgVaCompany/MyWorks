function [ QtyTurnLeft ] = CalcQtyTurnLeft( TotalQtyInQueue,ParamForOneTurn )
%UNTITLED3 Summary of this function goes here
%   Detailed explanation goes here
rest = rem(TotalQtyInQueue,FromLeftToDown);

if rest == 0 
    QtyTurnLeft = TotalQtyInQueue/FromLeftToDown;
        if QtyTurnLeft > ParamForOneTurn
            QtyTurnLeft = ParamForOneTurn;
        else 
            QtyTurnLeft = TotalQtyInQueue/FromLeftToDown;
        end
       
else 
    QtyTurnLeft =  (TotalQtyInQueue-rest)/FromLeftToDown;   
    if QtyTurnLeft > ParamForOneTurn
         QtyTurnLeft = ParamForOneTurn;
    else 
        QtyTurnLeft = (TotalQtyInQueue-rest)/FromLeftToDown; 
    end
end


end

