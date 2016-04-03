using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common.Core;
using Core.Common.Contracts;
using Tracker.Business.Contracts;
using Tracker.Business.Entities;
using System.ComponentModel.Composition;
using Tracker.Data.Contracts;
using Core.Common.Exceptions;
using System.ServiceModel;

namespace Tracker.Business.Managers
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, 
        ConcurrencyMode = ConcurrencyMode.Multiple, 
        ReleaseServiceInstanceOnTransactionComplete = false)]
    public class PersonManager : ManagerBase, IPersonService
    {
        public PersonManager()
        {

        }

        public PersonManager(IDataRepositoryFactory dataRepositoryFactory)
        {
            _dataRepositoryFactory = dataRepositoryFactory;
        }

        [Import]
        IDataRepositoryFactory _dataRepositoryFactory;

        public Person GetPerson(int personId)
        {
            return ExecuteFaultHandledOperation(() =>
            {
                IPersonRepository personRepository = _dataRepositoryFactory.GetDataRepository<IPersonRepository>();

                Person personEntity = personRepository.Get(personId);
                if (personEntity == null)
                {
                    NotFoundException ex
                        = new NotFoundException(string.Format("Person with ID of {0} is not available in the database", personId));

                    throw new FaultException<NotFoundException>(ex, ex.Message);
                }

                return personEntity;
            });
        }

        public Person[] GetAllPersons()
        {
            return ExecuteFaultHandledOperation(() =>
            {
                IPersonRepository personRepository = _dataRepositoryFactory.GetDataRepository<IPersonRepository>();

                IEnumerable<Person> persons = personRepository.Get();

                return persons.ToArray();
            });
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public Person UpdatePerson(Person person)
        {
            return ExecuteFaultHandledOperation(() =>
            {
                IPersonRepository personRepository = _dataRepositoryFactory.GetDataRepository<IPersonRepository>();

                Person updateEntity = null;

                if (person.PersonId == 0)
                    updateEntity = personRepository.Add(person);
                else
                    updateEntity = personRepository.Update(person);

                return updateEntity;
            });            
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void DeletePerson(int personId)
        {
            IPersonRepository personRepository = _dataRepositoryFactory.GetDataRepository<IPersonRepository>();

            personRepository.Remove(personId);
        }
    }
}
