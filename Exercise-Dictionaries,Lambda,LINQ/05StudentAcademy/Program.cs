Dictionary<string, List<double>> grades = new();

int n = int.Parse(Console.ReadLine());

for (int i= 0; i < n; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!grades.ContainsKey(student))
    {
        grades.Add(student, new List<double>());
    }
    grades[student].Add(grade);
}
var excellent = grades.Where(kvp => kvp.Value.Average() >= 4.50);

foreach (var currentStudent in excellent)
{
    Console.WriteLine($"{currentStudent.Key} -> {currentStudent.Value.Average():f2}");
}

