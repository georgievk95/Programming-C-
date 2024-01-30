string[] numbers = Console.ReadLine().Split(" ");

SortedDictionary<string, int> numbersFrequency = new();

foreach (string number in numbers)
{
    if (numbersFrequency.ContainsKey(number))
    {
        numbersFrequency[number] += 1;
    }
    else
    {
        numbersFrequency.Add(number, 1);
    }
}
foreach (KeyValuePair<string, int> pair in numbersFrequency)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
