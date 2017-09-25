%% Fuzzy C-Means Clustering
% This example shows how to perform fuzzy c-means clustering on
% 2-dimensional data.

% Copyright 2005-2013 The MathWorks, Inc.

%% What Is Fuzzy C-Means Clustering? 
% Clustering of numerical data forms the basis of many classification and
% system modeling algorithms. The purpose of clustering is to identify 
% natural groupings of data from a large data set to produce a concise 
% representation of a system's behavior. 

%%
% Fuzzy c-means (FCM) is a data clustering technique in which a dataset is
% grouped into n clusters with every datapoint in the dataset belonging to
% every cluster to a certain degree. For example, a certain datapoint that
% lies close to the center of a cluster will have a high degree of
% belonging or membership to that cluster and another datapoint that lies
% far away from the center of a cluster will have a low degree of belonging
% or membership to that cluster.
%
% The Fuzzy Logic Toolbox(TM) function |fcm| performs FCM clustering. It
% starts with an initial guess for the cluster centers, which are intended
% to mark the mean location of each cluster. The initial guess for these
% cluster centers is most likely incorrect. Next, |fcm| assigns every data
% point a membership grade for each cluster. By iteratively updating the
% cluster centers and the membership grades for each data point, |fcm|
% iteratively  moves the cluster centers to the right location within a
% data set. This  iteration is based on minimizing an objective function
% that represents  the distance from any given data point to a cluster
% center weighted by  that data point's membership grade.

%% Interactive Fuzzy C-Means Clustering Example
% Using the <matlab:fcmdemo fcmdemo> command, you can launch a GUI that
% lets you try out various parameter settings for the fuzzy c-means
% algorithm and observe the effect on the resulting 2-D clustering. You can
% choose a sample data set and an arbitrary number of clusters from the
% drop down menus on the right, and then click "Start" to start the fuzzy
% c-means clustering process. The clustering itself is performed by the |fcm|
% function.
%
% <<../fcmdemo.png>>
%
%%
% *Figure 1:* GUI for Fuzzy C-Means Clustering.

%%
% Once the clustering is done, you can select one of the clusters by 
% clicking on it, and view the membership function surface by clicking the 
% "Plot MF" button. To get a better viewing angle, click and drag inside
% the figure to rotate the MF surface.
%
%%
% You can also tune the 3 optional parameters for the FCM algorithm 
% (exponent, maximum number of iterations and minimum amount of 
% improvement) from the GUI and observe how the clustering process is 
% consequently altered.
%
%% Performing Fuzzy C-Means Clustering on Your Own Data
% The function |fcm| takes a data set and a desired number of clusters and
% returns optimal cluster centers and membership grades for each data
% point. You can use this information to build a fuzzy inference system by
% creating membership functions that represent the fuzzy qualities of each
% cluster.
%
% Here is the underlying code that performs the clustering. 
cd('E:\Dropbox\Masters\myMSc\PracticalPart\Sematic_K-MEANSClustering\FCM\');
pwd;

HM_data_No = load('HM_data_No.dat');  % load some sample data

data = load('HM_data.dat');  % load some sample data
% data = load('fcmdata.dat');  % load some sample data
n_clusters = HM_data_No;              % number of clusters
% data = [1 3 1;2 5 2;6 7 1;1 3 2;2 5 1;6 7 3;1 3 2;2 5 2;6 7 1];
% data = data/10;
% load fisheriris
%  [center,U,obj_fcn] = fcm(data, n_clusters);

cluster_n = n_clusters;
data_n = size(data, 1);


[w expo] = size(data);
max_iter = 100;
 min_eps = 1e-05;
% === initial partition
FcmU = initfcm(cluster_n, data_n);
% === find initial centers
[FcmU, FcmCenter] = stepfcm(data, FcmU, cluster_n, expo);
center_prev = FcmCenter;
U_prev = FcmU;

% === array for objective function 
err = zeros(max_iter, 1);

for i = 1:max_iter,
    [FcmU, FcmCenter, err(i)] = stepfcm( ...
        data, U_prev, cluster_n, expo);
    fprintf('Iteration count = %d, obj. fcn = %f\n', i, err(i));
    
    % === check normal termination condition
    if i > 1,
        if abs(err(i) - err(i-1)) < min_eps, break; end,
    end
    
    center_prev = FcmCenter;
    U_prev = FcmU;
end


maxU = max(FcmU);
mainClusers = zeros(0,0);
csvwrite('HM_data_Out.dat',mainClusers);
for i = 1:cluster_n,
    index = find(FcmU(i, :) == maxU);
    dlmwrite('HM_data_Out.dat',index,'delimiter',',','-append');
    cluster = data(index', :);
end 

% distfcm([0.0040334,0.0065975,0.0051836,0.0053232], [0.008035813,0.007744661,0.001607162,0.007744661])

% save clusters also 
for l = 1:cluster_n,
    B = center_prev(l,:);
    dlmwrite('HM_data_Out_centers.dat',B,'delimiter',',','-append');
end    











