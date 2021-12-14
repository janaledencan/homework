using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ConsolePrinter : IPrinter
    {
        ConsoleColor color;

        public ConsolePrinter(ConsoleColor color)
        {
            this.color = color;
        }

        public void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
