using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(bool val in vals)
            {
                if(val == false) { return true; }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int oddCount = 0;
            if(numbers == null) { return false; }
            foreach(var num in numbers)
            {
                if(num % 2 != 0) { oddCount += num; }
            }
            return (oddCount % 2 == 0) ? false : true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
             bool containsThatIsh =
                password.Any(char.IsUpper)
                && password.Any(char.IsLower)
                && password.Any(char.IsNumber);
            return containsThatIsh;
        }

        public char GetFirstLetterOfString(string val)
        {
            char first = val.First();
            return first;
        }

        public char GetLastLetterOfString(string val)
        {
            char last = val.Last();
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
                
        }

        public int LastMinusFirst(int[] nums)
        {
            int answer = nums.Last() - nums.First();
            return answer;
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
        }




            public void ChangeAllElementsToUppercase(string[] words)
        {
            
            for(int i = 0;i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
