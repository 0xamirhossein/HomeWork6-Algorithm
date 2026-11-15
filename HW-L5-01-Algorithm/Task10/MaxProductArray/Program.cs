namespace MaxProductArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array elements separated by spaces:");

            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty.");
                return;
            }

            string[] parts = input.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries
            );

            int[] numbers = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out numbers[i]))
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }
            }

            if (numbers.Length < 3)
            {
                Console.WriteLine("Array must contain at least 3 numbers.");
                return;
            }

            long result = FindMax.Find(numbers);

            Console.WriteLine("Maximum product: " + result);
        }
    }
}