
using System;

namespace ExceptionHandling
{
    class ExceptionHandling
    {
        private static void Main(string[] args)
        {
            var exception = new ExceptionWays();
            try
            {
                exception.DivideByZero();
                exception.ArrayBound();
            }

            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                Console.Error.WriteLine(err);
            }
        }

    }
}