using System;

class Program
{
    static void Main(string[] args)
    {
        bool fortsätt = true;

        while (fortsätt)
        {
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");

            int val = Convert.ToInt32(Console.ReadLine());

            switch (val)
            {
                case 1:
                    MenyvalAddera();
                    break;
                case 2:
                    MenyvalStörstaTalet();
                    break;
                case 3:
                    fortsätt = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }

    static void MenyvalAddera()
    {
        Console.WriteLine("Ange tre tal att addera:");
        int tal1 = Convert.ToInt32(Console.ReadLine());
        int tal2 = Convert.ToInt32(Console.ReadLine());
        int tal3 = Convert.ToInt32(Console.ReadLine());

        int summa = Addera(tal1, tal2, tal3);
        Console.WriteLine("Summan är: " + summa);
    }

    static void MenyvalStörstaTalet()
    {
        Console.WriteLine("Ange två tal:");
        int tal1 = Convert.ToInt32(Console.ReadLine());
        int tal2 = Convert.ToInt32(Console.ReadLine());

        int störstaTalet = Störst(tal1, tal2);
        Console.WriteLine("Det största talet är: " + störstaTalet);
    }

    static int Addera(int tal1, int tal2, int tal3)
    {
        return tal1 + tal2 + tal3;
    }

    static int Störst(int tal1, int tal2)
    {
        if (tal1 > tal2)
        {
            return tal1;
        }
        else if (tal2 > tal1)
        {
            return tal2;
        }
        else
        {
            return tal1; 
        }
    }
}
