namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cwonsole.WriteLine("Enter a non-negative integer:");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }


            long first = 0;
            long second = 1;


            for (int i = 2; i < n; i++)
            {
                long next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine(second);
        }
    }
}
