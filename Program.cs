﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPolymorph
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenerateFizzBuzzOutput(100);
            Console.ReadKey();
        }

        public static void GenerateFizzBuzzOutput(int maxNumberToCaluculate)
        {
            for (int i = 1; i <= maxNumberToCaluculate; i++)
            {
                var number = GetNumber(i);
                Console.WriteLine(number.ToString());
            }
        }

        public static Number GetNumber(int i)
        {
            if (NumberIsDivisibleByThreeAndFive(i))
            {
                return new DivisibleByThreeAndFiveNumber();
            }
            else if (NumberIsDivisibleByFive(i))
            {
                return new DivisibleByFiveNumber();
            }
            else if (NumberIsDivisibleByThree(i))
            {
                return new DivisibleByThreeNumber();
            }
            else
            {
                return new Number { Value = i };
            }
        }

        private static bool NumberIsDivisibleByThreeAndFive(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        private static bool NumberIsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

        public static bool NumberIsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        public class Number
        {
            public int Value { get; set; }

            public override string ToString()
            {
                return Value.ToString();
            }
        }

        public class DivisibleByThreeNumber : Number
        {
            public override string ToString()
            {
                return "Fizz";
            }
        }

        public class DivisibleByFiveNumber : Number
        {
            public override string ToString()
            {
                return "Buzz";
            }
        }

        public class DivisibleByThreeAndFiveNumber : Number
        {
            public override string ToString()
            {
                    return "FizzBuzz";
            }
        }
    }
}
