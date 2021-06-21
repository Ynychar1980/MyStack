using MyStack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
   class Program
   {
      static void Main(string[] args)
      {
         EasyStack<int> easyStack = new EasyStack<int>();

         easyStack.Push(1);
         easyStack.Push(2);
         easyStack.Push(3);
         easyStack.Push(4);
         easyStack.Push(5);

         var item1 = easyStack.Pop();
         var item2 = easyStack.Peek();

         Console.WriteLine(item1);
         Console.WriteLine(item2);
         Console.ReadLine();


         var linkedStack = new LinkedStack<int>();
         linkedStack.Push(10);
         linkedStack.Push(20);
         linkedStack.Push(30);
         linkedStack.Push(40);
         linkedStack.Push(50);

         Console.WriteLine(linkedStack.Peek());
         Console.WriteLine(linkedStack.Pop());
         Console.WriteLine(linkedStack.Pop());
         Console.WriteLine(linkedStack.Peek());
         Console.ReadLine();

         var arrayStack = new ArrayStack<int>(5);
         arrayStack.Push(100);
         arrayStack.Push(200);
         arrayStack.Push(300);
         arrayStack.Push(400);
         arrayStack.Push(500);

         Console.WriteLine(arrayStack.Peek());
         Console.WriteLine(arrayStack.Pop());
         Console.WriteLine(arrayStack.Pop());
         Console.WriteLine(arrayStack.Peek());

         Console.ReadLine();
      }
   }
}
