using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingLibrary;
namespace DotnetCollectionsDemo
{
    internal class GenericCollectionsDemo
    {
        static List<Products> productlist = new List<Products>() {
        new Products{ ProductId=5,ProductName="Charger",Price=1000},
        new Products{ProductId=6,ProductName="Laptop",Price=50000 }
              
        };
        static void Main(string[] args)
        {
          //  CreateInitialListof3Products();
            char ans = 'Y';
            do
            {
                //Products pnew = new Products();
                //pnew.ProductId = 5;







                Products p1 = new Products() {ProductId=1,ProductName="Keyboard",Price=1000 };
                productlist.Add(p1);
                Products p2 = new Products() { ProductId = 2, ProductName = "Mobiles", Price = 10000 };
                productlist.Add(p2);
                Products p3 = new Products() { ProductId = 3, ProductName = "Cable", Price = 500 };
                productlist.Add(p3);
               
                productlist.Add(new Products {ProductId=4,ProductName="Jack for device",Price=877 });




                Console.WriteLine("Menu");
                Console.WriteLine("1.Add Product \n2.Edit Product \n3.Delete PRoduct \n4.Find/Show Product \n6.List of Products \n7.Exit");
                int userchoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("U selected " + userchoice);
                switch (userchoice)
                {
                    case 1:
                        Products newproduct = new Products();
                        Console.WriteLine("Enter PRoductID");
                        newproduct.ProductId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter ProductName");
                        newproduct.ProductName = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        newproduct.Price = Convert.ToSingle(Console.ReadLine());
                        productlist.Add(newproduct);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        foreach (var item in productlist)
                        {
                            Console.WriteLine(item.ProductId);
                            Console.WriteLine(item.ProductName);
                            Console.WriteLine(item.Price);
                        }
                        break;
                    case 7:
                        Environment.Exit(1);
                        break;




                    default:
                        break;
                }
                Console.WriteLine("Do u want to continue(y/Y/n/N");
                ans = Convert.ToChar(Console.ReadLine());

            }
            while (ans == 'Y' || ans == 'y');
             
            
           

            Console.ReadLine();

        }

        private static void CreateInitialListof3Products()
        {
            for (int i = 0; i < 3; i++)
            {
                Products p = new Products();
                Console.WriteLine("Enter PRoductID");
                p.ProductId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter ProductName");
                p.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Price");
                p.Price = Convert.ToSingle(Console.ReadLine());
                productlist.Add(p);


            }
        }

    }
}
