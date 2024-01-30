int n = int.Parse(Console.ReadLine());

List<int> firstInput = new List<int>();

List<int> secondInput = new List<int>();

for (int i = 0; i < n; i++)
{

    List<int> result = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

    int num1 = result[0];
    int num2 = result[1];

    if (i % 2 == 0)
    {
        firstInput.Add(num1);
        secondInput.Add(num2);
    }
    else
    {
        firstInput.Add(num2);
        secondInput.Add(num1);
    }
}
    Console.WriteLine(string.Join(" ", firstInput));
    Console.WriteLine(string.Join(" ", secondInput));


