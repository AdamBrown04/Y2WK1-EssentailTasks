using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Y2WK1_EssentailTasks;

while (true)
{
    Console.WriteLine("Which program would you like to run? \n1)What is next \n2)Height functions \n3)string fun \n4)Timestables \n5)Amount of 2&7s between 0 and 1,000,000 \n6)statistics of a list");
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
    else if(option == 4)
    {
        Console.Write("Enter a number you want the multple up to 12 of: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 13; i++) 
        {
            Console.Write($"{i*number}\n");
        }
    }
    else if(option == 5)
    {
        int numOfValuesFound = 0;

        for(int x = 0; x < 1000000; x++)
        {
            string value = x.ToString();
            for(int i = 0; i < value.Length; i++)
            {
                if (Convert.ToInt32(value[i]) == 50 || Convert.ToInt32(value[i]) == 55)
                {
                    numOfValuesFound++;
                    break;
                }
               
            }
        }
        Console.WriteLine($"There are {numOfValuesFound} numbers with either a 2 or 7 in it");
    }
    else if(option == 6)
    {
        List<float> userInputs = new List<float>();

        while (true)
        {
            Console.Write("Enter any number: ");
            float input = Convert.ToSingle(Console.ReadLine());
            if(input == 0)
            {
                break;
            }
            else
            {
                userInputs.Add(input);
            }
        }

        float max = 0;
        float min = 0;
        float average = 0;
        float total = 0;
        bool isFirstNumber = true;

        for(int x = 0; x < userInputs.Count; x++)
        {
            if (userInputs[x] > max)
            {
                max = userInputs[x];
            }
            if (userInputs[x] < min || isFirstNumber)
            {
                min = userInputs[x];
                isFirstNumber = false;
            }
            total = total + userInputs[x];
        }

        average = total / userInputs.Count;

        Console.WriteLine($"Statistics: \n{max} is the highest number \n{min} is the lowest number \n {total} is the total sum \n{average} is the mean average");
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