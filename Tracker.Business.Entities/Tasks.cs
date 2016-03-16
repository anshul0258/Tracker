using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Core.Common.Contracts;
using Core.Common.Core;

namespace Tracker.Business.Entities
{
    [DataContract]
    public class Tasks : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int TaskId { get; set; }

        [DataMember]
        public string TaskDescription { get; set; }

        public int EntityId
        {
            get { return TaskId; }
            set { TaskId = value; }
        }
    }
}
