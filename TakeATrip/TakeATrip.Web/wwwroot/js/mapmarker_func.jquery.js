		//set up markers 
		var myMarkers = {"markers": [
            { "latitude": "10.789362", "longitude":"106.700041", "icon": "../img/map-marker.png"}
			]
		};
		
		//set up map options
		$(".map_contact").mapmarker({
			zoom	: 14,
            center: 'New World Saigon Hotel',
			markers	: myMarkers
		});

