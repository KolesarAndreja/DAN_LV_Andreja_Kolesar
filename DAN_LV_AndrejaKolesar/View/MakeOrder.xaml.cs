using DAN_LV_AndrejaKolesar.ViewModel;
using System.Windows;

namespace DAN_LV_AndrejaKolesar.View
{
    /// <summary>
    /// Interaction logic for MakeOrder.xaml
    /// </summary>
    public partial class MakeOrder : Window
    {
        public MakeOrder()
        {
            InitializeComponent();
            this.DataContext = new MakeOrderViewModel(this);
        }
    }
}
