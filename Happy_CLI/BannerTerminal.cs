using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_CLI
{
    public class BannerTerminal:AsciiChar
    {
        private string _textInput;
        private static int _status;
        public BannerTerminal(string textInput,string model,ConsoleColor fColor)
        {
            _textInput = textInput;
            this.asciiPrinter(this._textInput,model, fColor);
        }
        public override string ToString()
        {
            return _textInput;
        }
        public void asciiPrinter(string input,string model,ConsoleColor fColor) 
        {
            int posTop = Console.GetCursorPosition().Top;

            for (int i = 0; i < input.Length; i++)
            {
                switch(input[i])
                {
                    case 'A':
                        this.printer(this._A,model,posTop,fColor);
                        break;
                    case 'B':
                        this.printer(this._B, model, posTop, fColor);
                        break;
                    case 'C':
                        this.printer(this._C, model, posTop, fColor);
                        break;
                    case 'D':
                        this.printer(this._D, model, posTop, fColor);
                        break;
                }
            }
            Console.CursorLeft = 0;
        }
        private void printer(byte[,] arrMap,string model,int posTop,ConsoleColor fColor)
        {
            int maxWidth = Console.WindowWidth;
            int maxHeight = Console.WindowHeight;
            int posX = Console.GetCursorPosition().Left+1;
            int posY = posTop;

            if (posX >= (maxWidth-arrMap.GetLength(1)))
            {
                return;
            }

            for (int i = 0; i < arrMap.GetLength(0); i++)
            {   
                for (int j = 0; j < arrMap.GetLength(1); j++)
                {
                    if (arrMap[i,j] != 0) 
                    {
                        this.positionTextAt(model, posX, posY, fColor);
                    }
                    else
                    {
                        this.positionTextAt("", posX, posY, fColor);
                    }
                    posX++;
                }
                posY++;
                posX -= arrMap.GetLength(1);
                
            }
        }
    }
}
