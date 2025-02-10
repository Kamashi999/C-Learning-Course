
//int AddOnePlusOne()
//{
//	int a = 1;
//	int result = a + a;
//	return result;
//}

//while (true)
//{
//    Console.WriteLine("Hello, choose option \n 1 - addition 1+1");

//    string input = Console.ReadLine();

//    switch (input)
//    {
//        case "1":
//            Console.Clear();
//            Console.WriteLine($"Your number = {AddOnePlusOne()}");
//            break;
//        default:
//            Console.WriteLine("I told you to choose between 1-1!");
//            Console.ReadKey();
//            Console.Clear();
//            continue;
//    }
//    Console.ReadKey();

//    bool repeatWhile2 = true;
//    while (repeatWhile2)
//    {
//        Console.Clear();
//        Console.WriteLine("wanna repeat? \n 1 - Yes \n 2 - No");
//        string inputRepeat = Console.ReadLine();
//        if (inputRepeat == "1")
//        {
//            Console.WriteLine("Alright, let's go then!");
//            Console.ReadKey();
//           repeatWhile2 = false;
//            Console.Clear();
//        } else if (inputRepeat == "2")
//        {
//            return;
//        } else
//        {
//            Console.Clear();
//            Console.WriteLine("Sorry, I told you to choose between 1-2!");
//            Console.ReadKey();
//        }
//    }
//}


Console.WriteLine("Welcome, wanna try create your table?\nEnter amount of names u wanna have in your array:");

int arraySize = Int32.Parse(Console.ReadLine());

string[] names = new string[arraySize];


for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine("write first name: ");
    names[i] = Console.ReadLine();
}

Console.ReadKey();

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}



