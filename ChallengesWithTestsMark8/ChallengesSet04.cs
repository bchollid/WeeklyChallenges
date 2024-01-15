using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            for(var i = 0; i<numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    total += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    total -= numbers[i];
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] stringArray = new string[] { str1, str2, str3, str4 };
            int smallestLength = stringArray.Min(str => str.Length);
            return smallestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] intArray = new int[] { number1, number2, number3, number4 };
            int smallestNumber = intArray.Min(num => num);
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            bool isItANumber = double.TryParse(input, out double number);
            return isItANumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var tally = 0;
            var majory = (objs.Length / 2) + 1;
            for(int i = 0; i<objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    tally++;
                }
            }

            if(tally >= majory)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            if (count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            int result = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i>0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
