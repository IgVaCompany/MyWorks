clear('all');
experement = [0.1 0.16 0.24 0.39 0.62 0.93 1.44 2.2 3.3 4.94]; %rot speed zero
%experement = [0.17 0.22 0.3 0.36 0.4 0.45 0.47 0.49 0.5 0.53]; %rot speed 3 rad/sec
%experement = [0.15 0.2 0.25 0.31 0.36 0.41 0.42 0.44 0.47 0.49]; %rot speed 4 rad/sec
%experement = [0.26 0.32 0.37 0.41 0.45 0.5 0.53 0.57 0.6 0.65]; %rot speed 5 rad/sec
rho = 1500;%1500;
vIn = [0.003 0.006 0.009 0.012 0.015 0.018 0.021 0.024 0.027 0.03]; %0.018 0.03
%vR =[0 0.5 1 1.5 2 2.5 3 4 5]; %0.47192;
vR =[0]%[0 1 2 3 4 5 6 7 8 9 10];%1 3 4 5]; %0.47192;
dT = 0.001;
PointsT = dT:dT:50;
cF = [2.66584375 1.066685939 0.711157152 0.650224159 0.661623164 0.689512591 0.784529474 0.917967889 1.088266766 1.318833823];%1 1.54]; rot Speed 0
%cF = [97.13340693 15.73135406 6.365846027 3.23079564 1.842929895 1.204554851 0.795031504 0.559047066 0.403247032 0.312718332];%1 1.54]; rot Speed 3
%cF = [114.2592189 19.05791457 7.064884636 3.700963655 2.20407716 1.455901558 0.941747061 0.662773618 0.498425997 0.380221049];%1 1.54]; rot Speed 4
%cF = [247.5463059 38.10638623 13.06272217 6.112620422 3.438567258 2.214430941 1.480803943 1.068636871 0.792121034 0.626483873];%1 1.54]; rot Speed 5
fileName = strcat('_resulte.txt');
fid = fopen(fileName,'w');
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
        totalOffset(j+inc1,3) = experement(j);
        if (j == length(vIn))
            inc1 = inc1+length(vIn);
        end
    end
end
disp('data set end');

%%
stopCalc =0 ;
inc1 = 0;

for j=1:length(vR)
    %for cff = 1:length(cF)
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
                    = CalcFunction_v_3(PointsT(1,i),vIn(k),vR(j),0,cF(k),fid);
                if (i == length(PointsT))
                    %a = cF(cff)*offset(1,length(PointsT));
                    a = offset(1,length(PointsT));
                    totalOffset(k+inc1,3+1) = a;
                    
                    [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
                        = CalcFunction_v_3(PointsT(1,i),vIn(k),vR(j),1,cF(k),fid);
                    
                    disp('clear All data insert');
                end
            end
            if (k == length(vIn))
                inc1 = inc1+length(vIn);
                [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
                    = CalcFunction_v_3(PointsT(1,i),vIn(k),vR(j),1,cF(k),fid);
                disp('clear All data outsert');
            end
        end
    %end
end
fid = fclose(fid);

%% plot
 plot(totalOffset(1:10,2), totalOffset(1:10,3),'*',...  % 0
      totalOffset(1:10,2), totalOffset(1:10,4),'o'...  % 1
       );
 legend('exp','calc')

%% plot 
% plot(totalOffset(1:10,2), totalOffset(1:10,3),...  % 0
%      totalOffset(1:10,2), totalOffset(1:10,4),...  % 1
%      totalOffset(1:10,2),totalOffset(11:20,4),...  % 2
%      totalOffset(1:10,2), totalOffset(21:30,4),... % 3
%      totalOffset(1:10,2), totalOffset(31:40,4),... % 4 
%      totalOffset(1:10,2), totalOffset(41:50,4),...   5
%      totalOffset(1:10,2), totalOffset(51:60,4),...   6 
%      totalOffset(1:10,2), totalOffset(61:70,4),...   7
%      totalOffset(1:10,2), totalOffset(71:80,4),...   8
%      totalOffset(1:10,2), totalOffset(91:100,4),...  9
%      totalOffset(1:10,2), totalOffset(101:110,4)... 10
%       );
% legend('exp','calc')

