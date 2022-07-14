using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class ExceptionWays
    {
        public void DivideByZero()
        {

            int result = 0;
            try
            {
                Console.Write("Enter number 1 : ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2 : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                result = num1 / num2;
                Console.WriteLine($"Output: {result}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter the values in numbers only");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("End of the division code");
            }

        }

        public void ArrayBound()
        {

            string[] vehicle = { "Car", "Bike", "Cycle" };
            try
            {
                Console.Write("Enter the index: ");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Output: {vehicle[index]}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Enter the index within range only");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter the index in numbers only");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("End of the array code");
            }

        }

    }
}





