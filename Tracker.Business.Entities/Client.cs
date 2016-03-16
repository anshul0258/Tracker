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
    public class Client : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int ClientID { get; set; }

        [DataMember]
        public string Name { get; set; }


        public int EntityId
        {
            get { return ClientID; }
            set { ClientID = value; }
        }

    }
}
