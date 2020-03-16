using Problems.Interfaces;

namespace Problems.Excercises1To10
{
    public class Problem003 : Problem, IProblem1To10
    {
        public string Name()
        {
            return "Problem003: Largest prime factor";
        }

        public string Description()
        {
            return @"The prime factors of 13195 are 5, 7, 13 and 29.

                    What is the largest prime factor of the number 600851475143?";
        }

        public AnswerDTO Run()
        {
            StartTimer();
            
            var number = 600851475143;
            long maxPrime = 0;

            for (var i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    maxPrime = i;
                    number /= i;
                }
            }
            
            return new AnswerDTO {Answer = maxPrime.ToString(), TimeTaken = StopTimer().ToString()};
        }

        public int Number()
        {
            return 3;
        }
    }
}