namespace MaxSubArray
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
                Console.Write($"Enter the number {i+1} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int result = FindMax.FindLength(numbers);

            Console.WriteLine($"Length of longest continuous increasing subsequence: {result}");
        }
    }
}
