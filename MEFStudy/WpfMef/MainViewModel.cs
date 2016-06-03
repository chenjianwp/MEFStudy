using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WpfMef.Interfaces;

namespace WpfMef
{
    public class MainViewModel
    {
        [ImportMany]
        public IEnumerable<IModule> Modules { get; set; }

        public MainViewModel()
        {
            //var catalog = new AggregateCatalog(new AssemblyCatalog(Assembly.GetExecutingAssembly(),
            //    new DirectoryCatalog(".")));

            var catalog = new AggregateCatalog(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            var ac = new AssemblyCatalog(Assembly.LoadFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WpfMef.Interfaces.dll")));
            catalog.Catalogs.Add(ac);
            ac = new AssemblyCatalog(Assembly.LoadFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WpfMef.Modules.dll")));
            catalog.Catalogs.Add(ac);

            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

        }
    }
}
