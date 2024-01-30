namespace FiguresArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double size = double.Parse(Console.ReadLine());
                double area = size * size;
                Console.WriteLine($"{area:f2}");

            }
            else if (figure == "rectangle")
            {
                double sizeA = double.Parse(Console.ReadLine());
                double sizeB = double.Parse(Console.ReadLine());
                double area = sizeA * sizeB;
                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:f2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }

        }
    }
}