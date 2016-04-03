using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Tracker.Business.Entities;
using Core.Common.Exceptions;

namespace Tracker.Business.Contracts
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        [FaultContract(typeof(NotFoundException))]
        Person GetPerson(int personId);

        [OperationContract]
        Person[] GetAllPersons();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        Person UpdatePerson(Person person);

        [OperationContract]
        void DeletePerson(int personId);
    }
}
