namespace MethodOverloading
{
    public class Program
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }
        public string Add(int number1, int number2, bool includeDollars)
        {
            int sum = number1 + number2;

            if (includeDollars)
            {
                // Handle singular/plural grammar
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }

            // If includeDollars is false, just return the sum as a string
            return sum.ToString();
        }



    }
}
