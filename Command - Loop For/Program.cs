// Pętle używane są aby nie pisać niepotrzebnie długiej linii kodu, gdzie można zawrzeć to w postaci pętli.

/* Pętla napisana poniżej wymienia nam liczby od 0 do 9, oznacza to że tak naprawdę funkcja w tej pętli, powtórzyłaby się łącznie
 * 10 razy.
*/

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n Placeholder \n");
// Podana pętla poniżej działa dokładnie tak samo, jednak może ona być łatwiejsza do zrozumienia

int i2 = 0;
for (; i2 < 10;)
{
    Console.WriteLine(i2);
    i2++;
}

// Pętle for stosuje się wtedy gdy wiemy mniej więcej ile powtórzeń chcemy uzyskać.
