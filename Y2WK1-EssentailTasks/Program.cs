﻿while (true)
{
    Console.WriteLine("Which program would you like to run? \n1)What is next");
    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        Console.WriteLine("What are you currently doing?");
        string currentAction = Console.ReadLine();
    }
}