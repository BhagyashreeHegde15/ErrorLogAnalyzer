/// <reference path="../Scripts/underscore.min.js" />
/// <reference path="../Scripts/jquery-1.7.1.min.js" />
/// <reference path="../Scripts/ui-bootstrap-tpls-0.10.0.min.js" />
var errorViewModule = angular.module('ErrorView', ['ui.bootstrap']);

//errorViewModule.config([
//    '$routeProvider',
//    function ($routeProvider) {
//        $routeProvider.when('/ErrorViews', {
//            controller: 'ErrorViewController',
//            templateUrl: 'Index.html'
//        }).otherwise({ redirectTo: '/ErrorViews' });
//    }]);

errorViewModule.controller('ErrorViewController', ['$scope', 'ErrorViewService', function ($scope, errorViewService) {
    $scope.ViewErrorDetail = errorViewService;
    $scope.ViewErrorDetail.LoadErrorDetails();
    //$scope.exportData = function () {
   // alasql('SELECT * INTO XLSX("C:\\ErrorLogViewer\\Report.xlsx",{headers:true}) FROM ?', [$scope.ViewErrorDetail.LogDetails]);
    //};
}]);

errorViewModule.factory('ErrorViewFactory', ['$http', function ($http) {
    return {
        GetErrorLogDetails: function() {
            return $http({
                method: 'GET',
                url: '/api/Log'
            });
        },

        SetErrorLogStatus: function(errorStatus) {
            return $http({
                method: 'POST',
                url: '/api/Log',
                data: errorStatus,
            });
        }
    };
}]);

errorViewModule.service('ErrorViewService', ['ErrorViewFactory', function(errorViewFactory) {
    this.LoadErrorDetails = function() {
        var self = this;
        //    alasql('SELECT * FROM XLSX("Report.xlsx",{headers:true,sheetid:"Sheet1",range:"A1:F8"})',
        //[], function (data) {
        //    console.log(data);
        //});
        self.PendingErrors = [];
        self.InProgressErrors = [];
        self.FixedErrors = [];
        errorViewFactory.GetErrorLogDetails().success(function(data) {
            self.LogDetails = angular.fromJson(data);
            _.each(self.LogDetails, function (eachError) {
                eachError.ErrorStatus.AssignedTo = eachError.ErrorStatus.AssignedTo || "Not Assigned";
                if (eachError.ErrorStatus.Status == "In Progress") {
                    self.InProgressErrors.push(eachError);
                }
                else if(eachError.ErrorStatus.Status == "Fixed") {
                    self.FixedErrors.push(eachError);
                }
                else {
                    eachError.ErrorStatus.Status = "Pending";
                    self.PendingErrors.push(eachError);
                }
            });
           
            
        });
    };
    this.SetShowDetails = function(error) {
        error.ShaowDetails = !error.ShaowDetails;
        error.SetShowUsers = false;
        error.SetShowTime = false;
        error.showEdit = false;
        error.ShowEditAssigned = false;
    };
    this.SetShowUsers = function(error) {
        error.SetShowUsers = !error.SetShowUsers;
        error.ShaowDetails = false;
        error.SetShowTime = false;
        error.showEdit = false;
        error.ShowEditAssigned = false;
    };
    this.SetShowTime = function(error) {
        error.SetShowTime = !error.SetShowTime;
        error.SetShowUsers = false;
        error.ShaowDetails = false;
        error.showEdit = false;
        error.ShowEditAssigned = false;
    };
    this.SetShowAsigned = function (error) {
        error.ShowEditAssigned = !error.ShowEditAssigned;
        error.SetShowTime = false;
        error.SetShowUsers = false;
        error.ShaowDetails = false;
        error.showEdit = false;
    };
    
    this.SaveErrorAssignedTo = function (error) {
        errorViewFactory.SetErrorLogStatus(error);
        error.ShowEditAssigned = false;
    };
    this.SaveErrorStatus = function (error, status, index) {
        var self = this;
        if (error.ErrorStatus.Status == "In Progress") {
            self.InProgressErrors.splice(index, 1);
        }
        else if (error.ErrorStatus.Status == "Fixed") {
            self.FixedErrors.splice(index, 1);
        }
        else {
            self.PendingErrors.splice(index, 1);
        }
        error.ErrorStatus.Status = status;
        errorViewFactory.SetErrorLogStatus(error);
        if (error.ErrorStatus.Status == "In Progress") {
            self.InProgressErrors.push(error);
        }
        else if (error.ErrorStatus.Status == "Fixed") {
            self.FixedErrors.push(error);
        }
        else {
            self.PendingErrors.push(error);
        }
    };
    this.SaveCommentAndExtractToXML = function() {
        var self = this;
        var ExtractData = [];
        _.each(self.LogDetails, function(error) {
            var eachError = {
                Error: error.ElmahErrors[0].DetailErrorXml.detail,
                Count: error.Errorcount,
                Assigned_T0: error.ErrorStatus.AssignedTo,
                Status: error.ErrorStatus.Status
            };
            ExtractData.push(eachError);
        });
        alasql('SELECT * INTO XLSX("Report.xlsx",{headers:true}) FROM ?', [ExtractData]);
        self.ShowEdit = false;
    };
}]);


