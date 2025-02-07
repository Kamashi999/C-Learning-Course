/* Pętle oparte na While, muszą mieć inkrementacje zawartą w warstwie w której wywołujemy podane przez nas działania, inaczej
 * doświadczymy zjawiska tzw. Infinity Loop.
*/

int i = 1;
while (i <=10)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("\n Placeholder \n");

// Pętle while zazwyczaj używamy kiedy nie wiemy ile dokładnie pętli ma się wykonać.

//while (true)
//{
//    Console.WriteLine("Type sth [stop to exit]: ");
//    string input = Console.ReadLine();
//    if (input == "stop")
//    {
//        return;
//    }
//}

string savedPassword = "1234";
string inputPassword = "";

while (inputPassword != savedPassword)
{
    Console.WriteLine("Please, write your password: ");
    inputPassword = Console.ReadLine();
   
}

Console.WriteLine("Your password is correct! Welcome!");

/* Do while, jest to komenda która zawsze się wykona, nawet jeżeli warunek jest spełniony, na bazie powyższego kodu, wygląda
 * ona następująco. Dzięki takiemu zabiegowi mamy pewność że chociaż raz, blok do while się wykona.
*/

Console.WriteLine("\n Placeholder \n");

do
{
    Console.WriteLine("Please, write your password: ");
    inputPassword = Console.ReadLine();

} while (inputPassword != savedPassword);
