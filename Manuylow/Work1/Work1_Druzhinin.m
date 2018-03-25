Pi = 3.14;
L = 3;
m = 1;
y = 0:0.01:2*Pi;
x = 0:0.005:Pi;
%%
Y = (1/(sqrt(2*Pi)))*(sqrt( ((2*L+1)*(factorial(L-abs(m))))/(2*(factorial(L+abs(m)))) ))*exp(1i*m*y)*legendreP(L,m);

%%
figure(2);
plot3(y,x,real(Y));
figure(1)
plot3(y,x,imag(Y));

%%
[y,x,real(Y)] = sphere(1);


