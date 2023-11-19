using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using OnlineJobPortal.Application.Futures.ApplicationUser.Queries;
using System;
using System.Threading.Tasks;

namespace OnlineJobPortal.Presentation.SignalR
{
    [Authorize]
    public class ITJobsHub : Hub
    {
        private static List<UserConnection> ConnectedUsers = new List<UserConnection>();
        private readonly IMediator mediator;

        public ITJobsHub(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public override async Task OnConnectedAsync()
        {
            var userId = Context.UserIdentifier;
            var connectionId = Context.ConnectionId;

            if (ConnectedUsers.All(x => x.UserId != userId))
            {
                ConnectedUsers.Add(new UserConnection { UserId = userId!, ConnectionId = connectionId });
            }

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var userId = Context.UserIdentifier;
            var connectionId = Context.ConnectionId;

            var userConnection = ConnectedUsers.SingleOrDefault(x => x.UserId == userId && x.ConnectionId == connectionId);
            if (userConnection != null)
            {
                ConnectedUsers.Remove(userConnection);
            }

            await base.OnDisconnectedAsync(exception);
        }
        public async Task SendMessageToUser(string toUserId, string message)
        {
            var fromUserId = Context.UserIdentifier;
            var result = mediator.Send(new GetAvatarUserQuery(fromUserId!));
            var toUser = ConnectedUsers.SingleOrDefault(x => x.UserId == toUserId);

            if (toUser != null)
            {
                await Clients.Client(toUser.ConnectionId).SendAsync("ReceiveMessage", result, message);
            }
        }

        public async Task SendToGroup(string resourceName, string resourceId, string message)
        {
            await Clients.Groups($"{resourceName}-{resourceId}").SendAsync("ReceiveMessage", message);
        }

        public async Task JoinGroup(string resourceName, string resourceId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"{resourceName}-{resourceId}");
        }

        public async Task LeaveGroup(string resourceName, string resourceId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"{resourceName}-{resourceId}");
        }

        public async Task SendToAll(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }



    }
}
