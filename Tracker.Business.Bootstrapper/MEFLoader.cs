using System.ComponentModel.Composition.Hosting;
using Tracker.Data.Data_Repositories;
using Tracker.Business.Business_Engines;

namespace Tracker.Business.Bootstrapper
{
    public static class MEFLoader
    {
        public static CompositionContainer Init()
        {
            AggregateCatalog catalog = new AggregateCatalog();

            //add items to catalog here
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(PersonRepository).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(PersonEngine).Assembly));

            CompositionContainer container = new CompositionContainer(catalog);

            return container;
        }
    }
}
