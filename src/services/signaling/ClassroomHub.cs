using Microsoft.AspNetCore.SignalR;

namespace WSE.Services.Signaling;

public class ClassroomHub : Hub
{
    public async Task SendDrawCommand(int x, int y, string color)
    {
        // Broadcast drawing coordinates to everyone in the class
        await Clients.Others.SendAsync("ReceiveDraw", x, y, color);
    }

    public async Task JoinClass(string classId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, classId);
    }
}
