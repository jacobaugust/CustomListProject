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
        bool remove;
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
                T[] capacityArray;
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
        public bool Remove(T value)
        {
            T[] removeArray = new T[capacity];
            bool setTempArray = false;
            for (int j = 0; j < count; j++)
            {
                if (value.ToString() == array[j].ToString())
                {
                    for (int k = 0; k < count; k++)
                    {
                        if (value.ToString() != array[k].ToString())
                        {
                            removeArray[k] = array[k];
                            setTempArray = true;

                        }
                        else
                        {
                            for (int l = 0; l < count; l++)
                            {
                                removeArray[k] = array[k + 1];
                                if (k < count - 2)
                                {
                                    k++;
                                }

                            }
                            array = removeArray;
                            count--;
                            return setTempArray;
                        }

                    }

                }


            }

            return setTempArray;
        }
        public override string ToString()
        {
            string stringArray;
            stringArray = "";
            for (int m = 0; m < count; m++)
            {
                stringArray += array[m].ToString();

            }
            return stringArray;
        }

        
        public static CustomListClass<T> operator +(CustomListClass<T> list1, CustomListClass<T> list2)
        {
            CustomListClass<T> combined = new CustomListClass<T>();
            for (int n = 0; n < list1.count; n++)
            {
                combined.Add(list1[n]);
            }
            for (int o = 0; o < list2.count; o++)
            {
                combined.Add(list2[o]);
            }
            return combined;

        }
    }
}


        
               
            
               


    

