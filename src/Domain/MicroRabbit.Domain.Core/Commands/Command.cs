using MicroRabbit.Domain.Core.Events;
using System;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTimeOffset TimeOffset { get; protected set; }

        protected Command()
        {
            TimeOffset = DateTimeOffset.Now;
        }
    }
}
