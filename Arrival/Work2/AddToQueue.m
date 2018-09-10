function [ QtyInQueue] = AddToQueue( CurrentQtyInQueue,NewMemberCome)
%UNTITLED2 Summary of this function goes here
%   Detailed explanation goes here
if NewMemberCome==1
    QtyInQueue = CurrentQtyInQueue+1;
else
    QtyInQueue = CurrentQtyInQueue;

end

