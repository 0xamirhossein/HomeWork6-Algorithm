namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a non-negative integer:");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }



             if (n == 1 || n == 0)
            {
                Console.WriteLine("1 and 0 are neither prime nor composite");
                return;
            }


            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(n); i++) 
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && n !=1)
            {
                Console.WriteLine($"{n} is a prime number");
            }
            
            else
            {
                Console.WriteLine($"{n} is not a prime number");
            }

            if (!isPrime)
            {
                Console.WriteLine($"rishe ha {n} :  ");
                for (int i =2; i<= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine($"{i}  , ");
                    }
                }
            }   

        }
    }
}
