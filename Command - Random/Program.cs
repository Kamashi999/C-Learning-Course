
/* Nowe zmienne takie jak Random, deklarujemy nazwą zmiennej, "=", oraz formułą "new (zmienna)()". W środku "()" można wpisać jakieś liczby
które zostaną przyjęte jako ziarno i kolejne liczby będą tworzone na podstawie tego ziarna

Pozostawienie pola pustego, powoduje tworzenie się losowej liczby.
 */

Random rand = new Random();

/* Podanie wartości w () powoduje górny zakres w którym liczba losowa może się wylosować (0-10). Jeżeli chcemy dokładny zakres np 10-20, zapisujemy to
w postaci (10,21).      
*/

int randInt = rand.Next(11);
double randDouble = rand.NextDouble();
Console.WriteLine(randInt);
Console.WriteLine(randDouble);

// Takim sposobem losujemy liczbę z przecinkiem mięzdy 10 a 30.

int min = 10;
int max = 30;
double randDoubleRange = rand.NextDouble() * (max - min) + min;
Console.WriteLine(randDoubleRange);