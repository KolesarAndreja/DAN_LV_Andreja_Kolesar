using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LV_AndrejaKolesar.Model
{
    class SideDish
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public SideDish() { }
        public SideDish(string n, int q)
        {
            Name = n;
            Price = q;
        }

        public List<SideDish> GetAllSideDishes()
        {
            List<SideDish> sides = new List<SideDish>();
            sides.Add(new SideDish("salami", 40));
            sides.Add(new SideDish("ham", 60));
            sides.Add(new SideDish("kulen", 55));
            sides.Add(new SideDish("ketchup", 15));
            sides.Add(new SideDish("mayonnaise", 20));
            sides.Add(new SideDish("pepper", 15));
            sides.Add(new SideDish("olives", 15));
            sides.Add(new SideDish("oregano", 5));
            sides.Add(new SideDish("sesame", 10));
            sides.Add(new SideDish("cheese", 60));
            return sides;
        }
    }
}
