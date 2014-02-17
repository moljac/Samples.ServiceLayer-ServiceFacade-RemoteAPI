$(
	function () 
	{
		$("#my_map").gmap3
				(
					{
						map:
						{
							options:
							{
								center: [45.761775, 15.991158]
								, zoom: 15
								, mapTypeId: google.maps.MapTypeId.MAP
								, mapTypeControl: true
								, mapTypeControlOptions:
									{
										style: google.maps.MapTypeControlStyle.DROPDOWN_MENU
									}
								, navigationControl: true
								, scrollwheel: true
								, streetViewControl: true
							}
						}
					}
				);
		$("#my_map").gmap3({ marker: { latLng: [45.761775, 15.991158]} });
	}
);







$('#generate').click
	(
		function () 
		{
			var latitude_delta = (Math.random() - Math.random()) * 5 / 1000;
			var longitude_delta = (Math.random() - Math.random()) * 5 / 1000;

			var latitude = 45.7621 + latitude_delta;
			var longitude = 15.9931 + longitude_delta;

			$('#latitude').val(latitude);
			$('#longitude').val(longitude);
		}
	);

$(
	function ()
	{
		var TrackerHubProxy = $.connection.TrackerHub;
		console.log('HolisticWare SignalR Hub =' + TrackerHubProxy.toString());

		TrackerHubProxy.client.positionOnClient =
			function (username, latitude, longitude)
			{
				console.log(username + ' ' + latitude + ' ' + longitude);
				$("ul#positions").prepend
									(
										"<li>"
											+ username + ": "
											+ "latitude:" + latitude
											+ "longitude: " + longitude
											+
										"</li>"
									);
				$('#my_map').gmap3
							(
								{
									clear:
										{
											name: ["marker"]
										}
								}
							);
				$("#my_map").gmap3
							(
								{
									marker:
										{
											latLng: [latitude, longitude]
										, data: "Text"
										}
								}
							);
			};
		console.log('HolisticWare SignalR Hub client message added');
		$.connection.hub.start()
			.done
				(
					function ()
					{
						console.log('HolisticWare SignalR Hub start.done');
						// Wire up Send button to call chatMessage on the server.
						$('#send').click
						(
							function ()
							{
								var username = $('#username').val();
								var latitude = $('#latitude').val();
								var longitude = $('#longitude').val();

								console.log('HolisticWare send click');
								TrackerHubProxy.server.positionOnServer
														(
														  username
														, latitude
														, longitude
														);
								$('#latitude').focus();
							}
						)
					}
				)
			.fail
				(
					function (reason)
					{
						alert("HolisticWare SignalR: Could not Connect!" + reason);
					}
				);
	}
);

