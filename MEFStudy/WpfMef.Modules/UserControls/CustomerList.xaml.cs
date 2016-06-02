using System.Linq;
using System.Windows.Controls;

namespace WpfMef.Modules.UserControls
{
    /// <summary>
    /// Interaction logic for CustomerList.xaml
    /// </summary>
    public partial class CustomerList : UserControl
    {
        public CustomerList()
        {
            InitializeComponent();
            List.ItemsSource = Enumerable.Range(1, 100).Select(n => "Customer " + n);
        }
    }
}
