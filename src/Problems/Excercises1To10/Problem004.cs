using Problems.Interfaces;

namespace Problems.Excercises1To10
{
    public class Problem004 : Problem, IProblem1To10
    {
        public string Name()
        {
            return "Problem004: Largest palindrome product";
        }

        public string Description()
        {
            return
                @"A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

                    Find the largest palindrome made from the product of two 3-digit numbers.";
        }

        public AnswerDTO Run()
        {
            StartTimer();

            var largestPalindrome = 0;

            for (var number1 = 999; number1 > 99; number1--)
            {
                for (var number2 = 999; number2 > 99; number2--)
                {
                    var product = number1 * number2;
                    if (IsPalindrome(product) && (product > largestPalindrome))
                    {
                        largestPalindrome = product;
                    }

                    number2--;
                }

                number1--;
            }

            return new AnswerDTO {Answer = largestPalindrome.ToString(), TimeTaken = StopTimer().ToString()};
        }

        private bool IsPalindrome(int number)
        {
            for (var i = 0; i < number.ToString().Length / 2; i++)
            {
                if (number.ToString()[i] != number.ToString()[number.ToString().Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public int Number()
        {
            return 4;
        }
    }
}