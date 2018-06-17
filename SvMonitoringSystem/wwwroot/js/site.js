// Write your JavaScript code.
var gMap = null,
    initCoordLat, initCoordLon = null;

initCoordLat = 60;
initCoordLon = 30;

var poly;
var markers = [];

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

function addMarker(location) {
    var marker = new google.maps.Marker({
        position: location,
        map: gMap
    });
    markers.push(marker);
}

// Sets the map on all markers in the array.
function setMapOnAll(map) {
    for (var i = 0; i < markers.length; i++) {
        markers[i].setMap(gMap);
    }
}

// Removes the markers from the map, but keeps them in the array.
function clearMarkers() {
    setMapOnAll(null);
}

// Shows any markers currently in the array.
function showMarkers() {
    setMapOnAll(map);
}

// Deletes all markers in the array by removing references to them.
function deleteMarkers() {
    clearMarkers();
    markers = [];
}

//function setCoordinatePoint(lat, lng) {
//    var myLatLng = { lat, lng };
//    var marker = new google.maps.Marker({
//        position: myLatLng,
//        map: gMap,
//        title: 'XXX',
//        icon: "images/marker.png"
//    });
//}

$(document).ready(function () {
    $('#carparkRegistrationVehicle').on('click', function () {
        window.open('/Vehicles/Index', '_blank', 'left=100,top=100,width=1200,height=800,toolbar=1,resizable=0');
    });
});

function showVehicleOnMap(lat, lng) {
    var contentString = 'KAMAZ 5490<br/>' +
        '<table border = "1">' +

        '<tr>' +
        '<td> Скорость (км/ч) </td><td> 65,3 </td>' +
        '</tr>' +

        '<tr>' +
        '<td> Обороты двигателя (об/мин) </td><td> 2750 </td>' +
        '</tr>' +

        '<tr>' +
        '<td> Объем дизтоплива в баке (л) </td><td> 72,6 </td>' +
        '</tr>' +

        '<tr>' +
        '<td> Объем газа в баллоне (л) </td><td> 27,9 </td>' +
        '</tr>' +

        '</table>';
    var infowindow = new google.maps.InfoWindow({
        content: contentString
    });

    
    //google.maps.visualRefresh = true;
    //gMap.visualRefresh = true;
    //clearMarkers();
    var myLatLng = { lat, lng };
    var marker = new google.maps.Marker({
        position: myLatLng,
        map: gMap,
        title: '',
        icon: "/images/marker.png"
    }); 
    marker.addListener('click', function () {
        infowindow.open(gMap, marker);
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
    $('#advancedDiagnosticParameter').on('click', function () {
        window.open('/Server/AdvancedDiagnosticParameter', '_blank', 'left=100,top=100,width=1200,height=800,toolbar=1,resizable=0');
    });
});

$(document).ready(function () {
    $('#psychoConditionDriver').on('click', function () {
        window.open('/Server/PsychoConditionDriver', '_blank', 'left=100,top=100,width=1200,height=800,toolbar=1,resizable=0');
    });
});


//$('body').layout({
//    applyDefaultStyles: true
//});
//$('#inner').layout({
//    applyDefaultStyles: true
//});

//'use strict';

//window.chartColors = {
//    red: 'rgb(255, 99, 132)',
//    orange: 'rgb(255, 159, 64)',
//    yellow: 'rgb(255, 205, 86)',
//    green: 'rgb(75, 192, 192)',
//    blue: 'rgb(54, 162, 235)',
//    purple: 'rgb(153, 102, 255)',
//    grey: 'rgb(201, 203, 207)'
//};

//(function (global) {
//    var Months = [
//        'January',
//        'February',
//        'March',
//        'April',
//        'May',
//        'June',
//        'July',
//        'August',
//        'September',
//        'October',
//        'November',
//        'December'
//    ];

//    var COLORS = [
//        '#4dc9f6',
//        '#f67019',
//        '#f53794',
//        '#537bc4',
//        '#acc236',
//        '#166a8f',
//        '#00a950',
//        '#58595b',
//        '#8549ba'
//    ];

//    var Samples = global.Samples || (global.Samples = {});
//    var Color = global.Color;

//    Samples.utils = {
//        // Adapted from http://indiegamr.com/generate-repeatable-random-numbers-in-js/
//        srand: function (seed) {
//            this._seed = seed;
//        },

//        rand: function (min, max) {
//            var seed = this._seed;
//            min = min === undefined ? 0 : min;
//            max = max === undefined ? 1 : max;
//            this._seed = (seed * 9301 + 49297) % 233280;
//            return min + (this._seed / 233280) * (max - min);
//        },

//        numbers: function (config) {
//            var cfg = config || {};
//            var min = cfg.min || 0;
//            var max = cfg.max || 1;
//            var from = cfg.from || [];
//            var count = cfg.count || 8;
//            var decimals = cfg.decimals || 8;
//            var continuity = cfg.continuity || 1;
//            var dfactor = Math.pow(10, decimals) || 0;
//            var data = [];
//            var i, value;

//            for (i = 0; i < count; ++i) {
//                value = (from[i] || 0) + this.rand(min, max);
//                if (this.rand() <= continuity) {
//                    data.push(Math.round(dfactor * value) / dfactor);
//                } else {
//                    data.push(null);
//                }
//            }

//            return data;
//        },

//        labels: function (config) {
//            var cfg = config || {};
//            var min = cfg.min || 0;
//            var max = cfg.max || 100;
//            var count = cfg.count || 8;
//            var step = (max - min) / count;
//            var decimals = cfg.decimals || 8;
//            var dfactor = Math.pow(10, decimals) || 0;
//            var prefix = cfg.prefix || '';
//            var values = [];
//            var i;

//            for (i = min; i < max; i += step) {
//                values.push(prefix + Math.round(dfactor * i) / dfactor);
//            }

//            return values;
//        },

//        months: function (config) {
//            var cfg = config || {};
//            var count = cfg.count || 12;
//            var section = cfg.section;
//            var values = [];
//            var i, value;

//            for (i = 0; i < count; ++i) {
//                value = Months[Math.ceil(i) % 12];
//                values.push(value.substring(0, section));
//            }

//            return values;
//        },

//        color: function (index) {
//            return COLORS[index % COLORS.length];
//        },

//        transparentize: function (color, opacity) {
//            var alpha = opacity === undefined ? 0.5 : 1 - opacity;
//            return Color(color).alpha(alpha).rgbString();
//        }
//    };

//    // DEPRECATED
//    window.randomScalingFactor = function () {
//        return Math.round(Samples.utils.rand(-100, 100));
//    };

//    // INITIALIZATION

//    Samples.utils.srand(Date.now());

//    // Google Analytics
//    /* eslint-disable */
//    if (document.location.hostname.match(/^(www\.)?chartjs\.org$/)) {
//        (function (i, s, o, g, r, a, m) {
//        i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
//            (i[r].q = i[r].q || []).push(arguments)
//        }, i[r].l = 1 * new Date(); a = s.createElement(o),
//            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
//        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');
//        ga('create', 'UA-28909194-3', 'auto');
//        ga('send', 'pageview');
//    }
//    /* eslint-enable */

//}(this));