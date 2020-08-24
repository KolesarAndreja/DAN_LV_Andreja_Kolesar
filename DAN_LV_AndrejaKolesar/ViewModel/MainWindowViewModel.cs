using DAN_LV_AndrejaKolesar.Command;
using DAN_LV_AndrejaKolesar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DAN_LV_AndrejaKolesar.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        MainWindow main;
        public MainWindowViewModel(MainWindow open)
        {
            main = open;
        }

        #region start
        private ICommand _start;
        public ICommand start
        {
            get
            {
                if (_start == null)
                {
                    _start = new RelayCommand(param => StartExecute(), param => CanStartExecute());
                }
                return _start;
            }
        }

        private void StartExecute()
        {
            try
            {
                MakeOrder create = new MakeOrder();
                main.Close();
                create.ShowDialog();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanStartExecute()
        {
            return true;
        }
        #endregion 
    }
}
