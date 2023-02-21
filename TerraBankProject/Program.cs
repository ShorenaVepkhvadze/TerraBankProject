class HomeWork
{
    static void Main(string[] args)
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

        /* 2.პროგრამა სთავაზობს მომხმარებელს შეიყვანოს სახელი(Archil), 
         * გვარი(Sikharulidze), ასაკი(34), სიმაღლე(171) და წონა(88.7). 
         * შევინახოთ ეს მონაცემები შესაბამისი ტიპის ცვლადებში. გამოვიყვანოთ მთელი 
         * ინფორმაცია კონსოლში.
        */
        //Console.Write("Please, enter your name: ");
        //string name = Console.ReadLine();
        //Console.Write("Please, enter your surname: ");
        //string surname = Console.ReadLine();
        //Console.Write("Please, enter your age: ");
        //int age = Int32.Parse(Console.ReadLine());
        //Console.Write("Please, enter your height: ");
        //int height = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Please, enter your weight: ");
        //float weight = float.Parse(Console.ReadLine());

        //Console.WriteLine();
        //Console.WriteLine("Your name is: " + name);
        //Console.WriteLine("Your surname is: " + surname);
        //Console.WriteLine("Your age is: " + age);
        //Console.WriteLine("Your height is: " + height);
        //Console.WriteLine("Your weight is: " + weight);

        Console.WriteLine();

        Console.WriteLine("     |     |     ");
        Console.WriteLine("  1  |  2  |  3  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  4  |  5  |  6  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  7  |  8  |  9  ");
        Console.WriteLine("     |     |     ");
    }
}
