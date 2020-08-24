using DAN_LV_AndrejaKolesar.ViewModel;
using System.Windows;

namespace DAN_LV_AndrejaKolesar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel(this);
        }
    }
}
