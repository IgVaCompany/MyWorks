close all;
clear all;
clc;

N = 200;
M = 200;
h = 1;

MaxSize = 30;

A = zeros(M, 2);
x = zeros(M,1);
y = zeros(M,1);

for i=1:M
    r = rand(1);
    theta = 2 * pi * rand(1);
    A(i,1) = r .* cos(theta);
    A(i,2) = r .* sin(theta);
end;

x = A(:,1);
y = A(:,2);

plot(x,y,'o');
axis([-MaxSize MaxSize -MaxSize MaxSize]);
grid on;
%%
f = getframe;
[im,map] = rgb2ind(f.cdata,256);
filename = 'bzzz.gif';
imwrite(im,map,filename,'DelayTime',0,'Loopcount',inf);
for i=1:N
    A = step_one(A,M,h);
    x = A(:,1);
    y = A(:,2);
    plot(x,y, 'o');
    grid on;
    axis([-MaxSize MaxSize -MaxSize MaxSize]);
    drawnow;
    pause(0.5);
    f = getframe;
    [im,map] = rgb2ind(f.cdata,256);
    imwrite(im,map,filename,'DelayTime',0,'WriteMode','Append');
end