$(
	function ()
	{
		var ChatHubProxy = $.connection.ChatHub;
		console.log('HolisticWare SignalR Hub =' + ChatHubProxy.toString());


		ChatHubProxy.client.chatMessageOnClient =
			function (username, message)
			{
				console.log(username + ' ' + message);
				$("ul#messages").prepend("<li>" + username + ":" + message + "</li>");
			};

		console.log('HolisticWare SignalR Hub client message added');
		
		// client side logging (with proxy)
		$.connection.hub.logging = true;
		// client side logging (w/o proxy)
		$.connection.logging = true;

		//=====================================================================
		// error handling
		// Add an error handler (with the generated proxy)
		$.connection.hub.error
					(
						function (error) 
						{
							console.log('SignalR error: ' + error)
						}
					);
		//---------------------------------------------------------------------
		// Add an error handler (without the generated proxy)
		//var connection = $.hubConnection();
		//connection.error
		//			(
		//				function (error) 
		//				{
		//					console.log('SignalR error: ' + error)
		//				}
		//			);
		//=====================================================================
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
								var message = $('#message').val();

								console.log('HolisticWare send click');
								ChatHubProxy.server
									// without proxy!!
									//.chatMessageOnServer.invoke
									//		(
									//		  'chatMessageOnServer'
									//		, userName
									//		, message
									//		)
									// proxy generated
									.chatMessageOnServer
											(
											  username
											, message
											)
										.fail
											(
												function (error) 
												{
													console.log('call to chatMessageOnServer error: ' + error)
												}
											);
								$('#message').val('').focus();
							}
						)
					}
				)
			.fail
				(
					function (error)
					{
						alert("HolisticWare SignalR start error: " + reason);
					}
				);
	}
);
