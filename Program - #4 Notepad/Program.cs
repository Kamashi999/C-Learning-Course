
List<int> notepadForNumbers = new List<int>();

void GreetingFunction()
{
    bool welcomeWhile = true;
    while (welcomeWhile)
    {
        Console.Clear();
        Console.WriteLine("Hello in notepad! \nWhat would you like to Note? 1 - Text / 2 - Numbers");
        string welcomeOutput = Console.ReadLine();
        if (welcomeOutput == "1" || welcomeOutput == "2")
        {
            welcomeWhile = false;
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("choose between 1-2!");
            Console.ReadKey();
        }
    }
}

void NotepadForNumbers()
{


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
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Lets go back then!");
                Console.ReadKey();
                lobbyBool = false;
            }
            else if (Console.ReadLine() == "2")
            {
                foreach (int numbers in notepadForNumbers)
                {
                    Console.WriteLine(numbers);
                }
                Console.ReadKey();
            }
            else if (Console.ReadLine() == "3")
            {
                Console.WriteLine("Thanks for spending your time with me!");
                return;
            }
        }
    }
}

NotepadForNumbers();