clear('all');
experement = [0.1 0.16 0.24 0.39 0.62 0.93 1.44 2.2 3.3 4.94];
rho = 800;%1500;
vIn = [0.003 0.006 0.009 0.012 0.015 0.018 0.021 0.024 0.027 0.03]; %0.018 0.03
%vR =[0 0.5 1 1.5 2 2.5 3 4 5]; %0.47192;
vR =[0 ];%1 3 4 5]; %0.47192;
cFmin = 0.3;
cFmax = 1.7;
dcF = (cFmax-cFmin)/length(vIn);
%cF = [0.5 1];% 1 
dT = 0.001;
PointsT = dT:dT:50;


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
    cF = cFmin;
    for k = 1:length(vIn)
%         if (vIn(k) > 0.016)
%             cff=2;
%         else
%             cff=1;
%         end
        for i=1:length(PointsT)
            [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
                = CalcFunction_v_2(PointsT(1,i),vIn(k),vR(j),0,cF);
            if (i == length(PointsT))
                a = offset(1,length(PointsT));
                totalOffset(k+inc1,4) = a;
                
                [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
                    = CalcFunction_v_2(PointsT(1,i),vIn(k),vR(j),1,cF);
                
                disp('clear All data insert');
            end
        end
        if (k== length(vIn))
            inc1 = inc1+length(vIn);
            [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
                = CalcFunction_v_2(PointsT(1,i),vIn(k),vR(j),1,cF);
            disp('clear All data outsert');
        end
        cF = cF + dcF;
    end
end

%% plot 
plot(totalOffset(:,2), totalOffset(:,3),...
    totalOffset(:,2), totalOffset(:,4));
legend('exp','calc');

% for cff = 1:length(cF)
%     for j=1:length(vR)
%         offset = zeros(1,length(PointsT));
%         angleOffset = zeros(1,length(PointsT));
%         x = zeros(1,length(PointsT));
%         y = zeros(1,length(PointsT));
%         z = zeros(1,length(PointsT));
%         insL = zeros(1,length(PointsT));
%         qtyCalcPoints = zeros(1,length(PointsT));
%         checkTime = zeros(1,length(PointsT));
%         stopCalc =0 ;
%         
%         for k = 1:length(vIn)
%             for i=1:length(PointsT)
%                 [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
%                     = CalcFunction_v_2(PointsT(1,i),vIn(k),vR(j),0,cF(cff));
%                 if (i == length(PointsT))
%                     a = offset(1,length(PointsT));
%                     totalOffset(k+inc1,3+cff) = a;
%                     
%                     [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
%                         = CalcFunction_v_2(PointsT(1,i),vIn(k),vR(j),1,cF(cff));
%                     
%                     disp('clear All data insert');
%                 end
%             end
% %             if (k== length(vIn))
% %                 inc1 = inc1+length(vIn);
% %                 [offset(1,i),angleOffset(1,i),x(1,i),y(1,i),z(1,i),insL(1,i),qtyCalcPoints(1,i),checkTime(1,i),stopCalc]...
% %                     = CalcFunction_v_2(PointsT(1,i),vIn(k),vR(j),1,cF(cff));
% %                 disp('clear All data outsert');
% %             end
%         end
%     end
% end
% plot(totalOffset(:,2), totalOffset(:,3),...
%     totalOffset(:,2), totalOffset(:,4),...
%     totalOffset(:,2), totalOffset(:,5),...
%     totalOffset(:,2), totalOffset(:,6));
% legend('exp','calc','calc','calc')

