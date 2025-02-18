


void GreetingFunction()
{
    bool welcomeWhile = true;
    while (welcomeWhile)
    {
        Console.Clear();
        Console.WriteLine("Hello in notepad! \nWhat would you like to Note? 1 - Text \n 2 - Numbers (Only Avaiable rn)");
    }
}

void NotepadForNumbers()
{
    List<int> notepadForNumbers = new List<int>();

    while (true)
    {

        bool wrongNumber = true;

        while (wrongNumber)
        {
            Console.WriteLine("Enter your number please: ");
            if (Int32.TryParse(Console.ReadLine(), out int result))
            {
                notepadForNumbers.Add(result);
                wrongNumber = false;
            }
            else
            {
                Console.WriteLine("I told you to write number! Go back!");
            }
        }

        bool lobbyBool = true;

        while (lobbyBool)
        {

            Console.WriteLine("Choose option.\n1 - Repeat.\n2 - show Notepad.\n3 - Close Program.");
            string lobbyOutput = Console.ReadLine();

            switch (lobbyOutput)
            {
                case "1":
                    Console.WriteLine("Lets go back then!");
                    Console.ReadKey();
                    lobbyBool = false;
                    break;
                case "2":
                    foreach (int numbers in notepadForNumbers)
                    {
                        Console.Write(numbers + " ");
                    }
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Thanks for spending your time with me!");
                    return;
                default:
                    Console.WriteLine("Choose between 1-3!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

void ChooseOptionFunction()
{
    bool lobbyBoolOutput = true;

    while (lobbyBoolOutput)
    {

        string lobbyOutput = Console.ReadLine();

        switch (lobbyOutput)
        {
            case "1":
                break;
            case "2":
                lobbyBoolOutput = false;
                NotepadForNumbers();
                break;
            default:
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }
}

Console.Clear();
Console.WriteLine("Hello in notepad! \nWhat would you like to Note?\n 1 - Text \n 2 - Numbers (Only Avaiable rn)");
ChooseOptionFunction();

