// Listy działają na podobnej zasadzie co tablice, ale są one bardziej elastyczne.

string[] names =
{
    "Anna", "John", "Mark"
};

List<string> names2 = new List<string>();

// Aby dodać do listy jakieś wartości, posługujemy się komendą "nazwa listy".Add("");

names2.Add("John");
names2.Add("Victoria");
names2.Add("Anna");
names2.Add("Andrew");
names2.Add("John");

// Jednak przy usuwaniu, jeżeli podamy np John'a, zostanie usunięty tylko pierwszy z góry.

names2.Remove("John");

// Przy dodaniu "At", podajemy index wybranego przez nas imienia które ma zniknąć

names2.RemoveAt(2);

foreach (string name in names2)
{
    Console.WriteLine(name);
}

// W przeciwieństwie do tablic, w listach do policzenia ilości w tym przypadku imion korzystamy z .Count

Console.WriteLine(names2.Count);
Console.WriteLine(names2[2]);