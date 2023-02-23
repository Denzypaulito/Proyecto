using System;

public class MetodoNewton
{
    public static double raiz(double x)
    {
        double guess = x / 2;
        double epsilon = 0.000001;
        while (Math.Abs(guess * guess - x) > epsilon)
        {
            guess = (guess + x / guess) / 2;
        }
        return guess;
    }
}

public class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("***METODO NEWTON***");
        Console.WriteLine("Introduce un valor númerico");
        Console.ResetColor();
        
        string a = Console.ReadLine();

    try
    {
        double x = Int64.Parse(a);
        double raiz = MetodoNewton.raiz(x);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"La raíz cuadrada de {x} es {raiz}");
        Main();
    }
    catch
    {
            Console.WriteLine("Introduce un valor valido");
            Main();
        }
    }
}
