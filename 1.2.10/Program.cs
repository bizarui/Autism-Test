class Program
{
    public static int Score = 0;
    static void Main()
    {
        Greeting();
        Tasks();
        End();
    }
    
    static void Greeting()
    {
        Console.WriteLine("Добрро пожаловать в мир задачь!");
        Console.WriteLine("Как тебя зовут?");
        string name = Console.ReadLine();
        Console.WriteLine($"Какое интересное имя {name}");
    }
    
    static void Tasks()
    {
        //1
        Console.WriteLine("[1 Задание]");
        Console.WriteLine("7 * 3");

        int Answer1 = int.Parse(Console.ReadLine());

        if (Answer1 == 21)
        {
            Console.WriteLine("Это верный ответ!");
            Score++;
        }
        else
        {
            Console.WriteLine("Это не верный ответ(");
        }
        // 2
        Console.WriteLine("[2 Задание]");
        Console.WriteLine("√16");

        int Answer2 = int.Parse(Console.ReadLine());

        if (Answer2 == 4)
        {
            Console.WriteLine("Это верный ответ!");
            Score++;
        }
        else
        {
            Console.WriteLine("Это не верный ответ(");
        }
        // 3
        Console.WriteLine("[3 Задание]");
        Console.WriteLine("√1 000 000");

        int Answer3 = int.Parse(Console.ReadLine());

        if (Answer3 == 1000)
        {
            Console.WriteLine("Это верный ответ!");
            Score++;
        }
        else
        {
            Console.WriteLine("Это не верный ответ(");
        }
        // 4
        Console.WriteLine("[4 Задание]");
        Console.WriteLine("9 * 9");

        int Answer4 = int.Parse(Console.ReadLine());

        if (Answer4 == 81)
        {
            Console.WriteLine("Это верный ответ!");
            Score++;
        }
        else
        {
            Console.WriteLine("Это не верный ответ(");
        }
        // 5
        Console.WriteLine("[5 Задание]");
        Console.WriteLine("6 * 5");

        int Answer5 = int.Parse(Console.ReadLine());

        if (Answer5 == 30)
        {
            Console.WriteLine("Это верный ответ!");
            Score++;
        }
        else
        {
            Console.WriteLine("Это не верный ответ(");
        }
    }

    static void End()
    {
        if (Score > 3)
        {
            Console.WriteLine("Ты написал ответы правильно");
        }
        else
        {
            Console.WriteLine("Ты написал ответы неправильно");
        }

        Console.WriteLine($"Ваши балы: {Score}/5");
    }
}