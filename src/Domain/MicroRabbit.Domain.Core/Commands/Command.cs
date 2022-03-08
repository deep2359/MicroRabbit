using MicroRabbit.Domain.Core.Events;
using System;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTimeOffset TimeStamp { get;protected set; }
        protected Command()
        {
            TimeStamp = DateTimeOffset.Now;
        }
    }
}
