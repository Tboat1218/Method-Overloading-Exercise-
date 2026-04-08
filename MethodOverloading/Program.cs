namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.Add(3, 2));           // 5
            Console.WriteLine(p.Add(1.5m, 2.5m));     // 4.0
            Console.WriteLine(p.Add(3, 2, true));      // "5 dollars"
            Console.WriteLine(p.Add(0, 1, true));      // "1 dollar"
            Console.WriteLine(p.Add(8, 8, true));      // "16 dollars"
        }

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
