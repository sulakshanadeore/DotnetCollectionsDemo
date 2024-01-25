using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCollectionsDemo
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {

            
            //Products p1 = new Products() { ProductId = 1, ProductName = "Keyboard", Price = 1000, MfgDate = new DateTime(2023, 1, 1) };
            
            //Products p2 = new Products() { ProductId = 2, ProductName = "Mobiles", Price = 10000, MfgDate = new DateTime(2023, 11, 1) };
            
            //Products p3 = new Products() { ProductId = 3, ProductName = "Cable", Price = 500, MfgDate = new DateTime(2023, 11, 12) };
            
            //SortedList<int,Products> sortedList = new SortedList<int,Products>();
            //sortedList.Add(4, new Products() { ProductId = 5, ProductName = "TV", Price = 25000, MfgDate = DateTime.Today });
            //sortedList.Add(1, p1);
            //sortedList.Add(2, p2);
            //sortedList.Add(3, p3);
           
            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item.Value.ProductId);
            //    Console.WriteLine(item.Value.ProductName);
            //    Console.WriteLine(item.Value.Price);
            //    Console.WriteLine(item.Value.MfgDate);
            //}
            //Console.WriteLine("--------------------------------------");

            LinkedList<Products> list = new LinkedList<Products>();
            list.AddFirst(new Products() { ProductId = 1, ProductName = "Keyboard", Price = 1000, MfgDate = new DateTime(2023, 1, 1) });
            list.AddLast(new Products() { ProductId = 5, ProductName = "TV", Price = 25000, MfgDate = DateTime.Today });


            LinkedListNode<Products> lastnode = list.Last;
            Products p4=new Products() { ProductId=4,ProductName="4thproduct",Price=100,MfgDate=DateTime.Today};
            list.AddBefore(lastnode,p4);

            foreach (var item in list)
            {
                Console.WriteLine(item.ProductId);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.MfgDate);
            }




            Console.ReadLine();





        }
    }
}
