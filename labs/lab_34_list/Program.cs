using System;
using System.Collections.Generic;
using System.Collections;

namespace lab_34_list
{
    class Program
    {
        List<int> list01 = new List<int>();
        static List<string> list02 = new List<string>();
        static Dictionary<string, int> catList = new Dictionary<string, int>();

        static void Main(string[] args)
        {


            // arrays are fixed
            var array01 = new int[10]; //size is fixed

            // 2D array
            int[,] Grid2D = new int[10, 10];

            // 3D array
            int[,,] Cube3D = new int[3, 3, 3];

            // 4D array
            int[,,,] Grid4D = new int[5, 5, 5, 5];

            // jagged array
            int[][] jaggedarray = new int[3][];
            jaggedarray[0] = new int[3];
            jaggedarray[1] = new int[16];
            jaggedarray[2] = new int[5];


            // list of strings 
            list02.Add("Hi");
            list02.Add("I am HP");
            list02.Add("How are you");
            foreach (var item in list02)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            // insert new item at index 1 and view
            list02.Insert(1, "Nice to meet you");
            foreach (var word in list02)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();

            // create a dictionary
            catList.Add("Garfield", 28);
            catList.Add("Puss In Boots", 12);
            catList.Add("Simba", 21);
            catList.TryAdd("Simba", 21);
            catList.TryAdd("Mufasa", 41);
            foreach(var cat in catList)
            {
                Console.WriteLine(cat);
            }

            Console.ReadLine();


            // queue
            var queue = new Queue<int>();
            queue.Enqueue(1);  // add first item
            queue.Enqueue(2);  // add second item
            queue.Enqueue(4);  // add third item

            //....................................4.......2......1......BUS STOP
            var itemWhichJustGotOnTheBus = queue.Dequeue();   // first item get on bus
            //....................................4.......2......BUS STOP

            Console.WriteLine("An item has gotten on a bus: " + itemWhichJustGotOnTheBus);

            Console.WriteLine("Queue contains number 2? " + queue.Contains(2));
            Console.WriteLine("Queue contains number 5? " + queue.Contains(5));

            Console.WriteLine("Check out who is first in line: " + queue.Peek());

            // iterate ==> print a foreach loop
            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }

            // stack
            var stack = new Stack<string>();
            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            stack.Push("fourth");

            stack.Pop();

            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            // contains
            Console.WriteLine(stack.Contains("first"));
            // peek
            Console.WriteLine(stack.Peek());

            var arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("Hi");
            arrayList.Add(true);
            arrayList.Add(DateTime.Now);

            foreach(var item in arrayList)
            {
                Console.WriteLine($"{item.GetType() , -20}{item}");
            }
        }

        void DoThis()
        {
            list01.Add(10);
        }
        void DoThat() { }
    }
}
