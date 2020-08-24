using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LV_AndrejaKolesar.Model
{
    class Pizza
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public List<SideDish> SideDishes;

        #region constructor
        public Pizza() { }
        public Pizza(string t, int price)
        {
            Type = t;
            Price = price;
        }
        public Pizza(string t, int price, List<SideDish> side)
        {
            Type = t;
            Price = price;
            SideDishes = side;
        }
        #endregion

        public int CalculateAmount()
        {
            int n = Price;
            for(int i=0; i<SideDishes.Count; i++)
            {
                n += SideDishes[i].Price;
            }
            return n;
        }

        public List<Pizza> GetAllPizzas()
        {
            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(new Pizza("small", 300));
            pizzas.Add(new Pizza("medium", 500));
            pizzas.Add(new Pizza("large", 700));
            return pizzas;
        }


    }
}
