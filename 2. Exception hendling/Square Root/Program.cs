using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int number=0;
        double sqrt;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (number < 0) throw new ArgumentOutOfRangeException();
            else
            {
                sqrt = Math.Sqrt(number);
                Console.WriteLine(sqrt);
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid Number");
        }
        catch(OverflowException)
        {   
            Console.WriteLine("Invalid Number");
        }
        catch(ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid Number");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}

