
Dictionary<string, List<string>> initials = new();

string command = Console.ReadLine();

while(command != "End")
{
    string[] inputArray = command.Split(" -> ");
    string company = inputArray[0];
    string employeeID = inputArray[1];

    if (!initials.ContainsKey(company))
    {
        initials.Add(company, new List<string>());
    }

    if (!initials[company].Contains(employeeID))
    {
        initials[company].Add(employeeID);
    }
    command = Console.ReadLine();
}

foreach(KeyValuePair<string, List<string>> currentInitials in initials)
{
    Console.WriteLine(currentInitials.Key);
    foreach(string currentEmployeeID in currentInitials.Value)
    {
        Console.WriteLine($"-- {currentEmployeeID}");
    }
}