using System.Runtime.CompilerServices;

Fight();

static void Fight()
{

    int d1 = 0;
    int d2 = 0;

    Console.WriteLine("Vad heter din champion?");
    string p1Name = Console.ReadLine();
    Console.WriteLine("Vad heter din opp?");
    string p2Name = Console.ReadLine();


    while (d1 < 7 || d1 > 30)
    {
        Console.WriteLine("hur stark är din champion (7-30) ");
        string pD1 = Console.ReadLine();
        int.TryParse(pD1, out d1);
    }

    
    while (d2 < 7 || d2 > 30)
    {
        Console.WriteLine("hur stark är din opp (7-30) ");
        string pD2 = Console.ReadLine();
        int.TryParse(pD2, out d2);
    }



    int p1Hp = 100 - 2 * d1;
    int p2Hp = 100 - 2 * d2;

    Console.WriteLine($"{p1Name} {p1Hp} skada: 5-{d1}");
    Console.WriteLine($"{p2Name} {p2Hp} skada: 5-{d2}");

    
    string redo = "";

    Console.WriteLine("ÄR DU REDO????");
    
    while (redo != "ja")
    {
        redo = Console.ReadLine();
        Console.WriteLine("ÄR DU REDO????");
    }





    while (p1Hp > 0 && p2Hp > 0)
    {
        int realD1 = Random.Shared.Next(5, d1);
        int realD2 = Random.Shared.Next(5, d2);
        p2Hp -= realD1; // p1 slår Calin
        p1Hp -= realD2; // Calin slår p1

        Console.WriteLine($"{p1Name} gjorde {realD1} skada");
        Console.WriteLine($"{p2Name} gjorde {realD2} skada");
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