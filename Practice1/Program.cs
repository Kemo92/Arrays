using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            Console.WriteLine("Enter the Scores");
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];

                }
            }
            int largest = array[9];
            for (int i = 0; i < 10; i++)
            {

                if (array[i] > largest)
                {
                    largest = array[i];

                }
            }
            int average = 0;

            average = ((smallest + largest) / 2);
            Console.WriteLine("the Lowest score is {0}", smallest);
            Console.WriteLine("the Highest score is {0}", largest);
            Console.WriteLine("the Average is {0}", average);
            Console.Read();










        }
    }
}
