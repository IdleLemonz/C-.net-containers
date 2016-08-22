using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_containers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(4);
            myList.Add(10);
            myList.Add(1);
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }


            //Test test = new Test();
            //test.ListExample();
            while (true) ;
        }
        
    }
    class Test
    {
        public void ArrayExample(int size)
        {
            int[] array = new int[size];
            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }
            //Console.WriteLine(array[3]);
        }

        public void ArrayExample2(int size)
        {
            int[] array = new int[size];
            array[0] = 30;
            array[1] = 25;
            array[2] = 40;

            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }

        public void ListExample()
        {
            List<int> myList = new List<int>()
            {
                3,5,2,8
            };
            myList.Add(4);
            myList.Add(10);
            myList.Add(1);
            myList.Add(9);
            myList.Add(6);
            myList.Add(-1);
            myList.Add(0);
            myList.Add(-2);
            myList.Sort(delegate (int a, int b)
            {
                //if (a < b) return -1;
                //if (a > b) return 1;
                return a-b;
            });
            //myList.Remove(5);
            //myList.RemoveAt(4);
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }           
        }
    }
}
