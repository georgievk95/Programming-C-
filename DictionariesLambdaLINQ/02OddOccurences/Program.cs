string[] words = Console.ReadLine().Split(" ");

Dictionary<string, int> wordsCount = new();

foreach (string word in words)
{
    string insensitive = word.ToLower();

    if (wordsCount.ContainsKey(insensitive))
    {
        wordsCount[insensitive] += 1;
    }
    else
    {
        wordsCount.Add(insensitive, 1);
    }

}

foreach (KeyValuePair<string, int> pair in wordsCount)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");
    }
}
