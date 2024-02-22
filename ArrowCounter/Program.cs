using ArrowCounter;

Console.WriteLine("Welcome To Arrow Collector Program.");
Console.WriteLine("======================================");
Console.WriteLine("In this App You can add number of arrows (or any other bullets)\n" + 
    " ...and then to see Your shooting statistics." + 
    " ... follow the menu.");

//bool CloseApp = false;

//while (!CloseApp)
//{
//    Console.WriteLine();

//}
var employee = new EmployeeInFile("Paweł", "Rutkowski");
employee.GradeAdded += EmployeeGradeAdded;

//jeśli odpali się event GradeAdded to uruchomi się dodana do niego metoda.
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("Enter next grade of Your Employee: ");
    Console.WriteLine("... or q to see statistics");

    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");