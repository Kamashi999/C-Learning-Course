
/* Warunek If działa jak zmienna bool (true/false), dodatkowo zmienna Console.ReadLine(); czytana jest jako wartość
 * string dlatego musimy podać ją w postaci "przykładowy tekst". Else if pozwala dodać nam dodatkowy warunek który wyświetla inną
 * wiadomość. Natomiast else zamyka nam całą funkcje i jest wywoływana jeżeli żadne z warunków nie zostanie spełnione.
*/



Console.Write("Podaj Pin: ");
string input = Console.ReadLine();

if (input == "1234")
{
    Console.WriteLine("Pin Correct.");
}
else if (input == "0000")
{
    Console.WriteLine("MasterKey has been used.");
}
else
{
    Console.WriteLine("Pin Incorrect. \n \n");
}

/* Funkcja warunkowa jest również jak cały kod, czytana od góry do dołu. Trzeba pamiętać o zawarciu w dobrej kolejności
 * sprawdzania w tym przypadku ilości punktów. Jeżeli wczesnie wkradłoby się if (points < 20), a później if (points < 15),
 * wtedy warunek nawet jeżeli liczba wynosiłaby 14 zostałoby to użyte w warunku (points < 20), kiedy powinien zostać spełniony
 * (points < 15).
*/

Random rand = new Random();
int points = rand.Next(0, 21);
int mark;

if (points < 10)
{
    mark = 2;
}
else if (points < 11)
{
    mark = 3;
}
else if (points < 15)
{
    mark = 4;
}
else if (points < 18)
{
    mark = 5;
}
else
{
    mark = 6;
}
Console.WriteLine(mark);