﻿using System.Threading;
using System.Threading.Tasks;

namespace Drone.Interfaces;

public interface IDroneCommand
{
    void Init(Drone drone);
    Task Execute(DroneTask task, CancellationToken cancellationToken);
}