
var map;
var elevator;
varmyOptions = {
zoom: 6,
mapTypeId: 'terrain'
};
map = new google.maps.Map($('#map')[0], myOptions);
var markers = [];

 // Try HTML5 geolocation
if(navigator.geolocation) {
navigator.geolocation.getCurrentPosition(function(position) {
varpos = new google.maps.LatLng(position.coords.latitude,
position.coords.longitude);

varinfowindow = new google.maps.InfoWindow({
map: map,
position: pos,
content: 'Location found using HTML5.'
      });

map.setCenter(pos);
    }, function() {
handleNoGeolocation(true);
    });
  } else {
    // Browser doesn't support Geolocation
handleNoGeolocation(false);
  }
