/* zmienna name, jako wartość typu string, działa jak tablica. Chociażby z wywołania całości mamy NAME, ale każda z liter
 * ma swego rodzaju numer porządkowy który nazywamy indexem. Możemy pobrać chociazby 1 z liter, musimy odnieść się do tego
 * tak jak do tablicy.
*/


string name = "NAME";
Console.WriteLine(name[0]);

Console.WriteLine("\n Placeholder \n");

// Tablice służą aby przechowywać wartości danego typu w jednym obiekcie.

// wewnątrz nawiasu [] przy new int[], podajemy w środku ilość elementów jaką zawierać będzie nasza tablica.

int[] numbers = new int[3];
numbers[0] = 12;
numbers[1] = 23;
numbers[2] = 34;

Console.WriteLine(numbers[2]);

Console.WriteLine("\n Placeholder \n");

// Innym sposobem jest również wypisanie w nawiasie {} elementów, wtedy zostaną one automatycznie przypisane do tablicy pod 0,1,2,...

string[] names = new string[]
{
    "Anna", "Andrzej", "Arkadiusz", "Aleksandra"
};

string[] names2 =
{
    "Anna", "Andrzej", "Arkadiusz", "Aleksandra"
};

Console.WriteLine(names[2]);

// Jeżeli chcemy sprawdzić ile elementów posiada nasza tablica, można skorzystać z komendy nazwa.Lenght

Console.WriteLine(names.Length);

/* Tablice są przydatne do używania, natomiast raz zdefiniowana tablica, niezbyt może być zmieniana. Są to raczej stałe obiekty,
 * gdzie ilość obiektów raczej nie powinna się zmieniać.
*/

