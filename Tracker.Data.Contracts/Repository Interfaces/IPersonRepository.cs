using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Business.Entities;
using Core.Common.Contracts;

namespace Tracker.Data.Contracts
{
    public interface IPersonRepository : IDataRepository<Person>
    {
        Person GetByLogin(string login);
    }
}
