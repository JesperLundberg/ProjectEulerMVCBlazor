using Problems.Interfaces;

namespace Problems.Excercises1To10
{
    public class Problem006 : Problem, IProblem1To10
    {
        public string Name()
        {
            return "Problem006: Sum square difference";
        }

        public string Description()
        {
            return
                @"The sum of the squares of the first ten natural numbers is, 1^2+2^2+...+10^2=385

                The square of the sum of the first ten natural numbers is,
                (1+2+...+10)^2=55^2=3025

                Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025−385=2640.

                Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";
        }

        public AnswerDTO Run()
        {
            StartTimer();

            var sumOfSquare = 0;
            var squareOfSum = 0;

            for (var i = 1; i <= 100; i++)
            {
                sumOfSquare += i * i;
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;
            
            return new AnswerDTO {Answer = (squareOfSum - sumOfSquare).ToString(), TimeTaken = StopTimer().ToString()};
        }

        public int Number()
        {
            return 6;
        }
    }
}