using Y2WK1_EssentailTasks;

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
        ImperialHeight impHeight = GetImperialHeight();

        impHeight.GetHeightInInches();

        double heightInMeters = FindHeightInMeters(impHeight);
        Console.WriteLine(heightInMeters.ToString());

        Console.WriteLine(FindHeight2DP(heightInMeters));
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