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
        int counter;
        int capacity;

        public CustomListClass()
        {
            capacity = 5;
            counter = 0;
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
            for (counter = 0; counter <= capacity; counter++)
            {
                array[counter] = value;
            }

            //assign what index number the value will be sent to

            //manage count

            //check capacity (if at 60% double capacity)
            capacity = capacity++;

        }



    }
}
