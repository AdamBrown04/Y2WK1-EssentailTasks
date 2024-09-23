while (true)
{
    Console.WriteLine("Which program would you like to run? \n1)What is next \n2)Height functions");
    int option = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    if (option == 1)
    {
        Console.WriteLine("What are you currently doing?");
        string currentAction = Console.ReadLine().ToLower();
        WhatIsNext(currentAction);
    }
    else if(option == 2)
    {
         Console.WriteLine("What is your height");

        Console.WriteLine("Feet: ");
        int hFeet = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Inches: ");
        int hInches = Convert.ToInt32(Console.ReadLine());
    }
}


static void WhatIsNext(string currentAction)
{
    switch (currentAction) 
    {
        case "shower":
            Console.WriteLine("have breakfast");
        break;
        case "have breakfast":
            Console.WriteLine("program");
            break;
        case "program":
            Console.WriteLine("play games");
            break;
        case "play games":
            Console.WriteLine("make dinner");
            break;
        case "make dinner":
            Console.WriteLine("shower");
            break;
    }

}