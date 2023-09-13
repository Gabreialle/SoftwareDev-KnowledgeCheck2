using SoftwareDev_KnowledgeCheck2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Dog>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var Dog = new Dog();

    Console.WriteLine("Enter the value for Name");
    Dog.Name = Console.ReadLine();

    Console.WriteLine("Enter the value for Color");
    Dog.Color = Console.ReadLine();


    recordList.Add(new Dog() { Name = Dog.Name, Color = Dog.Color });
}

// Print out the list of records using Console.WriteLine()

foreach (var Dog in recordList)
    Console.WriteLine("Your dog is named " + Dog.Name + " and it is " + Dog.Color + " in color.");
