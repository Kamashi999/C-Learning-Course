start:

Console.Clear();
Console.WriteLine("Welcome in my calculator program!!! Whats you wanna do? \n 1 - addition \n 2 - substraction \n " +
    "3 - multiplication \n 4 - division");

backif:

if (Int32.TryParse(Console.ReadLine(), out int input) && input > 0 && input < 5) {
    Console.Clear();
}
else
{
    Console.WriteLine("Please, write correct number between 1-4!");
    goto backif;
}
float NumberA()
{
    float a;
    Console.WriteLine("Please, type your first number: ");
    if (float.TryParse(Console.ReadLine(), out a))
    {
        Console.Clear();
        return a;
    }
    return NumberA();
}

float NumberB()
{
    float b;
    Console.WriteLine("Please, type your second number: ");
    if (float.TryParse(Console.ReadLine(), out b))
    {
        Console.Clear();
        return b;
    }
    return NumberB();
}
float NumberADivision()
{
    float a;
    Console.WriteLine("Please, type your second number: ");
    if (float.TryParse(Console.ReadLine(), out a))
    {
        if (a == 0)
        {
            Console.WriteLine("You can't Division by 0!");
            return NumberADivision();
        }
        else
        {
            Console.Clear();
            return a;
        }
    }
    return NumberADivision();
}
float NumberBDivision()
{
    float b;
    Console.WriteLine("Please, type your second number: ");
    if (float.TryParse(Console.ReadLine(), out b))
    {
        if (b == 0)
        {
            Console.WriteLine("You can't Division by 0!");
            return NumberBDivision();
        }
        else
        {
            Console.Clear();
            return b;
        }
    } 
    return NumberBDivision();
}


float Addition()
{ 
    float addition = NumberA() + NumberB();
    return addition;
}

float Substraction()
{
    float substraction = NumberA() - NumberB();
    return substraction;
}

float Multiplication()
{
    float multiplication = NumberA() * NumberB();
    return multiplication;
}

float Division()
{
        float division = NumberADivision() / NumberBDivision();
        return division;
}



switch (input)
{
    case 1:
        Console.WriteLine($"Your number = {Addition()}");
        Console.ReadKey();
        break;
    case 2:
        Console.WriteLine($"Your number = {Substraction()}");
        Console.ReadKey();
        break;
    case 3:
        Console.WriteLine($"Your number = {Multiplication()}");
        Console.ReadKey();
        break;
    case 4:
        Console.WriteLine($"Your number = {Division()}");
        Console.ReadKey();
        break;
    default:
        Console.WriteLine("You shouldn't be there, go back!");
        goto backif;
}

repeat:

Console.Clear();
Console.WriteLine("Wanna repeat? \n 1 - Yes \n 2 - No");
if (Int32.TryParse(Console.ReadLine(), out int inputRepeat) && inputRepeat == 1)
{
    goto start;
}
else if (inputRepeat == 2)
{
    Console.WriteLine("Thanks for using my program!");
    Console.ReadKey();
} else
{
    Console.WriteLine("Please, write correct number between 1-2!");
    Console.ReadKey();
    goto repeat;
}

