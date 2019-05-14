clear('all');
rho = 1000;%1500;
vIn = [0.003 0.006 0.009 0.012 0.015 0.018 0.021 0.024 0.027 0.03]; %0.018 0.03
%vR =[0 0.5 1 1.5 2 2.5 3 4 5]; %0.47192;
vR =[3 4 5]; %0.47192;
dT = 0.001;
PointsT = dT:dT:40;


%%
offset = zeros(1,length(PointsT));
angleOffset = zeros(1,length(PointsT));
x = zeros(1,length(PointsT));
y = zeros(1,length(PointsT));
z = zeros(1,length(PointsT));
insL = zeros(1,length(PointsT));
qtyCalcPoints = zeros(1,length(PointsT));
checkTime = zeros(1,length(PointsT));
totalOffset = zeros(3,length(vR)*length(vIn));
inc1 = 0;
for i=1:length(vR)
    for j=1:length(vIn)
        totalOffset(j+inc1,1) = vR(i);
        totalOffset(j+inc1,2) = vIn(j);
        if (j== length(vIn))
            inc1 = inc1+length(vIn);
        end
    end
end
disp('data set end');

%%
stopCalc =0 ;
inc1 = 0;
for j=1:length(vR)
    offset = zeros(1,length(PointsT));
    angleOffset = zeros(1,length(PointsT));
    x = zeros(1,length(PointsT));
    y = zeros(1,length(PointsT));
    z = zeros(1,length(PointsT));
    insL = zeros(1,length(PointsT));  
    qtyCalcPoints = zeros(1,length(PointsT));
    checkTime = zeros(1,length(PointsT));
    stopCalc =0 ;
    
    for k = 1:length(vIn)
        for i=1:length(PointsT)
            [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
            = CalcFunction_v_1(PointsT(1,i),vIn(k),vR(j),0);
            if (i == length(PointsT))
                a = offset(1,length(PointsT));
                totalOffset(k+inc1,3) = a;       
                
                [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
                = CalcFunction_v_1(PointsT(1,i),vIn(k),vR(j),1);
            end
        end
        if (k== length(vIn))
            inc1 = inc1+length(vIn);
        end
    end
end
%%
% vZ    = zeros(1,length(pointsL));
% horiz = zeros(1,length(pointsL));
% for i=1:length(pointsL)   
%     horiz(1,i) = 0;
% end
 %mSizeX = 110;
 %mSizeY = 20;
% plot (1000*pointsL,-yB);%, 1000*pointsL, horiz);
% plot (y,z);%, 1000*pointsL, horiz);
% axis([0 mSizeX -mSizeY mSizeY]);
%grid on;



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