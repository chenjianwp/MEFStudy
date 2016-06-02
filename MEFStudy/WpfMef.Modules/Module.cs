using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfMef.Interfaces;
using WpfMef.Modules.UserControls;

namespace WpfMef.Modules
{
    [Export(typeof(IModule))]
    public class Customer : IModule
    {
        public string Title => "Customers";

        public UIElement Content
        {
            get { return new CustomerList(); }
        }
    }

    [Export(typeof(IModule))]
    public class Product : IModule
    {
        public string Title => "Products";

        public UIElement Content
        {
            get { return new ProductList(); }
        }
    }

    [Export(typeof(IModule))]
    public class Supplier : IModule
    {
        public string Title => "Suppliers";

        public UIElement Content
        {
            get { return new SupplierList(); }
        }
    }
}
