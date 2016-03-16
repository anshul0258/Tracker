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
    public class Project : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int ProjectId { get; set; }

        [DataMember]
        public string ProjectName { get; set; }

        [DataMember]
        public string PseudoName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string ProjectCode { get; set; }

        [DataMember]
        public DateTime StartDate { get; set; }

        [DataMember]
        public DateTime EndDate { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public bool IsBillable { get; set; }


        public int EntityId
        {
            get { return ProjectId; }
            set { ProjectId = value; }
        }
    }
}
