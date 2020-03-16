using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Problems.Interfaces;

namespace Problems.Excercises1To10
{
    public class Problem005 : Problem, IProblem1To10
    {
        public string Name()
        {
            return "Problem005: Smallest multiple";
        }

        public string Description()
        {
            return
                @"2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

                What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
        }

        public AnswerDTO Run()
        {
            StartTimer();

            var smallestDivisble = 1;

            // var numbers = Enumerable.Range(1, 20);

            while (true)
            {
                // Note: Much nicer solution but much slower than the below by an order of about 10
                // if (numbers.All(number => smallestDivisble % number == 0))
                // {
                //     return new AnswerDTO {Answer = smallestDivisble.ToString(), TimeTaken = StopTimer().ToString()};
                // }

                if (smallestDivisble % 1 == 0 && smallestDivisble % 2 == 0 && smallestDivisble % 3 == 0 &&
                    smallestDivisble % 4 == 0 && smallestDivisble % 5 == 0 &&
                    smallestDivisble % 6 == 0 && smallestDivisble % 7 == 0 && smallestDivisble % 8 == 0 &&
                    smallestDivisble % 9 == 0 && smallestDivisble % 10 == 0 &&
                    smallestDivisble % 11 == 0 && smallestDivisble % 12 == 0 && smallestDivisble % 13 == 0 &&
                    smallestDivisble % 14 == 0 && smallestDivisble % 15 == 0 &&
                    smallestDivisble % 16 == 0 && smallestDivisble % 17 == 0 && smallestDivisble % 18 == 0 &&
                    smallestDivisble % 19 == 0 && smallestDivisble % 20 == 0)
                {
                    break;
                }

                smallestDivisble++;
            }

            return new AnswerDTO {Answer = smallestDivisble.ToString(), TimeTaken = StopTimer().ToString()};
        }

        public int Number()
        {
            return 5;
        }
    }
}