﻿using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void publish<T>(T @Event) where T : Event;

        void subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;


    }
}
