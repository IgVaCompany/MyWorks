function [res, res2, res3,res4, const, array]=Testdll(a,b,z)
persistent n;
const = 10;
array = [10,11,12];
res =sqrt(a*a + b*b);
res2 = a*a+b*b;
res3 = includes(z);
 if isempty(n)
     n=0;
 end
n = n + z;
res4 = n;
end

