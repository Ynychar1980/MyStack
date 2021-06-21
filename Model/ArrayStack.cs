using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.Model
{
   public class ArrayStack<T>
   {
      T[] items;
      private int Current = -1;
      private readonly int size = 10;

      public int MaxCount => items.Length;
      public int Count => Current + 1;

      public ArrayStack(int size = 10)
      {
         items = new T[size];
         this.size = size;
      }

      public ArrayStack(T data, int size = 10) : this(size)
      {
         items[0] = data;
         Current = 1;
      }

      public void Push(T data)
      {
         if(Current < size - 1)
         {
            Current++;
            items[Current] = data;            
         }
         else
         {
            throw new StackOverflowException("Стек переполнен");
         }
      }

      public T Pop()
      {
         if(Current >= 0)
         {
            var item = items[Current];
            Current--;
            return item;
         }
         else
         {
            throw new NullReferenceException("Стек пуст");
         }
      }

      public T Peek()
      {
         if (Current >= 0)
         {
            return items[Current];
         }
         else
         {
            throw new NullReferenceException("Стек пуст");
         }
      }
   }
}
