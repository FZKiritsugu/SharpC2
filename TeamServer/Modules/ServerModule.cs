﻿using Microsoft.AspNetCore.SignalR;

using TeamServer.Hubs;
using TeamServer.Interfaces;
using TeamServer.Messages;
using TeamServer.Services;

namespace TeamServer.Modules;

public abstract class ServerModule : IServerModule
{
    public abstract FrameType FrameType { get; }

    protected IDroneService Drones { get; private set; }
    protected ITaskService Tasks { get; private set; }
    protected ICryptoService Crypto { get; private set; }
    protected IReversePortForwardService PortForwards { get; private set; }
    protected IHubContext<NotificationHub, INotificationHub> Hub { get; private set; }
    
    public void Init(ServerService server)
    {
        Drones = server.Drones;
        Tasks = server.Tasks;
        Crypto = server.Crypto;
        PortForwards = server.PortForwards;
        Hub = server.Hub;
    }

    public abstract Task ProcessFrame(C2Frame frame);
}