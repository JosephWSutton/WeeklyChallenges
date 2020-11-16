using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int valCount = vals.Length;
            return (valCount % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 == 0) ? false : true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            try
            {
                return numbers.Min() + numbers.Max();
            }
            catch(Exception)
            {
                return 0;
            }
           
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length > str2.Length) ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            try
            {
                int x = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    x += numbers[i];
                }
                return x;
            }
            catch (NullReferenceException)
            {
                return 0;
            }
        }

        public int SumEvens(int[] numbers)
        {
            try
            {
                int x = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        x += numbers[i];
                    }
                }
                return x; }
             catch (NullReferenceException)
            {
                return 0;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            try
            {
                int x = 0;
                foreach (int num in numbers)
                {
                    x += num;
                }
                return (x % 2 == 0) ? false : true;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = new List<long>();
            for(int i = 1; i < number; i += 2)
            {
                count.Add(i);
            }
            return count.Count;
        }
    }
}
