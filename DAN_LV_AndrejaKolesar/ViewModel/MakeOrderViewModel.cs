using DAN_LV_AndrejaKolesar.Model;
using DAN_LV_AndrejaKolesar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LV_AndrejaKolesar.ViewModel
{
    class MakeOrderViewModel:ViewModelBase
    {
        MakeOrder makeOrder;

        public Pizza p = new Pizza();
        private List<Pizza> _pizzaSize;
        public List<Pizza> pizzaSize
        {
            get
            {
                return _pizzaSize;
            }
            set
            {
                _pizzaSize = value;
                OnPropertyChanged("pizzaSize");
            }
        }

        private Pizza _selectedPizza;
        public Pizza selectedPizza
        {
            get
            {
                return _selectedPizza;
            }
            set
            {
                _selectedPizza = value;
                OnPropertyChanged("selectedPizza");
            }
        }
        public MakeOrderViewModel(MakeOrder open)
        {
            makeOrder = open;
            pizzaSize = p.GetAllPizzas();


        }
    }
}
