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
    public class Person : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int PersonId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string EmployeeId { get; set; }

        [DataMember]
        public string ProjectId { get; set; }

        [DataMember]
        public int ManagerId { get; set; }

        public int EntityId
        {
            get { return PersonId; }
            set { PersonId = value; }
        }
    }
}
