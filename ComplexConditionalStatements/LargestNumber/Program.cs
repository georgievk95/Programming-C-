namespace LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int N3 = int.Parse(Console.ReadLine());

            if (N1 > N2 && N1 > N3)
                Console.WriteLine(N1);
            else if (N2 > N1 && N2 > N3)
                Console.WriteLine(N2);
            else
                Console.WriteLine(N3);
;        }
    }
}