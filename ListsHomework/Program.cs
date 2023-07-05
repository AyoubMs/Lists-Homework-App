

List<string> studentsList = new List<string>();

string? studentFirstName;

bool isValid;

do
{
    Console.Write("Enter a student name (or exit): ");
    studentFirstName = Console.ReadLine();
    isValid = int.TryParse(studentFirstName, out var dumbNumber);
    if (isValid)
    {
        Console.WriteLine("Please enter a valid number");
    }
    if (studentFirstName != "exit" && !isValid)
    {
        studentsList.Add(studentFirstName);
    }
    if (studentFirstName == "exit")
    {
        Console.WriteLine($"The students count is: {studentsList.Count}");
    }
} while (studentFirstName != "exit");


