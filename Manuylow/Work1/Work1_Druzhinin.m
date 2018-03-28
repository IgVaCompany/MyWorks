Pi = 3.14;
L = 3;
m = 1;
y = 0:0.1:2*Pi;
x = 0:0.1:Pi;
%%
LL = legendre(L,cos(x));
Y = (1/(sqrt(2*Pi)))*(sqrt( ((2*L+1)*(factorial(L-abs(m))))/(2*(factorial(L+abs(m)))) ))*exp(1i*m*y)'*LL(2,:);
ImY = imag(Y);
ReY = real(Y);

%%
xx = (cos(y)'*sin(x));
yy = (sin(y)'*sin(x));
zz = repmat(cos(x),length(y),1);

%%
figure(1) 
surf(ImY.*xx,ImY.*yy, ImY.*zz)

%%
figure(2) 
surf(ReY.*xx,ReY.*yy, ReY.*zz)

%%
figure(3)
aY = ReY.^2 + ImY.^2;
i  = find ( x > pi/2,1);
surf(aY(i:end,:).*xx(i:end,:),aY(i:end,:).*yy(i:end,:), aY(i:end,:).*zz(i:end,:))


