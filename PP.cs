using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
    public class Products
    {
        private int price;
        private string name;

        public Products(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public Products()
        {
        }

        public int Price
        {
            get { return price; }
        }
        public override string ToString()
        {
            return $" Price={price} , Name= {name}";

        }

    }
}
