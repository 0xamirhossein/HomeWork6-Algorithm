namespace TargetOfSumInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the number {i + 1} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the target sum:");
            int target = int.Parse(Console.ReadLine());

            bool result = BinarySearch.TargetOfSum(numbers, target);
            Console.WriteLine($"Target sum {target} found: {result}");

        }
    }
}
