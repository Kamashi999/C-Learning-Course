

Console.WriteLine("Press any key to continue...");
void GreetingFunction()
{
    bool welcomeWhile = true;
    while (welcomeWhile)
    {
        Console.Clear();
        Console.WriteLine("Hello in notepad! \nWhat would you like to Note?\n1 - Text\n2 - Numbers");

        string lobbyOutput = Console.ReadLine();

        switch (lobbyOutput)
        {
            case "1":
                welcomeWhile = false;
                NotepadForText();
                break;
            case "2":
                welcomeWhile = false;
                NotepadForNumbers();
                break;
            default:
                Console.WriteLine("Choose between 1-2!");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    
    }
}

void NotepadForNumbers()
{
    List<int> notepadForNumbers = new List<int>();

    bool notepadBody = true;

    while (notepadBody)
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

            Console.WriteLine("Choose option.\n1 - Repeat.\n2 - show Notepad.\n3 - Close Program.\n4 - Go Back.");
            string lobbyOutput = Console.ReadLine();

            switch (lobbyOutput)
            {
                case "1":
                    Console.WriteLine("Lets go back then!");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    lobbyBool = false;
                    break;
                case "2":
                    foreach (int numbers in notepadForNumbers)
                    {
                        Console.Write(numbers + " ");
                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Thanks for spending your time with me!");
                    return;
                case "4":
                    lobbyBool = false;
                    notepadBody = false;
                    break;
                default:
                    Console.WriteLine("Choose between 1-3!");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

void NotepadForText()
{
    List<string> notepadForText = new List<string>();

    bool notepadBody = true;

    while (notepadBody)
    {

            Console.WriteLine("Enter your text please: ");
            string outputText = Console.ReadLine();
            notepadForText.Add(outputText);

        bool lobbyBool = true;

        while (lobbyBool)
        {

            Console.WriteLine("Choose option.\n1 - Repeat.\n2 - show Notepad.\n3 - Close Program.\n4 - Go back.");
            string lobbyOutput = Console.ReadLine();

            switch (lobbyOutput)
            {
                case "1":
                    Console.WriteLine("Lets go back then!");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    lobbyBool = false;
                    break;
                case "2":
                    foreach (string text in notepadForText)
                    {
                        Console.Write(text + "\n");
                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("Thanks for spending your time with me!");
                    return;
                case "4":
                    lobbyBool = false;
                    notepadBody = false;
                    break;
                default:
                    Console.WriteLine("Choose between 1-3!");
                    Console.WriteLine("\nPress any key to continue...");
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
                lobbyBoolOutput = false;
                NotepadForText();
                break;
            case "2":
                lobbyBoolOutput = false;
                NotepadForNumbers();
                break;
            default:
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }
}



GreetingFunction();