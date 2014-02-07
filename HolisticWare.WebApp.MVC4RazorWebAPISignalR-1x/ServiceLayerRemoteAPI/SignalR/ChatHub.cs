
/// <summary>
/// Attribute 
///		added to have the same naming convention on clien side (javascript)
///		otherwise names are automatically generated in camel-casing
///		
/// </summary>
[Microsoft.AspNet.SignalR.Hubs.HubName("ChatHub")]
public class ChatHub : Microsoft.AspNet.SignalR.Hub
{
	public void ChatMessageOnServer(string name, string message)
	{
		Clients.All.chatMessageOnClient(name, message);

		return;
	}
}



// Server Error in '/' Application.
// 
// Compilation Error
// 
// Description: An error occurred during the compilation of a resource required to service 
// this request. Please review the following specific error details and modify your source 
// code appropriately. 
// 
// Compiler Error Message: CS0012: 
// The type 'Microsoft.AspNet.SignalR.PersistentConnection' is defined in an assembly that is 
// not referenced. 
// You must add a reference to assembly 'Microsoft.AspNet.SignalR.Core, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null'.
