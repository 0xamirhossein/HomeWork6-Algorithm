namespace ConvertNumToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-9999): ");

            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 9999)
            {
                Console.WriteLine("Invalid Number!");
            }
            else
            {
                string result = NumToWords.Convert(number);

                Console.WriteLine(result);
            }
        }
    }
}