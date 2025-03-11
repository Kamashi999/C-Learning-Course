﻿public abstract class Car // klasa bazowa (Abstrakcja)
{
    public int Year { get; set; }

    public int HorsePower { get; set; }
}


public class VW : Car // Klasa VW dziedziczy właściwości z klasy Car
{
    public VW() // klasa pochodna
        {
            Year = 2020;
            HorsePower = 150;
        }
}

public class Audi
{
    public Car Car { get; set; } // kompozycja
    public Audi()
    {
        Car.Year = 2019;
        Car.HorsePower = 200;
    }
}


// abstrakcja - klasa oznaczona tak, nie może mieć żadnej instancji (nie istnieje / Nie można odwołać się Car auto = new Car())

// kompozycja - działa podobnie jak dziedziczenie, tylko wtedy inicjilizujemy klase bazową wewnątrz klasy pochodnej.

// hermetyzacja:



public class Car2
{
    private int year;
    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            if (value > 2000 && value < 2025)

                year = value;

            throw new Exception("Rok musi być z przedziału 2000 - 2025");
        }
    }

    public int HorsePower { get; set; }
}

public class SomeClass
{
    public SomeClass()
    {
        var car = new Car2();

        car.Year = 2024;
        car.year = 1999; // Hermetyzacja jest potrzebna żeby dane wrażliwe były tylko dla wglądu w kodzie.

    }
}

// internal - działa tak, że wewnątrz działa tak jak public. Jeżeli public jest w projekcie 1, to widać go w projekcie 2. a Internala widać tylko w projekcie 1

// protected - pozwala na dostęp do pola tylko w klasie bazowej i klasach pochodnych.