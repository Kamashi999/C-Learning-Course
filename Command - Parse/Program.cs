/* Tekst pobierany przez Console.ReadLine();, zawsze będzie w zmiennej string, dlatego trzeba ją przekonwertować komendą
 * Int32.Parse();, aby wartość tekstowa została zmieniona na wartośc liczbową 
 *** Int32 - Odpowiada standardowej zmiennej int!!!

 * Innym sposobem również jest korzystanie z Convert.ToInt32();
*/


Console.Write("Provide a number and I will double it: ");

string input = Console.ReadLine();
int number = int.Parse(input);
int result = number * 2;

Console.WriteLine(result);


/* Jeżeli nie jesteśmy pewni jaką liczbę wprowadzi użytkownik, możemy również skorzystać z innej opcji, Int32.TryParse(); */

Console.WriteLine("Provide a number and I will merge it with 2: ");

if (Int32.TryParse(Console.ReadLine(), out int resultt))
{
    Console.WriteLine(resultt + 2);
}
else
{
    Console.WriteLine("Wrong data provided.");
}