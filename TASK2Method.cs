using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 92, 87, 76, 65, 54, 43, 32,3};
            CalcAvg(arr);
        }
        static void CalcAvg(int[] arr)
        {
            int sum = 0;
            int NumericalAverage = 0;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                counter++;
                NumericalAverage = sum / counter;
            }
            Console.WriteLine(NumericalAverage);
            if (NumericalAverage>60)
                {
                    Console.WriteLine(" you graduated");
                }
                else
                {
                    Console.WriteLine( "you arent graduated");
                }
            }
           

        }
    }

