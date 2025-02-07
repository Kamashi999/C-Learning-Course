Console.WriteLine("Hello, choose option \n 1 - addition 1+1");

string input = Console.ReadLine();

int AddOnePlusOne()
{
	int a = 1;
	int result = a + a;
	return result;
}



switch (input)
{
	case "1":
		Console.Clear();
		Console.WriteLine($"Your number = {AddOnePlusOne()}");
		break;
	default:
		break;
}