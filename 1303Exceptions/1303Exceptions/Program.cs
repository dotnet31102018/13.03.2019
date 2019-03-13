using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1303Exceptions
{
    public interface IFly
    {
        void Fly();
    }
    public class SuperHeroImposter : IFly
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SuperHeroImposter imposter = new SuperHeroImposter();
            //imposter.Fly();

            //if (1 > 0)
            //{
            //    try
            //    {
            //        foo();
            //    }
            //    catch (IndexOutOfRangeException e)
            //    {
            //        // to swallow the exception
            //    }
            //    catch (SystemException e)
            //    {
            //        Console.WriteLine(e.StackTrace);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.StackTrace);
            //    }

            //}
            bool completed = false;
            //do
            //{
            //    try
            //    {
            //        int a = Convert.ToInt32(Console.ReadLine());
            //        completed = true;
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("Wrong int!");
            //    }
            //} while (completed == false);

            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                if (b == 0)
                {
                    throw new DivideByZeroException($"b was zero while a was {a}!");
                }

                int result = 0;
                while (a > 0)
                {
                    a = a - b;
                    result++;
                }
                Console.WriteLine($"{result} {a}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero!");
            }

        }

        static void SayMyName(string name, int age)
        {
            // check if age is < 0 is 
            // if so throw Argument Exception :
            // in the message specify the age!

        }

        static void foo()
        {
            int a, b;
            a = b = 1;
            try
            {
                int c = a / b;
            }
            catch ( DivideByZeroException e)
            {
                Console.WriteLine("Infinity");
            }
            finally
            {
                // this always occurs
                Console.WriteLine("finished!");
            }

            int[] a1 = { 1, 2, 3 };

            Console.WriteLine(a1[4]);
        }
    }
}
