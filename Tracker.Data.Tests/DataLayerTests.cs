using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Common.Core;
using Tracker.Business.Bootstrapper;
using System.ComponentModel.Composition;
using Core.Common.Contracts;
using Moq;
using Tracker.Data.Contracts;

namespace Tracker.Data.Tests
{
    [TestClass]
    public class DataLayerTests
    {
        [TestInitialize]
        public void Initialize()
        {
            ObjectBase.Container = MEFLoader.Init();
        }
    }

    public class RepositoryTestClass
    {
        public RepositoryTestClass()
        {
            ObjectBase.Container.SatisfyImportsOnce(this);
        }

        [Import]
        IDataRepositoryFactory _DataRepositoryFactory;

        
    }
}
