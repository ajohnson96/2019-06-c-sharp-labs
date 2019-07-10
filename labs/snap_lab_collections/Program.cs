using System;
using System.Collections;
using System.Collections.Generic;

namespace snap_lab_collections
{
    //Input 5 numbers and put into an ArrayList
    //Create an Array, List, Queue, Stack, Dictionary.
    //Move objects from Arraylist to each item and multiply by 4 each move.
    //What's the total?
    //Time starts
    class Program
    {
        //static List<int> arrayList= new List<int>();
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            var array01 = new int[5];
            var list01 = new List<int>();
            var queue01 = new Queue<int>();
            var stack01 = new Stack<int>();
            var dict01 = new Dictionary<int,int>();
            int sum = 0;

            for (int i = 0; i<5;i++)
            {
                arrayList.Add(i + 5);
                Console.WriteLine(arrayList[i]);
            }
            Console.ReadLine();

            // Add to array
            for(int i = 0; i<5; i++)
            {
                array01[i] = (int)arrayList[i] * 4;
                //array01[i] = array01[i] * 4;
            }
            Console.ReadLine();


            // Add to list
            foreach(var number in array01)
            {
                list01.Add(number * 4);
            }
            Console.ReadLine();

            // Add to queue
            queue01.Enqueue(list01[0] * 4);  
            queue01.Enqueue(list01[1] * 4);  
            queue01.Enqueue(list01[2] * 4);  
            queue01.Enqueue(list01[3] * 4);  
            queue01.Enqueue(list01[4] * 4);

            // Add to stack
            stack01.Push(queue01.Dequeue() * 4);
            stack01.Push(queue01.Dequeue() * 4);
            stack01.Push(queue01.Dequeue() * 4);
            stack01.Push(queue01.Dequeue() * 4);
            stack01.Push(queue01.Dequeue() * 4);

            // Add to dictionary
            for (var c = 0; c<5; c++)
            {
                dict01.Add(c, stack01.Pop() * 4);
            }
            Console.ReadLine();

            foreach (var key in dict01.Keys)
            {
                sum += dict01[key];
            }
            Console.WriteLine(sum);
        }
    }
}
