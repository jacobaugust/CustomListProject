﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass 
{
    public class CustomListClass<T> : IEnumerable<T>
    {

        //member variables
        T[] array;
        private int count;
        int capacity;

        public CustomListClass()
        {
            capacity = 5;
            count = 0;
            array = new T[capacity];
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
            {
                if (item == null)
                {
                    break;
                }
                yield return item;
            }

        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
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
        //count method
        public int Count
        {
            get { return count; }
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
        public static CustomListClass<T> operator -(CustomListClass<T> list1, CustomListClass<T> list2)
        {
            CustomListClass<T> removed = new CustomListClass<T>();
            for (int n = 0; n < list1.count; n++)
            {
                removed.Add(list1[n]);
            }
            for (int o = 0; o < list2.count; o++)
            {
                removed.Remove(list2[o]);
            }
            return removed;
        }
        public void ZipList(CustomListClass<int> myList1, CustomListClass<int> myList2, CustomListClass<int> zippedList)
        {
            int takeAway = 1;
            for (int p = 0; p < zippedList.count; p++)
            {
                if (p < 1)
                {
                    zippedList[0] = myList1[0];
                }
                else if (p % 2 != 0)
                {
                    zippedList[p] = myList2[p-takeAway];
                    
                }
                else if (p % 2 == 0)
                {
                    zippedList[p] = myList1[p-takeAway];
                    takeAway++;
                }
                
            }
        }
    }
}


        
               
            
               


    

