clear('all');
rho = 1000;%1500;
vIn = 0.018; %0.018 0.03
vR = 0; %0.47192;
dT = 0.0001;
PointsT = dT:dT:10;


%%
% yB = zeros(1,length(pointsL));
% yBintegr = zeros(1,length(pointsL));
% tetaBr = zeros(1,length(pointsL));
% tetaBg = zeros(1,length(pointsL));
% iIx = zeros(1,length(pointsL));
offset = zeros(1,length(PointsT));
angleOffset = zeros(1,length(PointsT));
x = zeros(1,length(PointsT));
y = zeros(1,length(PointsT));
z = zeros(1,length(PointsT));
insL = zeros(1,length(PointsT));  
qtyCalcPoints = zeros(1,length(PointsT));
checkTime = zeros(1,length(PointsT));

stopCalc =0 ;

for i=1:length(PointsT)
    [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
        = CalcFunction_v_2(PointsT(1,i),vIn,vR,0);
end

%%
% vZ    = zeros(1,length(pointsL));
% horiz = zeros(1,length(pointsL));
% for i=1:length(pointsL)   
%     horiz(1,i) = 0;
% end
 mSizeX = 110;
 mSizeY = 20;
% plot (1000*pointsL,-yB);%, 1000*pointsL, horiz);
 plot3 (x,y,z);%, 1000*pointsL, horiz);
  xlabel('X')
  ylabel('Y')
  zlabel('Z')
 axis([0 0.1 -0.1 0.1 -0.1 0.1])
% axis([0 mSizeX -mSizeY mSizeY]);
grid on;



%%
% get the animation

%%
% f = getframe;
% [im,map] = rgb2ind(f.cdata,256);
% filename = 'Needle.gif';
% imwrite(im,map,filename,'DelayTime',0,'Loopcount',inf);
% for i=1:length(pointsL)   
%     plot (1000*pointsL(1,i),-yB(1,i));
%     grid on;
%     axis([0 mSizeX -mSizeY mSizeY]);
%     drawnow;
%     pause(dT);
%     f = getframe;
%     [im,map] = rgb2ind(f.cdata,256);
%     imwrite(im,map,filename,'DelayTime',0,'WriteMode','Append');
% end

%%
% for i=1:length(pointsL)
%     vZ(1,i) = (envFp(1,i)*( (((pointsL(1,i))^3)/6) - ( ((pointsL(1,i))^2)*((pointsL(1,i))/2) + (((pointsL(1,i))^3)/3) ) ))/(E*iIx(1,i));
%     horiz(1,i) = 0;
% end
%plot (pointsL,vZ, pointsL, horiz);