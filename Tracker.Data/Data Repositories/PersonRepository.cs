using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common.Data;
using Tracker.Business.Entities;
using Tracker.Data.Contracts.Repository_Interfaces;

namespace Tracker.Data.Data_Repositories
{
    public class PersonRepository : DataRepositoryBase<Person>, IPersonRepository
    {
        protected override Person AddEntity(TrackerContext entityContext, Person entity)
        {
            return entityContext.PersonSet.Add(entity);
        }

        protected override IEnumerable<Person> GetEntities(TrackerContext entityContext)
        {
            return from e in entityContext.PersonSet
                   select e;
        }

        protected override Person GetEntity(TrackerContext entityContext, int id)
        {
            return (from e in entityContext.PersonSet
                    where e.PersonId == id
                    select e).FirstOrDefault();
        }

        protected override Person UpdateEntity(TrackerContext entityContext, Person entity)
        {
            return (from e in entityContext.PersonSet
                    where e.PersonId == entity.PersonId
                    select e).FirstOrDefault();
        }

        public Person GetByLogin(string login)
        {
            using (TrackerContext entityContext = new TrackerContext())
            {
                return (from e in entityContext.PersonSet
                        where e.Email == login
                        select e).FirstOrDefault();
            }
        }
    }
}
