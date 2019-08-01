using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numberArray = new int[10] { 1, 2, 4, 7, 11, 16, 22, 29, 37, 46 };
            Eng35Tests.CreateArrayFromSentence("Hello my name is Alex");
            Eng35Tests.CalculateWordCount("Hello my name is Alex");
            Eng35Tests.TurnFirstWordToUppercase("Hello my name is Alex");
            Eng35Tests.Mega_Multiple_Magnificent_Coding_Loops(numberArray);
            */
            RunFizzBuzz();
        }

        static void RunFizzBuzz()
        {
            int i = 0;

            for(i=0;i<100;i++)
            {
                // for every multiple of 15, print fizzbuzz
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // for every multiple of 5, print buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // for every multiple of 3, print fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }

    public class Eng35Tests
    {
        static List<Cat> cats = new List<Cat>();
        private static int numberOfRabbits = 1;
        private static System.Timers.Timer myTimer;
        private static int elapsedTime;
        private static bool DoOnce;
        static int limit;

        // pass in a sentence, return an array of individual words
        public static string[] CreateArrayFromSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            return words;
        }


        // pass in a sentence and return the number of words
        public static int CalculateWordCount(string sentence)
        {
            int counter = 0;
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {
                counter++;
            }
            Console.WriteLine(counter);
            return counter;
        }

        // turn first word to uppercase
        public static string TurnFirstWordToUppercase(string sentence)
        {
            //"This is a sentence" returns "THIS is a sentence"
            string[] words = sentence.Split(" ");
            words[0] = words[0].ToUpper();
            string FirstUpperSentence = string.Join(" ", words);
            Console.WriteLine(FirstUpperSentence);
            return FirstUpperSentence;
        }

        // all turn all words to uppercase except last - turn last to lowercase
        public static string TurnAllWordsButLastToUppercase(string sentence)
        {
            //"This is a sentence" returns "THIS is a sentence"
            string[] words = sentence.Split(" ");
            int wordCounter = 0;
            foreach (var word in words)
            {
                wordCounter++;
                word.ToUpper();
            }
            string newSentence = string.Join(" ", words);
            return "";
        }

        public static int Mega_Multiple_Magnificent_Coding_Loops(int[] myArray)
        {
            // Pass in an array of 10 numbers [1,2,4,7,11,16,22,29,37,46]
            Console.WriteLine("Passing in array:");
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                Console.Write(myArray[i].ToString() + " ");
            }
            Console.ReadLine();

            // While loop ==> add one to each number [2,3,5,8,12,17,23,30,38,47]
            int j = 0;
            while (j < 10)
            {
                myArray[j] += 1;
                Console.Write(myArray[j].ToString() + " ");
                j++;
            }
            Console.ReadLine();

            // Do..While loop ==> add 3 to each number [5,6,8,13,15,20,26,33,41,50]
            int n = 0;
            do
            {
                myArray[n] += 3;
                Console.Write(myArray[n].ToString() + " ");
                n++;
            }
            while (n < 10);
            Console.ReadLine();

            // For Each loop ==> double each number [10,12,16,26,30,40,52,66,82,100]
            int counter = 0;
            foreach (var item in myArray)
            {
                myArray[counter] *= 2;
                var c = new Cat(item , "Cat" + item.ToString());
                cats.Add(c);
                counter++;
            }

            // Create a list of Cats and foreach loop ==> create new cat with name 'Cat' + number and Age=number
            int totalAge = 0;
            foreach (var cat in cats)
            {
                totalAge += cat.Age;
                Console.WriteLine($"Name{cat.Name,-20}{cat.Age,-10}");
            }
            return totalAge;
        }

        public static int How_Many_Numbers_Divisible_By(int start, int end, int divisor)
        {
            // how many integers are divisible by given divisor in the given range?
            // example (2,10,4) means start at 2 and count to 10
            // only 4 and 8 are divisible by 4
            // so only answer is 2

            int i = 0;
            int answer = 0;
            for(i=start; i<end; i++)
            {
                int tester = i % divisor;
                if(tester == 0)
                {
                    answer++;
                }
            }

            return answer;
        }

        public static int Array_Loop_Queue_Static(int[] array)
        {
            List<int> snapList = new List<int>();
            // 145
            // take numbers
            int[] numbers = array;
            // create a list, multiply by 10
            snapList.Add(numbers[0] * 10);
            snapList.Add(numbers[1] * 10);
            snapList.Add(numbers[2] * 10);
            snapList.Add(numbers[3] * 10);

            // create a queue, add 1
            var snapQueue = new Queue<int>();
            foreach (var snapper in snapList)
            {
                snapQueue.Enqueue(snapper + 1);
            }

            // create a stack, add 2
            var snapStack = new Stack<int>();
            foreach (var snapItem in snapQueue)
            {
                snapStack.Push(snapItem + 2);
            }

            // whats the sum?
            int sum = 0;
            foreach (var snapper in snapStack)
            {
                sum += snapper;
            }

            return sum;
        }

        public static int RabbitExplosion(int timeEstimate)
        {
            var pause = new ManualResetEvent(false);
            limit = timeEstimate;
            elapsedTime = 0;
            numberOfRabbits = 1;

            Console.WriteLine($"\n\n=====RABBIT EXPLOSION=====");

            myTimer = new System.Timers.Timer();
            myTimer.Interval = 1000;
            myTimer.Elapsed += DoubleRabbits;
            myTimer.AutoReset = true;
            myTimer.Enabled = true;
            pause.WaitOne(limit * 1001);

            return numberOfRabbits;
        }

        static void DoubleRabbits(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (elapsedTime >= limit)
            {
                myTimer.Enabled = false;
                Console.WriteLine($"\t\tRabbit population reached {numberOfRabbits} in {elapsedTime} seconds!");
            }
            else if (elapsedTime < limit)
            {
                elapsedTime += 1;
                numberOfRabbits *= 2;
                Console.WriteLine($"\t\t{elapsedTime} seconds in, the rabbit population is {numberOfRabbits}");
            }
        }
    }

    public class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Cat(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }
        public string GetName(string name)
        {
            name = this.Name;
            return name;
        }

        public int GetAge(int newAge)
        {
            newAge++;
            return newAge;
        }
    }
}
