class LessonFour
{
    static void Main(string[] args) // შესვლის წერტილის მეთოდი, მხოლოდ ერთი
    {
        Console.WriteLine(getIntegerSum(91, 78)); // method call
        // class არსებილი სახელი, პირველი ასო უნდა იყოს დიდი
        // ცვლადები უნდა იყოს არსებითი სახელი და აგრეთვე იწერებოდეს myAge, age
        // მეთოდი არის ზმნა calculateBMI, getMyAge
        // მეთოდი არის ზმნა CalculateBMI, GetMyAge
    }

    static void homework()
    {
        /* 1.შევქმნათ სამი ცვლადი(x, z, y). მივანიჭოთ მნიშვნელობები. 
 * გამოვიყვანოთ კონსოლში: x + z * y = ჯამი; მაგ. 4, 5, 10 - ის შედეგია 54.
 */
        int x = 4;
        int z = 2;
        int y = 5;

        int sum = x + (z * y); // ()
        Console.WriteLine("The sum of x (4) + z (2) * y (5) equals to: " + sum);

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