string[] input = Console.ReadLine()
    .Split(" ")
    .Where(w => w.Length % 2 == 0)
    .ToArray();


foreach (string word in input)
{
    Console.WriteLine(word);
}

