using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Press A, M, or N to choose");
        string choose = Console.ReadLine();
        string[] military = { "Army", "Marines", "Navy" };
        int[] number1 = { 10, 30, 90 };
        if (choose == "a")
        {
            Console.WriteLine("You have chosen" + " " + military[0]);
            Console.WriteLine("You Have" + " " + number1[0] + " Years of experience.");
        }
        else if (choose == "m")
        {
            Console.WriteLine("You have chosen" + " " + military[1]);
            Console.WriteLine("You Have" + " " + number1[1] + " Years of experience.");
        }
        else if (choose == "n")
        {
            Console.WriteLine("You have chosen" + " " + military[2]);
            Console.WriteLine("You Have" + " " + number1[2] + " Years of experience.");
        }
        else
        {
            Console.WriteLine("You have chosen the wrong key");
        }
    }
}