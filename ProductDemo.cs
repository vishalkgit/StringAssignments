using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
    public class ProductDemo:IComparer<Products>
    {
        private int pid;
        private string pname;
        private int pprice;

        public ProductDemo(int pid,string pname,int pprice)
        {
            this.pid = pid;
            this.pname = pname;
            this.pprice = pprice; 
        }

        public ProductDemo()
        {
        }

        public int Pprice
        {
            get { return pprice; } 
        }


        //public int CompareTo(object obj)
        //{
        //    ProductDemo p1=(ProductDemo)obj;
        //    if(this.pprice>p1.pprice)
        //    {
        //        return 1;
        //    }
        //    else if(this.pprice<p1.pprice)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        public override string ToString()
        {
            return$"Product id is{pid},ProductName is {pname},Pprice: {pprice}";
        }

        public int Compare(Products p1, Products p2)
        {
            
            if (p1.Price > p2.Price)
            {
                return 1;
            }
            else if (p1.Price < p2.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
        //static void Main(string[] args)
        //{
        //    Products p1= new Products(700,"Springs");
        //    Products p2 = new Products(800,"Nuts");

        //    List<Products> list = new List<Products>();
        //    list.Add(new Products(500, "Mouse"));
        //    list.Add(new Products(350, "Chocolate"));
        //    list.Add(new Products(1500, "Keyboard"));
        //    list.Add(new Products(800, "Pendrive"));
        //    list.Add(new Products(180, "Vanilla Ice-Cream"));


        //    ProductDemo c = new ProductDemo();
        //    int result = c.Compare(p1,p2);
        //    if (result == 1)
        //    {
        //        Console.WriteLine("p1 is greater than p2");
        //    }
        //    else if (result == -1)
        //    {
        //        Console.WriteLine("p2 is greater than p1");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Both are equal");
        //    }

        //}

        
    }
}
