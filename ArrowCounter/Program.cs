using ArrowCounter;

Console.WriteLine("Welcome To Arrow Collector Program.");
Console.WriteLine("======================================");
Console.WriteLine("In this App You can add number of arrows (or any other bullets) " +
    "\r\n ...and then to see Your shooting statistics." +
    "\r\n Follow The Menu.";

bool CloseApp = false;

while (!CloseApp)
{
    Console.WriteLine("What You Want To Do? (Choose The Number): " +
        "\r\n 1. Add Number Of Arrows To The Memory And To See Your Statistics." +
        "\r\n 2. Add Number Of Arrows To The File And To See Your Statistics." +
        "\r\n 3. Exit .");

    Console.WriteLine(" = = = = = ");
    var chooseFromMainMenu = Console.ReadLine();
    Console.WriteLine(" = = = = = ");

    switch (chooseFromMainMenu)
    {
        case "1":
            TrainingToMemory();
            break;
        case "2":
            TrainingToFile();
            break;
        case "3":
            CloseApp = true;
            break;
        default:
            Console.WriteLine("Please Check What You Have Chosen...");
            continue;
    }
}
//var employee = new EmployeeInFile("Paweł", "Rutkowski");
//employee.GradeAdded += EmployeeGradeAdded;

////jeśli odpali się event GradeAdded to uruchomi się dodana do niego metoda.
//void EmployeeGradeAdded(object sender, EventArgs args)
//{
//    Console.WriteLine("Dodano nową ocenę");
//}

//while (true)
//{
//    Console.WriteLine("Enter next grade of Your Employee: ");
//    Console.WriteLine("... or q to see statistics");

//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }
//}
//var statistics = employee.GetStatistics();
//Console.WriteLine();
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"AvgLetter: {statistics.AverageLetter}");