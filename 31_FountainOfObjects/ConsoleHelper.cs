using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_FountainOfObjects;

public static class ConsoleHelper
{
    public static void Print(this string message)
    {
        Console.Write(message);
    }
    public static void PrintLine(this string message)
    {
        Console.WriteLine(message);
    }
    public static void PrintColour(this string message, ConsoleColor clr)
    {
        Console.ForegroundColor = clr;
        Console.Write(message);
        Console.ResetColor();
    }
}
