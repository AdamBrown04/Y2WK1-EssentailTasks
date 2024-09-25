using System.ComponentModel.DataAnnotations;
using Y2WK1_EssentailTasks;

while (true)
{
    Console.WriteLine("Which program would you like to run? \n1)What is next \n2)Height functions \n3)string fun");
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
        ImperialHeight impHeight = GetImperialHeight();

        impHeight.GetHeightInInches();

        double heightInMeters = FindHeightInMeters(impHeight);
        Console.WriteLine(heightInMeters.ToString());

        Console.WriteLine(FindHeight2DP(heightInMeters));
    }
    else if(option == 3)
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        int lengthOfString = userInput.Length;
        string upperString = userInput.ToUpper();

        int numOfUpper = 0;
        int numOfLower = 0;
        int numOfDigits = 0;
        int numOfSpecial = 0;

        for(int x = 0; x < lengthOfString; x++)
        {
            if (userInput[x] == upperString[x] && !char.IsDigit(userInput[x]) && !char.IsPunctuation(userInput[x]) && userInput[x] != ' ')
            {
                numOfUpper++;
            }
            else if(!char.IsDigit(userInput[x]) && !char.IsPunctuation(userInput[x]) && userInput[x] != ' ')
            {
                numOfLower++;
            }
            if (char.IsPunctuation(userInput[x]) && userInput[x] != ' ')
            {
                numOfSpecial++;
            }
            if (char.IsDigit(userInput[x]) && userInput[x] != ' ')
            {
                numOfDigits++;
            }
        }

        string noWhitespace = userInput.Replace(" ", "");

        if (noWhitespace == userInput)
        {
            Console.WriteLine($"There are: \n{lengthOfString} charcters \n{numOfLower} lower case letters \n{numOfUpper} upper case letters \n{numOfDigits} numbers \n{numOfSpecial} special characters \nThere are not any spaces");
        }
        else
        {
            Console.WriteLine($"There are: \n{lengthOfString} charcters \n{numOfLower} lower case letters \n{numOfUpper} upper case letters \n{numOfDigits} numbers \n{numOfSpecial} special characters \nThere are spaces");
        }
    }
}

//task 1
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
//task 2
static ImperialHeight GetImperialHeight()
{
    ImperialHeight imperialHeight = new ImperialHeight();
    Console.WriteLine("What is your height");

    Console.Write("Feet: ");
    int hFeet = Convert.ToInt32(Console.ReadLine());

    Console.Write("Inches: ");
    int hInches = Convert.ToInt32(Console.ReadLine());

    imperialHeight.GetFeet(hFeet);
    imperialHeight.GetInches(hInches);

    return imperialHeight;
}

static double FindHeightInMeters(ImperialHeight iHeight)
{
    double meters = Convert.ToDouble(iHeight.ViewHeightInInches()) / 39.37;
    return meters;
}

static string FindHeight2DP(double dHeight)
{
    string sHeight = dHeight.ToString();
    string thirdDec = sHeight[4].ToString();
    int roundingNumber = Convert.ToInt32(thirdDec);
    if (roundingNumber > 5)
    {
        sHeight = sHeight.Substring(0, 4);
        double height = Convert.ToDouble(sHeight);
        height = height + 0.01;
        sHeight = height.ToString();

    }
    else if(roundingNumber < 5)
    {
        sHeight = sHeight.Substring(0, 4);
    }

    return sHeight;
}
//task 3