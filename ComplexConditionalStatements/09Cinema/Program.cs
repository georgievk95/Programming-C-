namespace _09Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int rowsSeast = int.Parse(Console.ReadLine());
           
            int totalSeats = rowsSeast * rowsCount;
            double totalPrice = 0;
           if (movieType == "Premiere")
           {
                totalPrice = totalSeats * 12.00;
           }
           else if (movieType == "Normal")
           {
                
                totalPrice = totalSeats * 7.50;
                
           }
           else if (movieType == "Discount")
           {
               
                totalPrice = totalSeats * 5.00;
                
           }
                Console.WriteLine($"{totalPrice:f2}");
           
        }
    }
}