using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox____2;

namespace Sandbox____2
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public string Race { get; set; }

        public int Age { get; set; }

        public Animal(string name, string race, int age)
        {
            Name = name;
            Race = race;
            Age = age;
        }
        public string ShowAnimalInfo()
        {
            return $"Pies nazywa się {Name}, jest rasy {Race} i ma {Age} lat.";
        }
    }
}
public class Dog : Animal
{
    // Konstruktor wywołujący bazowy konstruktor `Animal`
    public Dog(string name, string race, int age) : base(name, race, age)
    {
    }
}


