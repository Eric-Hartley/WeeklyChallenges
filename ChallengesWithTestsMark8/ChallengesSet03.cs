using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false) 
                { 
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            List<int> odds = new List<int>();
            foreach (var val in numbers)
            {
                if (val % 2 != 0)
                {
                    odds.Add(val);
                }
            }
            var sum = odds.Sum();

            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]) == true)
                {
                    containsUpper = true;
                }
                if (char.IsLower(password[i]) == true)
                {
                    containsLower = true;
                }
                if (char.IsNumber(password[i]) == true)
                {
                    containsNumber = true;
                }

                if (containsLower == true && containsUpper == true && containsNumber == true)
                {
                    return true;
                }
            }
            return false;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return divisor;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var last = nums[nums.Length - 1];
            var first = nums[0];
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddNums = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddNums.Add(i);
                }
                
            }
            return oddNums.ToArray();   
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
