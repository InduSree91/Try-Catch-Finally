using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start the code");

            int i = 0;

            try
            {
                int result = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Number can not be divided by Zero");
            }
            finally
            {
                Console.WriteLine("Completed running");
            }
        }
    }
}