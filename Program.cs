using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPolymorph
{
    public class Program
    {
        static void Main(string[] args)
        {
            GenerateFizzBuzzOutput(100);
            Console.ReadKey();
        }

        private static void GenerateFizzBuzzOutput(int maxNumberToCaluculate)
        {
            for (int i = 1; i <= maxNumberToCaluculate; i++)
            {
                var number = GetNumber(i);
                Console.WriteLine(number.Output);
            }
        }

        private static Number GetNumber(int i)
        { 
            if (i % 3 == 0 && i % 5 == 0)
            {
                return new DivisibleByThreeAndFiveNumber();
            }
            else if (i % 5 == 0)
            {
                return new DivisibleByFiveNumber();
            }
            else if (i % 3 == 0)
            {
                return new DivisibleByThreeNumber();
            }
            else
            {
                return new Number { Value = i };
            }
        }

        private class Number
        {
            public int Value { get; set; }

            public virtual string Output
            {
                get
                {
                    return Value.ToString();
                }
            }
        }

        private class DivisibleByThreeNumber : Number
        {
            public override string Output
            { 
                get
                {
                    return "Fizz";
                }
            }
        }

        private class DivisibleByFiveNumber : Number 
        {
            public override string Output
            {
                get
                {
                    return "Buzz";
                }
            }
        }

        private class DivisibleByThreeAndFiveNumber : Number 
        {
            public override string Output
            {
                get
                {
                    return "FizzBuzz";
                }
            }
        }
    }
}
