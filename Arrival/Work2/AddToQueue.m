function [ QtyInQueue] = AddToQueue( CurrentQtyInQueue,NewMemberCome)
%UNTITLED2 Summary of this function goes here
%   Detailed explanation goes here
if NewMemberCome>0
    QtyInQueue = CurrentQtyInQueue+NewMemberCome;
else
    QtyInQueue = CurrentQtyInQueue;

end

