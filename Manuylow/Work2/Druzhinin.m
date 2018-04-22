close all;
clear all;
clc;

N = 200;
M = 200;
h = 1;

mSize = 25;

XY = zeros(M, 2);
x = zeros(M,1);
y = zeros(M,1);

for i=1:M
    r = rand(1);
    theta = 2 * pi * rand(1);
    XY(i,1) = r .* cos(theta);
    XY(i,2) = r .* sin(theta);
end;

x = XY(:,1);
y = XY(:,2);

plot(x,y,'o');
axis([-mSize mSize -mSize mSize]);
grid on;
%%
f = getframe;
[im,map] = rgb2ind(f.cdata,256);
filename = 'bee.gif';
imwrite(im,map,filename,'DelayTime',0,'Loopcount',inf);
for i=1:N   
    
    for k=1:M
    dir = rand(1);
         if dir <= 0.25
             XY(k,1) = XY(k,1) + h;
         elseif dir > 0.25 && dir <= 0.5
             XY(k,1) = XY(k,1) - h;
         elseif dir > 0.5 && dir <= 0.75
             XY(k,2) = XY(k,2) - h;
         elseif dir > 0.75
             XY(k,2) = XY(k,2) + h;
        end;
    end;
    
    x = XY(:,1);
    y = XY(:,2);
    plot(x,y, 'o');
    grid on;
    axis([-mSize mSize -mSize mSize]);
    drawnow;
    pause(0.025);
    f = getframe;
    [im,map] = rgb2ind(f.cdata,256);
    imwrite(im,map,filename,'DelayTime',0,'WriteMode','Append');
end