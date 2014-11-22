using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        public static int ReadNumber(int start, int end)
        {

            int number = int.Parse(Console.ReadLine());
            if (number <= start)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number >= end)
            {
                throw new IndexOutOfRangeException();
            }
            return number;
        }
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int counter = 0;
            while (counter < 10)
            {               
                try
                {
                    int number = ReadNumber(start, end);
                    start = number;
                    counter++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number must be > form {0}",start);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Number must be < form {0}", end);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is to Big!!!");
                }
            }
        }
    }
}
