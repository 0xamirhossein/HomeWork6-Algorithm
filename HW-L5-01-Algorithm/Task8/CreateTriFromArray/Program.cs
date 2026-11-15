namespace CreateTriFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter integers separated by spaces:");

            string? input = Console.ReadLine();


            if (!string.IsNullOrWhiteSpace(input))
            {
                int[] number;

                bool validInput = true;

                string[] parts = input.Split(
                    ' ',
                    StringSplitOptions.RemoveEmptyEntries
                );

                number = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out number[i]))
                    {
                        validInput = false;
                        break;
                    }
                }

                if (!validInput)
                {
                    Console.WriteLine("Invalid input!");
                    return;
                }

                bool result = Find.FindTri(number);

                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Input cannot be empty.");
            }
        }
    }
}