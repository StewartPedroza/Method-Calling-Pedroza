using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MethodCalling_Pedroza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("All the inputted numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            double average = CalculateAverage(numbers);
            double maximum = CalculateMaximum(numbers);
            double minimum = CalculateMinimum(numbers);
            double median = CalculateMedian(numbers);

            Console.WriteLine("Average: " + average);
            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Minimum: " + minimum);
            Console.WriteLine("Median: " + median);
        }

        static double CalculateAverage(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        static double CalculateMaximum(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static double CalculateMinimum(double[] array)
        {
            double min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static double CalculateMedian(double[] array)
        {
            Array.Sort(array);
            if (array.Length % 2 == 0)
            {
                return (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2;
            }
            else
            {
                return array[array.Length / 2];
            }
        }
    }
}
