using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //var sum = 0;
            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        sum += number;
            //    }
            //    if (number % 2 == 1)
            //    {
            //        sum -= number;
            //    }
            //}
            //return sum;
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lengths = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };

            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new List<int>() { number1, number2, number3, number4 };

            var smallest = number1;

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] < smallest)
                { 
                    smallest = numbers[i];
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) && 
                   (sideLength1 + sideLength3 > sideLength2) && 
                   (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var number);
            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var length = objs.Length;
            var majority = (length / 2) + 1;
            int counter = 0;
               
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    counter++;
                }
            }
            return counter >= majority;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var evens = numbers.Where(x => x % 2 == 0);

            if ((evens.Count() == 0))
            {
                return 0;
            }

            return evens.Average() ;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
