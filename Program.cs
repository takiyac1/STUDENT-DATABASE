string[] studentNames = new string[] { "Bobby", "Crystal", "Johnny"};

string[] favFood = new string[] {"Pizza", "Salad", "Soup"};

string[] homeTown = new string[] {"Phoenix", "Detroit", "Charlotte"};



for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine("Please select a student by number.. Options are 1-3.");
    int name = int.Parse(Console.ReadLine());
    if (name < 1 || name > studentNames.Length)
    { Console.WriteLine("Invalid number, try again."); }
    Console.WriteLine($"{studentNames[name - 1]}");

    Console.WriteLine($"What do you want to know about {studentNames[name - 1]}? hometown or favoritefood?");
    string info = Console.ReadLine();
    if (info != "hometown" || info != "favoritefood")
    {
        Console.WriteLine("Invalid input.");
        Console.WriteLine($"What do you want to know about {studentNames[name - 1]}? hometown or favoritefood?");
       
    }

  string infos = Console.ReadLine();
    Console.WriteLine($"{infos[name -1]}");

    Console.WriteLine("Would you like to learn about another student? (y/n)");
    string end = Console.ReadLine();

   if (end == "y")
    { continue; }
     else
    { return; }
}