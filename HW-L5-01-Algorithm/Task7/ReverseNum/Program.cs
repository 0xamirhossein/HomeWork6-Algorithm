namespace ReverseNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int result = ReverseNumber.Reverse(number);

                Console.WriteLine("Reversed number: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}