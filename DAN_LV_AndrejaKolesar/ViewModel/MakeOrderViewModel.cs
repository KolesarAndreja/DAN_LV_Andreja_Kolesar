using DAN_LV_AndrejaKolesar.Command;
using DAN_LV_AndrejaKolesar.Model;
using DAN_LV_AndrejaKolesar.View;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace DAN_LV_AndrejaKolesar.ViewModel
{
    class MakeOrderViewModel:ViewModelBase
    {
        MakeOrder makeOrder;
        #region property
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

        private List<SideDish> _sides;
        public List<SideDish> sides
        {
            get
            {
                return _sides;
            }
            set
            {
                _sides = value;
                OnPropertyChanged("sides");
            }
        }

        private int? _amount = null;
        public int? amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                OnPropertyChanged("amount");
            }
        }
        #endregion

        #region sides options
        private SideDish _ham = new SideDish("ham",60);
        public SideDish ham
        {
            get
            {
                return _ham;
            }
            set
            {
                _ham = value;
                OnPropertyChanged("ham");
            }
        }

        private SideDish _salami = new SideDish("salami",50);
        public SideDish salami
        {
            get
            {
                return _salami;
            }
            set
            {
                _salami = value;
                OnPropertyChanged("salami");
            }
        }

        private SideDish _kulen = new SideDish("kulen",55);
        public SideDish kulen
        {
            get
            {
                return _kulen;
            }
            set
            {
                _kulen = value;
                OnPropertyChanged("kulen");
            }
        }

        private SideDish _mayonnaise = new SideDish("mayonnaise",20);
        public SideDish mayonnaise
        {
            get
            {
                return _mayonnaise;
            }
            set
            {
                _mayonnaise = value;
                OnPropertyChanged("mayonnaise");
            }
        }

        private SideDish _ketchup = new SideDish("ketchup",15);
        public SideDish ketchup
        {
            get
            {
                return _ketchup;
            }
            set
            {
                _ketchup = value;
                OnPropertyChanged("ketchup");
            }
        }

        private SideDish _pepper = new SideDish("pepper", 15);
        public SideDish pepper
        {
            get
            {
                return _pepper;
            }
            set
            {
                _pepper = value;
                OnPropertyChanged("pepper");
            }
        }

        private SideDish _olives = new SideDish("olives",15);
        public SideDish olives
        {
            get
            {
                return _olives;
            }
            set
            {
                _olives = value;
                OnPropertyChanged("olives");
            }
        }

        private SideDish _oregano = new SideDish("oregano",10);
        public SideDish oregano
        {
            get
            {
                return _oregano;
            }
            set
            {
                _oregano = value;
                OnPropertyChanged("oregano");
            }
        }

        private SideDish _sesame = new SideDish("sesame",10);
        public SideDish sesame
        {
            get
            {
                return _sesame;
            }
            set
            {
                _sesame = value;
                OnPropertyChanged("sesame");
            }
        }

        private SideDish _cheese = new SideDish("cheese",50);
        public SideDish cheese
        {
            get
            {
                return _cheese;
            }
            set
            {
                _cheese = value;
                OnPropertyChanged("cheese");
            }
        }
        #endregion

        #region constructor
        public MakeOrderViewModel(MakeOrder open)
        {
            makeOrder = open;
            pizzaSize = p.GetAllPizzas();
            sides = new List<SideDish>();
        }
        #endregion


        #region calculate
        private ICommand _calculate;
        public ICommand calculate
        {
            get
            {
                if (_calculate == null)
                {
                    _calculate = new RelayCommand(param => CalculateExecute(), param => CanCalculateExecute());
                }
                return _calculate;
            }
        }

        private void CalculateExecute()
        {
            try
            {
                if (ham.isSelected)
                {
                    sides.Add(ham);
                }
                if (salami.isSelected)
                {
                    sides.Add(salami);
                }
                if (kulen.isSelected)
                {
                    sides.Add(kulen);
                }
                if (ketchup.isSelected)
                {
                    sides.Add(ketchup);
                }
                if (mayonnaise.isSelected)
                {
                    sides.Add(mayonnaise);
                }
                if (pepper.isSelected)
                {
                    sides.Add(pepper);
                }
                if (sesame.isSelected)
                {
                    sides.Add(sesame);
                }
                if (oregano.isSelected)
                {
                    sides.Add(oregano);
                }
                if (olives.isSelected)
                {
                    sides.Add(olives);
                }
                if (cheese.isSelected)
                {
                    sides.Add(cheese);
                }

                selectedPizza.SideDishes = sides;
                amount = selectedPizza.CalculateAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanCalculateExecute()
        {
            if (selectedPizza != null)
                return true;
            else
                return false;

        }
        #endregion 
    }
}
