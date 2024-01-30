string command = Console.ReadLine();
List<StudentInfo> students = new List<StudentInfo>();

 while (command != "end")
{
    string[] studentData = command.Split(" ");
    string firstName = studentData[0];
    string lastName = studentData[1];
    int age = int.Parse(studentData[2]);
    string homeTown = studentData[3];

    StudentInfo currentStudent = new StudentInfo(firstName,
        lastName,
        age,
        homeTown);

    students.Add(currentStudent);

    command = Console.ReadLine();
}

 string targetCity = Console.ReadLine();

List<StudentInfo> filteredStudents = students.Where(x => x.HomeTown
== targetCity).ToList();

foreach (StudentInfo student in filteredStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
}
public class StudentInfo
{
    public StudentInfo(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

}
