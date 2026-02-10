using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class Car<T>
    {
        T[] items;

        // Constructor
        public Car() {

            items = new T[0];
        }


        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[tempArray.Length];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
    } 
}
