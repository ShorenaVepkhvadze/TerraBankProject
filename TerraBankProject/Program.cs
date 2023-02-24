class LessonFour
{
    static void Main(string[] args) // შესვლის წერტილის მეთოდი, მხოლოდ ერთი
    {
        Console.WriteLine(getIntegerSum(91, 78)); // method call

        Console.WriteLine();
        getMaxMin();
    }

    /// <summary>
    /// 1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს.მეთოდმა უნდა 
    /// დააბრუნოს ორი რიცხვის ჯამი.გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის 
    /// მეშვეობით კონსოლში.
    /// </summary>
    static int getIntegerSum(int varOne, int varTwo)
    {
        return varOne + varTwo;
    }

    /// <summary>
    /// 2. შევქმნათ მეთოდი. ვთხოვოთ მომხმარებელს შეიყვანოს ოთხი ნებისმიერი ტიპის 
    /// რიცხვი (ანუ არა მხოლოდ ინტეჯერი). მეთოდის ფარგლებში უნდა მოიძებნოს ამ 
    /// ოთხი რიცხვიდან ყველაზე დიდი და ყველაზე პატარა. მეთოდმა უნდა გამოიყვანოს 
    /// კონსოლში ეს ორი რიცხვი.
    /// </summary>
    static void getMaxMin()
    {
        Console.Write("Please, enter the first number: ");
        double numbOne = Double.Parse(Console.ReadLine());
        Console.Write("Please, enter the second number: ");
        double numbTwo = Double.Parse(Console.ReadLine());
        Console.Write("Please, enter the third number: ");
        double numbThree = Double.Parse(Console.ReadLine());
        Console.Write("Please, enter the fourth number: ");
        double numbFour = Double.Parse(Console.ReadLine());

        Console.WriteLine(numbOne + " " + numbTwo + " " + numbThree + " " + numbFour);

        double max = 0; // temporary
        double min = 0;

        if (numbOne > numbTwo)
        {
            max = numbOne;
        }
        else
        {
            max = numbTwo;
        }

        if (max < numbThree)
        {
            max = numbThree;
        }

        if (max < numbFour)
        { 
            max = numbFour;
        }

        Console.WriteLine("The MAX number is: " + max);
    }
}