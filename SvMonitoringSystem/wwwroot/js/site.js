// Write your JavaScript code.
var gMap = null,
    initCoordLat, initCoordLon = null;

initCoordLat = 60;
initCoordLon = 30;

var poly;

var gmapDiv = document.getElementById('googleMap');
function initMap(mapLang) {
    google.maps.visualRefresh = true;
    if (!gmapDiv) return;
    gMap = new google.maps.Map(gmapDiv, {
        zoom: 10,
        center: new google.maps.LatLng(initCoordLat, initCoordLon),
        mapTypeId: google.maps.MapTypeId.ROADMAP
        //mapTypeId: t,
        //mapTypeControlOptions: { mapTypeIds: types, style: google.maps.MapTypeControlStyle.DROPDOWN_MENU },
    });

}

function setCoordinatePoint(lat, lng) {
    var myLatLng = { lat, lng };
    var marker = new google.maps.Marker({
        position: myLatLng,
        map: gMap,
        title: 'XXX'
    });
}

function buildRoute(routeCoordinates) {
    var flightPath = new google.maps.Polyline({
        path: routeCoordinates,
        geodesic: true,
        strokeColor: '#FF0000',
        strokeOpacity: 1.0,
        strokeWeight: 2
    });

    flightPath.setMap(gMap);
}

$(document).ready(function () {
    $('#carparkRegistrationVehicle').on('click', function () {
        window.open('/Vehicles/Index', '_blank', 'left=100,top=100,width=1200,height=800,toolbar=1,resizable=0');
    });
});

function showVehicleOnMap(lat, lng) {
    var myLatLng = { lat, lng };
    var marker = new google.maps.Marker({
        position: myLatLng,
        map: gMap,
        title: 'XXX'
    });
}
