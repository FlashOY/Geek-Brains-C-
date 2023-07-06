Console.Write("Enter a number (1-7) representing the day of the week: ");
        int dayOfWeek = int.Parse(Console.ReadLine());

        bool isWeekend = (dayOfWeek == 6 || dayOfWeek == 7);

        if (isWeekend) {
        Console.WriteLine("Yes, it's a weekend day.");}
        else
        {Console.WriteLine("No, it's not a weekend day."); }