using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomListClass<T>
    {

        //member variables
        T[] array;
        T[] capacityArray;
        public int count;
        int capacity;

        public CustomListClass()
        {
            capacity = 5;
            count = 0;
            array = new T[capacity];
        }

        //indexer
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        //add method
        public void Add(T value)
        {
            if (count < capacity)
            {
                array[count] = value;
            }
            else
            {
                capacity = capacity * 2;
                capacityArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    capacityArray[i] = array[i];
                }
                capacityArray[count] = value;
                array = capacityArray;
            }
            
            count++;
        }
        //remove method



    }
}
