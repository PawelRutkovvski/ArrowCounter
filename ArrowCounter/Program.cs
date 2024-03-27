using ArrowCounter;
using System.Runtime.CompilerServices;

Console.WriteLine("Welcome To Arrow Collector Program.");
Console.WriteLine("======================================");
Console.WriteLine("In this App You can add number of arrows (or any other bullets) " +
    "\r\n ...and then to see Your shooting statistics." +
    "\r\n Follow The Menu.");

bool CloseApp = false;

while (!CloseApp)
{
    Console.WriteLine("What You Want To Do? (Choose The Number): " +
        "\r\n 1. Add Number Of Arrows To The Memory." +
        "\r\n 2. Add Number Of Arrows To The File.txt." +
        "\r\n 3. Exit .");

    Console.WriteLine(" = = = = = ");
    var chooseFromMainMenu = Console.ReadLine();
    Console.WriteLine(" = = = = = ");

    switch (chooseFromMainMenu)
    {
        case "1":
            AddingArrowsToMemory();
            break;
        case "2":
            AddingArrowsToFile();
            break;
        case "3":
            CloseApp = true;
            break;
        default:
            Console.WriteLine("Please Check What You Have Chosen...");
            continue;
    }
}

static void EqupiemntDamage(object sender, EventArgs args)
{
    var infoInMemory = new TrainingToMemory();
}

static void AddingArrowsToMemory()
{
    var toMemory = new TrainingToMemory();
    toMemory.ArrowDamage += EqupiemntDamage;
    AddingArrows(toMemory);
    toMemory.ShowStatistics();
}



static void AddingArrowsToFile()
{
    var toFile = new TrainingToFile();
    toFile.ArrowDamage += EqupiemntDamage;
    AddingArrows(toFile);
    toFile.ShowStatistics();
}

static void AddingArrows(ITraining training)
{
    Console.WriteLine("You have lost an arrow. Remember to fix it or buy a new one.");
}

private static void TrainingToMemory()
{
    var inMemory = new TrainingToMemory();
    inMemory.ArrowDamage += TheArrowDamage;
    EnterArrow(inMemory);
    inMemory.ShowStatistics();
}

private static void TrainingToMemory()
{
    var inFile = new TrainingToFile();
    inFile.ArrowDamage += TheArrowDamage;
    EnterArrow(inFile);
    inFile.ShowStatistics();
}