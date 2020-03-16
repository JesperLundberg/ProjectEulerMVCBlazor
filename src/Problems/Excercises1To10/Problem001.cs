using Problems.Interfaces;

namespace Problems.Excercises1To10
{
    public class Problem001 : Problem, IProblem1To10
    {
        public string Name()
        {
            return "Problem001: Multiples of 3 and 5";
        }

        public string Description()
        {
            return
                @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

                    Find the sum of all the multiples of 3 or 5 below 1000.";
        }

        public AnswerDTO Run()
        {
            StartTimer();

            var sum = 0;

            for (var i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return new AnswerDTO {Answer = sum.ToString(), TimeTaken = StopTimer().ToString()};
        }

        public int Number()
        {
            return 1;
        }
    }
}