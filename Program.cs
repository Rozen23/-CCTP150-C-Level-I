using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 100: ");
            int number= int.Parse(Console.ReadLine());
            if(number >=1  && number<=100)
            {
                int totalnum = 0;
                for(int x=1; x<=number;x++)
                {
                    if(IsEvenNumber(x))
                    {
                        totalnum += x;
                        Console.Write("{0}", x);
                        if (x < number && number-x>1)
                        {
                            Console.Write(" + ");
                        }
                    }
                }
                Console.Write(" = {0}", totalnum);
            }
            else
            {
                Console.WriteLine("Wrong entry please enter numebr only");
            }
            Console.ReadKey();

        }
        static public bool IsEvenNumber(int intNumber)
        {
            return intNumber % 2 == 0;
        }
    }
}
