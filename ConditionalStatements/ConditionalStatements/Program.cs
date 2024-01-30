namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            if(temperature < 0 )
            Console.WriteLine("Freezing weather!");
        }
    }
}