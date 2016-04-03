using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.Business.Common;
using System.ComponentModel.Composition;

namespace Tracker.Business.Business_Engines
{
    [Export(typeof(IPersonEngine))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class PersonEngine : IPersonEngine
    {
    }
}
