using System.Windows;

namespace DatPhungWPF
{
    public partial class CustomerProfile : Window
    {
        public CustomerProfile()
        {
            InitializeComponent();
            DataContext = new ViewModels.CustomerProfileViewModel();
        }
    }
}
