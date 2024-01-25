using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCollectionsDemo
{
    internal class StackGenericDemo
    {
        static Stack<Products> productlist = new Stack<Products>();
        static void Main(string[] args)
        {
           
            //Products p1 = new Products() { ProductId = 1, ProductName = "Keyboard", Price = 1000,MfgDate=new DateTime(2023,1,1) };
            //productlist.Push(p1);
            //Products p2 = new Products() { ProductId = 2, ProductName = "Mobiles", Price = 10000,MfgDate=new DateTime(2023,11,1) };
            //productlist.Push(p2);
            //Products p3 = new Products() { ProductId = 3, ProductName = "Cable", Price = 500,MfgDate = new DateTime(2023, 11, 12) };
            //productlist.Push(p3);

            productlist.Push(new Products { ProductId = 4, ProductName = "Jack for device", Price = 877,MfgDate = new DateTime(2023, 11, 13) });
            Class2 c2 = new Class2();
            c2.CallingMethod();
           string desoutput= c2.Description();
            Console.WriteLine(desoutput);
           string s1 =c2.Display();
            Console.WriteLine(s1);
            Console.ReadLine();
        }




    }
}
