function A = step_one(A,M,h)
for i=1:M
    gam = rand(1);
    if gam <= 0.25
        A(i,1) = A(i,1) + h;
    elseif gam > 0.25 && gam <= 0.5
        A(i,1) = A(i,1) - h;
    elseif gam > 0.5 && gam <= 0.75
        A(i,2) = A(i,2) - h;
    elseif gam > 0.75
        A(i,2) = A(i,2) + h;
    end;
end;