using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        // კონსოლში ახალი სტრიქონის გარეშე ინფორმაციის შეყვანა
        Console.Write("Archil");
        Console.Write(" Sikharulidze");

        // RAM - randomy accessed memory
        // Stack & Heap
        // Stack შეიქმნა პროგრამის ნაწილში -> მასში არსებული მეხსიერება აქტიურად იცვლება
        // რაც საჭიროა შედის და მერე გადის (მოკლე მეხსიერება).
        // Heap - მეხსიერება, რომელიც თან ახლავს პროგრამას დასრულებამდე
        // ისეთ ნივთებს, რომლებიც ხანგრძლივად ინახება - მერე ავტომატურად იშლება ე.წ. Garbace Colletor
        // Memory Leak - რომ მოეგვარებინათ ეს პრობლემა შექმნეს ავტომატური Garbace Colletor

        // Stack (primitive variables) & Heap (referenced type variables)

        // Strict typed variables & dinamically
        // ცვლადის ტიპი განაპირობებს მასში შენახულ მნიშვნელობას (Strict typed)
        // მნიშვნელობა განსაზღვრავს ცვლადის ტიპს და, როგორც წესი, შეიძლება ცვლადის ტიპის ცვლილება (dinamically)
        byte myByte = 23; // 0 to 255
        sbyte mySbyte = -12;
        short myShort = -31000;

        int myInt = 1345678; // -2 bil to 2 bil
        long myLong = 10;
        myLong = 145L;

        float myFloat = 12.3F; // additional checkout f & F, static just keep variable
        double myDouble = 12.5; // bigger number, more precise and arithemtic operation needed
        double mySecondDouble = 123;

        Console.WriteLine();
        char myChar = 'R';
        Console.WriteLine((int)myChar); // behind symbol there is a number, register sensitive
        myChar = 'r';
        Console.WriteLine((int)myChar); // behind symbol there is a number

        string myString = "Archil";
        string mySecondString = @"Archil / Sikharulidze /";

        bool myBool = false; // logical not
        myBool = true; // logical yes

        decimal myDecimal = 12M; // only for serious arithemtic operations, comparisons and other
        decimal mySecondDecimal = 124.5M; // calculations

        Console.Write("Please, enter your name: ");
        //string name = Console.ReadLine(); // string
        Console.Write("Please, enter your surname: ");
        //string surname = Console.ReadLine();

        //Console.WriteLine(name + " " + surname); // concatenation
        Console.WriteLine();
        Console.Write("Please, enter your age: ");
        //int age = Int32.Parse(Console.ReadLine()); // Parse: Int32.Parse(), Double.Parse(), float.Parse(), Char.Parse()
        //Console.WriteLine("Your age is: " + age);
        Console.WriteLine();
        Console.Write("Please, enter your weight: ");
        //double weight = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        int birthYear = 1988;
        int currentDate = 2023;
        int currentAge = currentDate - birthYear;

        int randomNumber = 34 - 15;
        int mulpt = 4 * 5;
        int division = 4 / 2;
        int plus = 34 + 14;

        int num1 = 9;
        int num2 = 2;

        Console.WriteLine(currentAge);
        Console.WriteLine(num1 % num2);

        num1 = num1 + 1; //
        num1 += 1; // num1 -= 2 (num1 = num1 - 2); num1 /= 4 (num1 = num1 / 4);

        // only minus or plus, post increment & post decrement
        num1++; // num1 = num1 + 1 an num1 += 1;
        num1--; // num1 = num1 - 1 an num1 -= 1;

        // !!! C# arithmethic operations priority
        int sum1 = (5 + 10) * 5; // 5+10 * 5
    }
}