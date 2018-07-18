 eventModule.factory("EventsService", function ($http, $q) {
     return {
         getTalks: function () {
             //Get deferred object
             var deferred = $q.defer();
             //Initiate AJAX call
             $http({ method: 'GET', url: '/Events/GetTalkDetails' }).success(deferred.resolve).error(deferred.reject);
             //Returns promise - Contains result once request completes
             return deferred.promise;
         }
     }
 });