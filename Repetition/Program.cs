using System.Runtime.CompilerServices;

Fight();

static void Fight()
{

    int d1 = 0;
    int d2 = 0;

    while (d1 < 1 && d1 > 30)
    {
        Console.WriteLine("hur stark är din champion (1-30) ");
        string pD1 = Console.ReadLine();
        int.TryParse(pD1, out d1);
    }

    while (d2 < 1 && d2 > 30)
    {
        Console.WriteLine("hur stark är din opp (1-30) ");
        string pD2 = Console.ReadLine();
        int.TryParse(pD2, out d2);
    }

    Console.WriteLine("Vad heter din champion?");
    string p1Name = Console.ReadLine();
    Console.WriteLine("Vad heter din opp?");
    string p2Name = Console.ReadLine();

    int p1Hp = 100 - 2 * d1;
    int p2Hp = 100 - 2 * d2;

    Console.WriteLine($"{p1Name} {p1Hp}");
    Console.WriteLine($"{p2Name} {p2Hp}");





    while (p1Hp > 0 && p2Hp > 0)
    {
        p2Hp -= Random.Shared.Next(5, d1); // p1 slår Calin
        p1Hp -= Random.Shared.Next(5, d2); // Calin slår p1
        Console.WriteLine($"{p1Name} {p1Hp}");
        Console.WriteLine($"{p2Name} {p2Hp}");
        Console.ReadLine();
    }


    if (p1Hp > 0)
    {
        Console.WriteLine($"{p1Name} vann!");
    }
    else if (p1Hp <= 0 && p2Hp <= 0)
    {
        Console.WriteLine($"oavgjort!");
    }
    else
    {
        Console.WriteLine($"{p2Name} vann!");
    }



    Console.ReadLine();
}