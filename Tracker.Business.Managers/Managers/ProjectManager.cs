using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common.Contracts;
using Core.Common.Core;
using Tracker.Business.Contracts;
using Tracker.Business.Entities;

namespace Tracker.Business.Managers
{
    public class ProjectManager : IProjectService
    {
        public ProjectManager()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

        public ProjectManager(IDataRepositoryFactory dataRepositoryFactory)
        {
            _DataRepositoryFactory = dataRepositoryFactory;
        }

        [Import]
        IDataRepositoryFactory _DataRepositoryFactory;

        public Project GetProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public Project[] GetAllProjects()
        {
            throw new NotImplementedException();
        }
    }
}
