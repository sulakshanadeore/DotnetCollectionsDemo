using System;
using System.Collections;
using System.Collections.Generic;
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


            //WorkingwithStack();
            //WorkingWithQueue();
            ArrayList a = new ArrayList();
            a.Add(234);
            a.Add(323.233f);
            a.Add(23423.23423d);
            a.RemoveAt(0);//takes index of element as parameter

            Stack stack=new Stack();
            stack.Push(10);//Add
            stack.Push(20.234f);
            stack.Push("Hello");
            stack.Push('A');
            stack.Push(true);
            stack.Push(new DateTime(2023, 2, 2));
            stack.Push(3435345);

            a.AddRange(stack);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }


            a.Insert(5, 10000);
            a.InsertRange(6, stack);
            Console.WriteLine("--------------------------");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            a.RemoveRange(6, 6);
            Console.WriteLine($"ArrayList capacity= {a.Capacity}");
            Console.WriteLine("---------------------------------");
            int indexOfElement = a.IndexOf(10000);
            Console.WriteLine($"Element index= {indexOfElement}");
            


            Console.ReadLine();


        }

        private static void WorkingWithQueue()
        {
            Queue q = new Queue(1);//FIFO
            q.Enqueue(1);
            q.Enqueue("Hello");
            q.Enqueue(43.33f);
            q.Enqueue(34);
            Console.WriteLine("Printing the queue");
            foreach (var item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("----------");
            object o = q.Dequeue();
            Console.WriteLine(o);
            o = q.Peek();
            object[] obj = q.ToArray();
            foreach (var item in obj)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("---------");
            q.CopyTo(obj, 0);
            int cnt = q.Count;
            q.TrimToSize();
        }

        private static void WorkingwithStack()
        {
            System.Collections.Stack stack = new Stack();
            //Stack---> LIFO(Last In First Out)
            
            stack.Push(10);//Add
            stack.Push(20.234f);
            stack.Push("Hello");
            stack.Push('A');
            stack.Push(true);
            stack.Push(new DateTime(2023, 2, 2));

            object poppedElement = stack.Pop();//remove
            Console.WriteLine(poppedElement);

            object peekedvlue = stack.Peek();//Top most
            object[] o = stack.ToArray();

            stack.Clear();

            bool ans_Contains = stack.Contains(10);
            Console.WriteLine($"Stack contains 10= {ans_Contains}");
            stack.Push(100);
            stack.Push(2324.324f);
            stack.Push("WElcome");

            stack.CopyTo(o, 0);
        }
    }
}
