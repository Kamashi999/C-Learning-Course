public abstract class Animal
{
    public string Imie { get; set; }
    public string Wiek { get; set; }
    public string Rasa { get; set; }
    public string Plec { get; set; }

    public Animal(string imie, string wiek, string rasa, string plec)
    {
        Imie = imie;
        Wiek = wiek;
        Rasa = rasa;
        Plec = plec;
    }

    public abstract void WydajDzwiek();

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Imię: {Imie}, Wiek: {Wiek}, Rasa: {Rasa}, Płeć: {Plec}");
    }
}

public class Dog : Animal
{
    public Dog(string imie, string wiek, string rasa, string plec)
        : base(imie, wiek, rasa, plec) { }

    public override void WydajDzwiek()
    {
        Console.WriteLine("Hau! Hau!");
    }
}

class Program
{
    static void Main()
    {
        Animal pies = new Dog("Reksio", "5", "Owczarek", "Samiec");
        pies.WyswietlInformacje();
        pies.WydajDzwiek();
    }
}
