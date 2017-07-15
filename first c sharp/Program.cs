using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_c_sharp
{ enum type : sbyte
    {
        BMW = 1, Opel = 2
    }
    struct car
    {
        public int number , year;
        public int Print() => number + year;

    }
    class Program
    {
        static void Prime(int x)
        {
            int count = 0;
            for (int i = 2; i < x / 2; i++)
                if (x % i == 0) count++;
            if (count != 0) Console.WriteLine("not Prime");
            else Console.Write("Prime");
        }
        static void Mult_4(ref int x1, ref int x2 )
        {
            int temp = x1;
            x1 = x2;
            x2 = temp;
        }      
        static int Max(int []array, out int  index)
        {
            int max = array[0];
            index = 0;
            for(int i=0;i<array.Length;i++)
                if(max <array[i])
                {
                    max = array[i];
                    index = i;
                }
            return max;
        }
        static void Main(string[] args)
        {
            /* int[,,] A = new int[2, 2, 3]
             {
                 {
                      { 1,2,3 }  , {2,3,5 }
                 },
                 {
                      {3,3,3 } , { 3,1,2}
                 }
             };
             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 2; j++)
                 {
                     for (int k = 0; k < 3; k++)
                     {
                         Console.Write("{0} ", A[i, j, k]);
                     }
                     Console.WriteLine("");
                 }

             }
             Console.WriteLine("");
             int[][] a = new int[2][];
             a[0] = new int[5] { 1, 2, 3, 4, 5 };
             a[1] = new int[3] { 3, 4, 2 };


            */

            /*string str = "Hello my dear";
            string []str2;
            char[] a = { ' ' };
            str = str.PadRight(16,'a');
            ///str = str.PadRight(15, 'e');
            ///str = str.PadRight(16, 't');
            str2 = str.Split(a);
            Console.WriteLine($"{str}");
            foreach (string word in str2)
                Console.WriteLine("{0}", word);
            Console.ReadKey();*/
            Prime(14);
            int y1 = 5, y2 = 4,index;
            Mult_4(ref y1, ref y2);
            Console.WriteLine($"\ny1={y1}\t y2={y2}");
            int[] array = { 3, 5, 6, 7, 8, 2 };
            int temp = Max(array, out index);
            car c1;
            c1.number = 40;
            c1.year = 50;
            Console.WriteLine($"{c1.Print()}");
            Console.ReadLine();
        }

    }

       
            }

