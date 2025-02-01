using System.Data;

Console.WriteLine("Witaj w moim pierwszym programie! Wybierz 1 z poniższych opcji aby kontynuować!");

back2:

Console.WriteLine("1 - Wylosuj liczbę");
Console.WriteLine("2 - Dodawanie");
Console.WriteLine("3 - Odejmowanie");
Console.WriteLine("4 - Przywitanie");

back1:

string input = Console.ReadLine();



switch (input)
{
    case "1":
        Console.Clear();
        Random rand = new Random();
        int number = rand.Next(101);
        Console.WriteLine(number);
        Console.ReadKey();
        break;
    case "2":
        Console.Clear();
    numA:
        Console.Write("Podaj liczbę A: ");
        if (int.TryParse(Console.ReadLine(), out int numberA))
        {
        numB:
            Console.Write("Podaj liczbę B: ");
            if (int.TryParse(Console.ReadLine(), out int numberB))
            {
                int result = numberA + numberB;
                Console.WriteLine($"Twoja liczba wynosi {result}!");
            }
            else { Console.WriteLine("Podaj liczbę!"); goto numB; }

        }
        else { Console.WriteLine("Podaj liczbę!"); goto numA; }
        Console.ReadKey();
        break;
    case "3":
        Console.Clear();
    numDecA:
        Console.Write("Podaj liczbę A: ");
        if (int.TryParse(Console.ReadLine(), out int numberDecA))
        {
        numDecB:
            Console.Write("Podaj liczbę B: ");
            if (int.TryParse(Console.ReadLine(), out int numberDecB))
            {
                int resultDec = numberDecA - numberDecB;
                Console.WriteLine($"Twoja liczba wynosi {resultDec}!");
            }
            else { Console.WriteLine("Podaj liczbę!"); goto numDecB; }

        }
        else { Console.WriteLine("Podaj liczbę!"); goto numDecA; }
        Console.ReadKey();
        break;
    case "4":
        Console.Clear();
        Console.Write("Podaj swoje imię: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Witaj {name}, miło Cię poznać!");
        Console.ReadKey();
        break;
    default:
        Console.WriteLine("Wybierz liczbę od 1-3!");
        goto back1;
        break;
}

Console.Clear();
Console.Write("Czy chcesz powtórzyć? TAK/NIE: ");

string input2 = Console.ReadLine();

switch (input2)
{
    case "TAK":
        goto back2;
    default:
        Console.WriteLine("Dziękuję za skorzystanie z mojego programu!");
        Console.ReadKey();
        Console.Clear();
        Console.ReadKey();
        break;
}
