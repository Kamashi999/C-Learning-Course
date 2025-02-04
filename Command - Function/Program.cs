/* Funckje, są opisywane również terminologią "dry" - "Dont repeat yourself", chodzi w tym o to że jeżeli musimy powtórzyć
 * daną funkcje X razy, nie warto przepisywać jej X razy, tylko stworzyć rzeczywistą funkcję której odnośnik podajemy
 * w postaci nazwy. 
*/

// Funkcję mogą przyjąć standardowe zmienne takie jak int, string, ..., ale również mogą przyjąć zmienną void.

// Umowną zasadą zapisywania Funkcji, jest zapisywanie początku każdego członu dużą literą!

// W funkcjach Void nie jest wymagana sekwencja "return;", natomiast można użyć tej opcji aby zakończyć działanie funkcji.
void DisplayDate()
{
    Console.WriteLine(DateTime.Now);
}

// Podanie nazwy funckji pozwoli nam ją wywołać.

DisplayDate();

// Każda zmienna inna niż void, która będzie nam zwracać jakąś wartość, musimy dodać "return" i później co chcemy zwrócić.

// Dodanie return na samym końcu programu, powoduje ustawienie wywołanie danej sekwencji jeżeli wszystko inne zawiedzie.

/* Również możemy dodać po if, else, w którym zawrzemy return (nazwa funkcji); spowoduje to powracanie do funckji aż warunek if
 * nie zostanie spełniony
*/

// Przeciążanie funkcji - możemy tworzyć funkcje o takiej samej nazwie, ale z inną sygnaturą, czyli zawartymi parametrami w ().
float GetNumericInput()
{
    Console.Write("Provide float input: ");
    if (float.TryParse(Console.ReadLine(), out float a))
    {
        return a;
    }
    else
    {
        return GetNumericInput();
    }

}

Console.WriteLine(GetNumericInput() * 2);