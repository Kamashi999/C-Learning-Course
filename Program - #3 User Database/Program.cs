


Console.WriteLine("Welcome in my first Database program! Let's login.");

// loop start
string user1 = "QWERTY";
string user2 = "QAZWSX";

bool while1 = true;
while (while1) {
    Console.Clear();
Console.WriteLine($"Choose account. \n 1 - {user1} \n 2 - {user2}");
if (Int32.TryParse(Console.ReadLine(), out int input) && input == 1 || input == 2) {
        while1 = false;

        switch (input)
        {
            case 1: Console.WriteLine("Please, enter the password:");
                string passwordInput = Console.ReadLine();
                while (passwordInput != "1234")
                {
                    Console.WriteLine("Wrong password! Try again!");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine($"Hello {user1}! Choose option:\n 1 - Account info\n 2 - Date");
                
                bool caseWhile = true;
                while (caseWhile) { 
                if (Int32.TryParse(Console.ReadLine(), out int caseInput) && caseInput > 0 && caseInput < 3) {
                    switch (caseInput)
                        {
                            case 1: 
                                Console.WriteLine($"Username: {user1}");
                                Console.WriteLine($"Created: 11.02.2019");
                                Console.WriteLine($"Password: ****");
                                Console.WriteLine($"Date of birth: 12.12.2002");
                                break;
                            case 2: 
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine("Wanna go back?\n (1 - Yes / 2 - No)");
                                if (Console.ReadLine() == "1")
                                {
                                    caseWhile = true;
                                } else
                                {
                                    Console.WriteLine("Bye Bye!");
                                    Console.ReadKey();
                                    return;
                                }
                                break;
                        }
                    }
                }
                
                Console.WriteLine("test");
                break;
            case 2: Console.WriteLine("2");
                break;
                
        }
} else
    {
        Console.WriteLine("You should choose between 1-2!");
        Console.ReadKey();
    }
}
