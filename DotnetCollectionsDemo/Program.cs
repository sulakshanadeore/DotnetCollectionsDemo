using System;
using System.Collections;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections---->Non Generic

            //object-----Non Generic collection
        

            System.Collections.Stack stack = new Stack();
            //Stack---> LIFO(Last In First Out)

            stack.Push(10);//Add
            stack.Push(20.234f);
            stack.Push("Hello");
            stack.Push('A');
            stack.Push(true);
            stack.Push(new DateTime(2023, 2, 2));

            object poppedElement=stack.Pop();//remove
            Console.WriteLine(poppedElement);

            object peekedvlue=stack.Peek();//Top most
            object[] o=stack.ToArray();
           
            stack.Clear();

            bool ans_Contains=stack.Contains(10);
            Console.WriteLine($"Stack contains 10= {ans_Contains}");
            stack.Push(100);
            stack.Push(2324.324f);
            stack.Push("WElcome");

            stack.CopyTo(o, 0);









        }
    }
}
