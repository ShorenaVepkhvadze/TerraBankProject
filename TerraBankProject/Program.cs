class LessonFour
{
    static void Main(string[] args) // შესვლის წერტილის მეთოდი, მხოლოდ ერთი
    {
        //getSum(); // function call, ფუნქციის გამოძახება
        getParams(10, 5, "Sum"); // პარამეტრის გადაცემა
        Console.WriteLine();
        int sum = getSum(14, 1);
        Console.WriteLine(sum);
        Console.WriteLine(getSum(5, 10));
        Console.WriteLine();
        Console.WriteLine(getMessage());
    }

    static void getParams(int x, int y, string name) // პარამეტრების მიღება
    {
        Console.WriteLine(name + " " + (x + y));
        // void - ეს მეთოდი არაფერს აბრუნებს
    }

    static int getSum(int x, int y) // ორი პარამეტრი | int - აბრუნებს ინტეჯერის ტიპის 
                                    // მნიშვნელობას
    {
        return x + y;
    }

    static string getMessage()
    {
        string message = "This method returns a message";

        return message;

        // return "This method returns a message";
    }

    static void getSum() // void - მნიშვნელობა, რომელსაც მეთოდი აბრუნებს
                        // () პარამეტრები
    {
        // Escape Sequences only in Strings
        Console.WriteLine("\n\n\n\t\aNEW MESSAGE\rThis is too\n\n\n");
        Console.WriteLine("This is very long message...");
        Console.WriteLine("Welcome to our \"home\"");
        Console.WriteLine("This is a \\template\\");
        Console.WriteLine("This is a \'a\' symbol");

        Console.WriteLine();
        // logical operators, if, else if, switch
        int accountNumberOne = 113;
        int accountNumberTwo = 90;

        // ==, >, <, <=, >=, !=
        // boolean logical variables: true & false

        // if
        if (accountNumberOne == accountNumberTwo)
        { // block start
            Console.WriteLine("accountNumberOne equals to accountNumberTwo");
        } // block end

        //if (accountNumberOne != accountNumberTwo)
        //{
        //    Console.WriteLine("accountNumberOne does not equal to accountNumberTwo");
        //}

        if (accountNumberOne > accountNumberTwo)
        {
            Console.WriteLine("accountNumberOne is greater than accountNumberTwo");
        }

        if (accountNumberOne < accountNumberTwo)
        {
            Console.WriteLine("accountNumberOne is less than accountNumberTwo");
        }

        Console.WriteLine();
        int number1 = 9;
        int number2 = 1;

        if (number1 >= number2)
        {
            Console.WriteLine("Number1 is equal or greather than number2");
        }

        if (number1 <= number2)
        {
            Console.WriteLine("Number1 is equal or less than number2");
        }

        Console.WriteLine();

        int myAge = 34;
        int friendsAge = 35;

        // if else
        if (myAge >= friendsAge)
        {
            Console.WriteLine("Don't joke on my age...");
        }
        else
        {
            Console.WriteLine("Ok. You can joke...");
        }

        // else if
        if (myAge < 18)
        {
            Console.WriteLine("You are not an adult");
        }
        else if (myAge >= 18)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("I don't understand your age...");
        }

        Console.WriteLine();

        // if (true), პირობითი არა !
        bool married = false;

        if (married) // if (true) იგივეა, რაც if (married == true)
        {
            Console.WriteLine("You are married...");
        }
        else
        {
            Console.WriteLine("You are not married");
        }

        Console.WriteLine();

        married = true;

        if (!married) // ამოვატრიუალოთ და ჯერ შეამოწმოს უარყოფაზე, married == false
        {
            Console.WriteLine("You are not married");
        }
        else
        {
            Console.WriteLine("You are married");
        }

        Console.WriteLine();

        if (married) // თუ ჭეშმარიტია გამოიყვანე პირველი სტრიქონი და სხვა დანარჩენი
                     // თუ არა, მაშინ გამოტოვე პირველი სტრიქონი და გამოიყვანე სხვა ყველა
                     // დანარჩენი
            Console.WriteLine("Archil is Married...");
        Console.WriteLine("Archil is not married");

        string apple = "Apple"; // case-sensitive
        string watermelon = "Watermelon";
        string cherry = "Cherry";
        string grape = "Grape";

        string upperCase = "UPPERCASE";
        string toLowerCase = upperCase.ToLower(); // ქვედა რეგისტრი, ToUpper()
        Console.WriteLine(toLowerCase);


        Console.WriteLine("Please, enter one of the following fruits");
        Console.Write("Apple, Watermelon, Cherry, Grape: ");
        string enteredFruit = Console.ReadLine();

        // ლოგიკური ან (||) და ლოგიკური და (&&)
        // string შედარება ხდება Equals() მეთოდის მეშვეობით
        // შესადარებელი სტრიქონი.Equals(სტრიქონი/ცვლადი)

        if (enteredFruit.Equals(apple) || enteredFruit.Equals(grape)) // ლოგიკური ან
        {
            Console.WriteLine("You have entered eigher apple or grape");
        }
        else if (enteredFruit.Equals(cherry))
        {
            Console.WriteLine("You have entered cherry...");
        }
        else if (enteredFruit.Equals(watermelon))
        {
            Console.WriteLine("You have entered a watermelon.");
        }
        else
        {
            Console.WriteLine("You have entered a wrong fruit...");
        }

        Console.WriteLine();

        int studentArchilAge = 17;
        int studentTamunaAge = 18;

        if (studentArchilAge >= 18 && studentTamunaAge >= 18)
        {
            Console.WriteLine("Both students are adults.");
        }
        else
        {
            Console.WriteLine("One or both students are not adults");
        }

        Console.WriteLine();

        // switch
        Console.Write("Please enter the following fruits.\nApple, Grape, Watermelon: ");
        string fruits = Console.ReadLine();

        switch (fruits) // char, int, string; თავი შევიკავო float, double, decimal
        {
            case "Apple": // (if) if (apple || / && grape) -> does not work
                Console.WriteLine("This is an apple");
                break;
            case "Grape": // else if
                Console.WriteLine("This is a grape");
                break;
            case "Watermelon": // else if
            case "Melon": // if (watermelon || melon)
                Console.WriteLine("You have chosen Watermelon or Melon");
                break;
            default: // else {}
                Console.WriteLine("You have entered the wrong fruit...");
                break;
        }

        // nested logical operatos
        bool notMarried = true;
        int currentAge = 34;

        if (notMarried) // if (notMarried == true && currentAge <= 34)
        {
            if (currentAge < 18)
            {
                Console.WriteLine("It is too yearly for the marriage...");
            }
            else if (currentAge >= 18 && currentAge <= 45)
            {
                Console.WriteLine("It is ok to start thinking about family");
            }
            else if (currentAge >= 45 && currentAge < 65)
            {
                Console.WriteLine("It is definitely time to think about family");
            }
            else if (currentAge > 65)
            {
                Console.WriteLine("Pension time...");
            }
        }
        else
        {
            Console.WriteLine("You are already married.");
        }

        // ternary operator () ? option1 : option2
        int numb1 = 10;
        int numb2 = 20;
        int sum = (numb1 > numb2) ? numb1 : numb2; // if (numb1 > numb2) {sum = numb1}
                                                   // else {sum = numb2};

        Random random= new Random();
        random.Next();
    }
}