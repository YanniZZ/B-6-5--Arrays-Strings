using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] six = new[] { 1,2,3,4,5,6};
            //for (int i = six.Length-1; i >= 0; i--) { Console.Write(six[i]); }
            //Console.WriteLine(string.Join(", ", six));
            Random rnd = new Random();
            int[,] six2 = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    six2[i, j] = rnd.Next(100);
                }
            }
            //for (int i = 0; i < six2.Rank; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(six2.GetUpperBound(i));
            //    for (int j = 0; j < six2.GetUpperBound(i); j++)
            //    {
            //        six2[i, j] = rnd.Next(100);
            //        Console.WriteLine($"{six2[i,j], 5}");
            //    }
            //}
            outmass(six2);
            //poemGeneration();
            Console.ReadLine();
        }

        

        //int temp = 0;
        //for (int i =0; i < six2.GetLenght(0); i++)
        //{
        //    for (int j = 0; j < six2.GetLenght(0); j++)
        //    if (six2[i,j]>= temp)
        //    {
        //        temp = six2[i, j];
        //    }
        //    Console.WriteLine(temp);
        //}
        public static void poemGeneration()
        {
            Random rnd = new Random();
            char[][] poem = new char [100][];
            for (int i = 0; i <= 99; i++)
            {
                var word = new char[rnd.Next(10)];
                for (int j = 0; j<word.Length;j++)
                {
                    word[j] = Convert.ToChar(rnd.Next(1040 - 1, 1103));
                }
                poem[i] = word;
            }

            foreach (var word in poem)
            {
                Console.WriteLine(word);
            }
        }
        public static void outmass(int [,] six2)
        {
            //for (int i = 0; i < (six2.GetUpperBound(0)+1); i++)
            //{
            //    for (int j = 0; j < six2.Length/(six2.GetUpperBound(0)+1); j++)
            //    {
            //        Console.WriteLine($"{six2[i,j], 5}");
            //    }
            //}
            foreach (var element in six2)
            {
                Console.WriteLine(element);
            }
        }
        public static void Pyatnashki()
        {
            var numbers = GetInitialValues();
            PrintValues(numbers);
            Play(numbers);

        }

        public static void PoemExample()
        {
            Console.WriteLine("Введите четверостишье");
            string[] poem = new string[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write(i+1 + ". ");
                poem[i] = Console.ReadLine();
            }

            for (int i = 0; i < poem.Length; i++)
            {
                var row = poem[i];

                var result = row
                    .Replace('о', 'а')
                    .Replace("л", "ль")
                    .Replace("ть", "т");

                Console.WriteLine(result);
            }
        }

        private static int[,] GetInitialValues()
        {
            int[,] arr = new int[4, 4];
            int number = 1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = number++;
                }
            }

            arr[3, 3] = 0;

            return arr;
        }

        private static void PrintValues(int[,] arr)
        {
            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(String.Format("{0,4}", arr[i, j]));
                }

                Console.WriteLine();
            }
        }

        private static void Play(int[,] arr)
        {
            var zeroI = 3;
            var zeroJ = 3;
            
            while (true)
            {
                var movement = Console.ReadKey().KeyChar;
                var i = zeroI;
                var j = zeroJ;

                switch (movement)
                {
                    case 'a' :
                        j--;
                        break;
                    case 's':
                        i++;
                        break;
                    case 'd':
                        j++;
                        break;
                    case 'w':
                        i--;
                        break;
                    default:
                        break;
                }

                var swap = arr[i, j];
                arr[i, j] = arr[zeroI, zeroJ];
                arr[zeroI, zeroJ] = swap;

                zeroI = i;
                zeroJ = j;

                PrintValues(arr);
            }
        }
    }
}
