﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
            
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0) 
            { 
                return true; 
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0) {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Count() < str2.Count())
            {
                return str1.Length;
            }
            else if (str2.Count() < str1.Count())
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
            
            
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            
            var evenSum = 0;

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Count() == 0)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int oddNumCount = 0;

            if (number > 1)
            {
                for (int i = 0; i < number; i++)
                {
                    if (IsNumberOdd(i))
                    {
                        oddNumCount++;
                    }
                }
            }
            return oddNumCount;
            
        }
    }
}
