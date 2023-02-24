class Loops
{
    static void MMain(string[] args)
    {
        // Loops
        // კოდის გამეორების სტრუქტურა

        // while
        // გამოვიყვანო 1 - 10 ყველა რიცხვი
        int number1 = 1;

        while (number1 <= 10) // ლოგიკური პირობა
        {
            // ციკლი ჯერ ამოწმებს ლოგიკურ პირობას და მერე ასრულებს სხეულს
            // როდესაც ლოგიკური პირობა შეუსრულებელია
            // მაშინ ვიღებთ მუდმივ ციკლს და კომპიუტერი გაიჭედება
            Console.WriteLine("While Loop: " + number1++); // number1 += 1;
            //number1 = number1+ 1;
            //number1 += 1;
        }

        // საჭირო მუდმივი ციკლი
        // მუდმივი ციკლის მისაღწევად უნდა დავაკმაყოფილო ორი მოთხოვნა
        // 1. ლოგიკური პიროვა უნდა იყოს ჭეშმარიტი
        // 2. არ უნდა შეიცვალოს ანუ სულ ჭეშმარიტი უნდა იყოს
        //while (true) // if მსგავსად ავტომატურად ჯერ ეძებს true
        //{
        //    Console.WriteLine("This loop is eternal...");
        //}

        Console.WriteLine();

        // do while
        int number2 = 1;

        // do while ვიყენებთ მაშინ, როდესაც ჩვენი კოდი ერთხელ მაინც უნდა შესრულდეს
        do
        {
            Console.WriteLine("Do While Loop: " + number2++);
        } while (number2 <= 10);

        Console.WriteLine();

        // for loop
        // for loop ყველაზე ხშირად გამოიყენება მასივებთან (array)
        // და იძლევა შესაძლებლობას, რომ უშუალოდ ციკლის შიგნით განვახორციელოთ
        // ცვლადის განცხადება, ლოგიკური პირობის შემოწმება და ცვლადის ცვლილება
        // for 1 block - ცვლადის გამოცხადება და ინიციალიზაცია
        // for 2 block - ლოგიკური პირობის გაწერა
        // for 3 block - ცვლადის ცვილება, რომ დაკმაყოფილდეს ლოგიკური პირობა და
        // ციკლი დასრულდეს
        // for (; ; ) -> empty loop, eternal
        // for (; logicalOperator; )
        // for (int counter = 0; ; counter++) -> enternal loop
        // for (int counter = 0; true; counter++) -> enterna loop
        // ჯერ ლოგიკა და შემდეგ განცხორციელება
        for (int counter = 1; counter <= 10; counter++)
        {
            Console.WriteLine("For Loop: " + counter);
        }

        Console.WriteLine();

        // break - წყვეტს ციკლს, continue, return - ამთავრებს მეთოდს
        for (int counter = 1; counter <= 10; counter++)
        {
            if (counter < 5)
            {
                Console.WriteLine("Counter: " + counter);
            }
            else
            {
                break; // ტეხს ციკლს, მაგრამ არა მეთოდს
            }
        }
        Console.WriteLine("This message comes after a loop...");

        returnMethod();

        Console.WriteLine();

        // continue - აკეთებს ციკლში +1 ნახტომს
        for (int counter = 1; counter <= 10; counter++)
        {
            if (counter == 5 || counter == 9)
            {
                continue;
            }
            Console.WriteLine("Counter with Continue: " + counter);
        }

        Console.WriteLine();
        for (int rows = 1; rows <= 5; rows++)
        {
            for (int cols = 1; cols <= 5; cols++)
            {
                Console.Write(cols + " ");
                if (cols == 4)
                {
                    break; // ჩაშენების შემთხვევაში ტყდება ის სტრუქტურა,
                           // რომელსაც ეკუთვნის break & continue
                }
            }
            Console.WriteLine();
            if (rows == 3)
            {
                break;
            }
        }

        Console.WriteLine();

        nestedLoopReturn();
    }

    static void returnMethod()
    {
        for (int counter = 1; counter <= 10; counter++)
        {
            if (counter < 6)
            {
                Console.WriteLine("Counter with return: " + counter);
            }
            else
            {
                return; // ტეხს ციკლს და მთლიანად მეთოდს
            }
        }
        Console.WriteLine("This will never be published because of return");
    }

    static void nestedLoopReturn()
    {
        for (int rows = 1; rows <= 2; rows++)
        {
            for (int cols = 1; cols <= 2; cols++)
            {
                for (int nested = 1; nested <= 4; nested++)
                {
                    if (nested == 3)
                    {
                        return;
                    }
                    Console.WriteLine("Triple Nested");
                }
            }
        }
    }
}
