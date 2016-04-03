using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Tracker.Business.Entities;

namespace Tracker.Business.Contracts
{
    [ServiceContract]
    public interface IProjectService
    {
        [OperationContract]
        Project GetProject(int projectId);

        [OperationContract]
        Project[] GetAllProjects();
    }
}
