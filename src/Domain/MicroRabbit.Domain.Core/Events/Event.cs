using System;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTimeOffset TimeOffset { get; protected set; }

        protected Event()
        {
            TimeOffset = DateTimeOffset.Now;
        }
    }
}
