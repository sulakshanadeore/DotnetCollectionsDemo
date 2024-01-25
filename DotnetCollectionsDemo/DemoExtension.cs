using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingLibrary;
namespace DotnetCollectionsDemo
{
    public static class DemoExtension
    {
        public static void CallingMethod(this Class2 obj)
        {
            Console.WriteLine("I am the extended method");

        }


        public static int AddNos(this Class2 obj,int i, int j)
        {

            return i + j;
        }

    }
}
