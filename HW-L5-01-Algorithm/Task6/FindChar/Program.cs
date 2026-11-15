namespace FindChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string? text = Console.ReadLine();

            int result = FindUniqueChar.Find(text);

            if (result == -1)
            {
                Console.WriteLine("No unique character found!");
            }
            else
            {
                Console.WriteLine("First unique character: " + text![result]);
                Console.WriteLine("Index: " + result);
            }
        }
    }
}