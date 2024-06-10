using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DDDModeloApi.Domain.Core.Messages
{
    public abstract class Message
    {
        [IgnoreDataMember]
        public string MessageType { get; protected set; }
        [IgnoreDataMember]
        public Guid? AggregateId { get; set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
