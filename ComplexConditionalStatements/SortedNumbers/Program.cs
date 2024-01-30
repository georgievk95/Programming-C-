namespace SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            double num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("Ascending");

            }
            else if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("Descending");

            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
                
    }
}