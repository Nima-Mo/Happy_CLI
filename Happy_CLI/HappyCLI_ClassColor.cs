using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_CLI
{
    public class ColorText
    {
        public ColorText() { }
        public void write(string text,ConsoleColor fcolor) 
        {
            Console.ForegroundColor = fcolor;
            Console.Write(text);
            Console.ResetColor();
        }
        public void write(string text, ConsoleColor fcolor,ConsoleColor bcolor)
        {
            Console.ForegroundColor = fcolor;
            Console.BackgroundColor = bcolor;
            Console.Write(text);
            Console.ResetColor();
        }
        public void writeLine(string text, ConsoleColor fcolor)
        {
            Console.ForegroundColor = fcolor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public void writeLine(string text, ConsoleColor fcolor, ConsoleColor bcolor)
        {
            Console.ForegroundColor = fcolor;
            Console.BackgroundColor = bcolor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public void RepeatCharacter(char ch, int count,bool newLine = true) 
        {
            string tempo = string.Empty;
            tempo = tempo.PadLeft(count, ch);
            if (newLine)
            {
                Console.WriteLine(tempo);
            }
            else
            {
                Console.Write(tempo);
            }
        }
        public void RepeatCharacter(string str, int count)
        {

        }

    }
}
