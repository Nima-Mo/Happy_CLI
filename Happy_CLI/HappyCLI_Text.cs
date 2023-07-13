using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_CLI
{
    public class AdvText
    {
        private int _posLeft;
        private int _posTop;

        public AdvText() { }
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
        public void RepeatCharacterColor(char ch, int count,ConsoleColor fcolor, bool newLine = true)
        {
            string tempo = string.Empty;
            tempo = tempo.PadLeft(count, ch);
            if (newLine)
            {
                this.writeLine(tempo, fcolor);
            }
            else
            {
                this.write(tempo, fcolor);
            }
        }
        public void RepeatCharacterColor(char ch, int count, ConsoleColor fcolor, ConsoleColor bcolor, bool newLine = true)
        {
            string tempo = string.Empty;
            tempo = tempo.PadLeft(count, ch);
            if (newLine)
            {
                this.writeLine(tempo, fcolor,bcolor);
            }
            else
            {
                this.write(tempo, fcolor,bcolor);
            }
        }
        public void positionText(string text,int left,int top)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(text);
        }
        public int posLeft
        {
            get { return this._posLeft; }
            set { this._posLeft = value;}
        }
        public int posTop
        {
            get { return this._posTop; }
            set { this._posTop = value;}
        }
        public void positionTextAt(string text, int left, int top)
        {
            int Left = this._posLeft + left;
            int Top = this._posTop + top;
            Console.SetCursorPosition(Left, Top);
            Console.Write(text);
        }
    }
}
