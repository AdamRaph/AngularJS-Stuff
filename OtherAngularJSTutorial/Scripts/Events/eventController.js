eventModule.controller('eventController', function ($scope) {
    $scope.talks = [
         { id: '1001', name: 'AngularJS 101', speaker: 'Adam Raphael', venue: 'Hall 2', duration: '45m' },
         { id: '1002', name: 'ASP.NET 101', speaker: 'Leigh Hogan', venue: 'Hall 1', duration: '1h30m' },
         { id: '1003', name: 'CRM 101', speaker: 'Leigh Hogan', venue: 'Hall 4', duration: '1h' },
         { id: '1004', name: 'Cloud 101', speaker: 'Adam Raphael', venue: 'Hall 3', duration: '30m' },
         { id: '1005', name: 'RMA 101', speaker: 'Jackson Collins', venue: 'Boardroom', duration: '8h' }
    ];
});