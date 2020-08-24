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
        public bool isSelected { get; set; }

        public SideDish() { }
        public SideDish(string n, int q)
        {
            Name = n;
            Price = q;
        }
    }
}
