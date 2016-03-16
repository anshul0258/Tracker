using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common.Data;
using Core.Common.Contracts;

namespace Tracker.Data
{
    public abstract class DataRepositoryBase<T> : DataRepositoryBase<T, TrackerContext>
        where T : class, IIdentifiableEntity, new()
    {

    }
}
