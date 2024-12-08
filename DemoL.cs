using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Use of List<Product>  create & display

namespace StringAssignments
{
    public class Product
    {
        //    static void Main(string[] args)
        //    {
        //        List<Product> plist = new List<Product>();
        //        plist.Add(new Product(500, "Mouse"));
        //        plist.Add(new Product(350, "Chocolate"));
        //        plist.Add(new Product(1500, "Keyboard"));
        //        plist.Add(new Product(800, "Pendrive"));
        //        plist.Add(new Product(180, "Vanilla Ice-Cream"));

        //        foreach (Product p in plist)
        //        {
        //            Console.WriteLine(p);
        //        }
        //    }
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public int Price { get; internal set; }
    }
}
