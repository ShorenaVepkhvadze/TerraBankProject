class HomeworkFive
{
    static void Main(string[] args) // შესვლის წერტილის მეთოდი, მხოლოდ ერთი
    {
        // Game
        startGame();
    }

    static void startGame()
    {
        welcomingMessage();

        int randomNumber = getRandomNumber();
        int usersNumber;
        // int counter = 1;

        // უნდა შევადაროთ ორი რიცხვი
        // თუ გამოვიცანი, მაშინ მოგება
        // თუ ვერ გამოვიცანი და ჩემი რიცხვი ჩაფიქრებულზე ნაკლებია - შესაბამისი შეტყობინება
        // თუ ვერ გამოვიცანი და ჩემი რიცხვი ჩაფიქრებულზე მეტია - შესაბამისი შეტყობინება

        // ფუნქციონალის დამატება - უნდა მქონდეს სამი ცდა
        // მესამე ცდის ბოლოს, თუ ვერ გამოვიცანი, მაშინ წავაგე
        // თუ გამოვიცანი - მოვიგე

        //while(counter <= 3)
        //{
        //usersNumber = enterNumber();

        //if (randomNumber == usersNumber)
        // {
        //    Console.WriteLine("You have WON!");
        //     return; // ყველაფერი დასრულდება გაგრძელების გარეშე
        //}
        // else if (randomNumber > usersNumber && counter != 3)
        // {
        //     Console.WriteLine("Your number is lower than random number.");
        // }
        // else if (randomNumber < usersNumber && counter != 3)
        // {
        // Console.WriteLine("Your number is higher than random number.");
        // }
        // counter++;
        // }

        //for (int counter = 1; counter <= 3; counter++)
        // {
        // usersNumber = enterNumber();

        // if (randomNumber == usersNumber)
        //{
        // Console.WriteLine("You have WON!");
        //  return; // ყველაფერი დასრულდება გაგრძელების გარეშე
        // }
        // else if (randomNumber > usersNumber && counter != 3)
        // {
        //    Console.WriteLine("Your number is lower than random number.");
        //}
        // else if (randomNumber < usersNumber && counter != 3)
        // {
        // Console.WriteLine("Your number is higher than random number.");
        // }
        //  }
        //Console.WriteLine("You have LOST!");

        for (int counter = 1; counter <= 3; counter++)
        {
            usersNumber = enterNumber();
            if (checkGame(usersNumber, randomNumber, counter))
            {
                return;
            }
            Console.WriteLine("You have LOST!");
        }
        Console.WriteLine("You have LOST!");

        // კიდევ ერთი ციკლი შევქმნა, რომელიც მკითხავს მინდა თუ არა, რომ ახლიდან დავიწყო თამაში
        // თუ კი, მაშინ უნდა ყველაფერი განახლდეს და ახლიდან დაიწყოს. თუ არა, მაშინ ყველაფერი დასრულდეს.
    }

    static void welcomingMessage()
    {
        Console.WriteLine("Let's play a game. I have a hidden number for you.");
        Console.WriteLine("This number is between 0 to 20. Please, guess it.");
        Console.WriteLine("You have three attempts.");
    }

    static int getRandomNumber()
    {
        //Random random = new Random();
        //int randomNumber = random.Next(0, 21);
        //return randomNumber;

        return new Random().Next(0, 21);
    }

    static int enterNumber()
    {
        Console.Write("Please, enter a number: ");

        return Int32.Parse(Console.ReadLine());
    }

    static bool checkGame(int usersNumber, int randomNumber, int counter)
    {
        if (randomNumber == usersNumber)
        {
         Console.WriteLine("You have WON!");
          return true; // ყველაფერი დასრულდება გაგრძელების გარეშე
         }
         else if (randomNumber > usersNumber && counter != 3)
         {
            Console.WriteLine("Your number is lower than random number.");
        }
         else if (randomNumber < usersNumber && counter != 3)
         {
         Console.WriteLine("Your number is higher than random number.");
         }
        return false;
    }
}