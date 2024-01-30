Dictionary<char, int> input = new();

string text = Console.ReadLine();

foreach (char ch in text)
{
    if (ch == ' ')
    {
        continue;
    }

    if (input.ContainsKey(ch))
    {
        input[ch]++;
    }
    else
    {
        input.Add(ch, 1);
    }
}
foreach(KeyValuePair<char, int> pair in input)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
