List<int> input = Console.ReadLine()
                     .Split()
                     .Select(int.Parse)
                     .ToList();

int rotation = int.Parse(Console.ReadLine());
 
for (int i = 0; i < rotation; i++)
{
    int currentNum = input[0];
    input.RemoveAt(0);
    input.Add(currentNum);
}
Console.WriteLine(string.Join(" ", input));
