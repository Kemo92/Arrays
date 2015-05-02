using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels
{
    class Program
    {
        static void Main(string[] args)
        {

            int cons = 0;
            int total = 0;
            //set up array for vowels
           char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            // takes in sentance from user
            Console.WriteLine("Enter a Sentence");
            string sentence = Console.ReadLine();
            // initiate loop
            for (int i = 0; i < sentence.Length; i++)
            {

                
                if (vowels.Contains(sentence[i]))
                {
                    total++;
                }
                else
                {
                    cons++;
                }
            }
            Console.WriteLine("Ther are {0} vowels.", total);
            Console.WriteLine("Ther are {0} consonants.", cons);
            Console.ReadLine();




        }


        
    
    
    
    
    }
}
