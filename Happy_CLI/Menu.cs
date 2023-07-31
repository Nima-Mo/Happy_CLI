using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_CLI
{
    public class Menu:AdvText
    {
        /// <summary>
        /// Dynamic waterfall menu with output
        /// </summary>
        /// <param name="strings">Input text array</param>
        /// <param name="outNumber">Returns the menu number</param>
        /// <param name="fSelColor">Select menu forground</param>
        /// <param name="bSelColor">Select menu background</param>
        /// <param name="fColor">forgound color</param>
        /// <param name="bColor">background color</param>
        public void waterfallMenu(string[] strings,ref int outNumber,ConsoleColor fSelColor,ConsoleColor bSelColor,ConsoleColor fColor,ConsoleColor bColor)
        {
            int counter = 0;
            ConsoleKeyInfo ck;

            while (true)
            {
                if (counter >= strings.Length)
                {
                    counter = 0;
                }
                else if (counter < 0)
                {
                    counter = strings.Length - 1;
                }
                for (int i = 0; i < strings.Length; i++) 
                {
                    if(counter == i)
                    {
                        this.writeLine("[" + i.ToString() + "] " + strings[i],fSelColor,bSelColor);
                    }
                    else
                    {
                        this.writeLine("[" + i.ToString() + "] " + strings[i],fColor,bColor);
                    }
                }
                ck = Console.ReadKey();
                if (ck.Key == ConsoleKey.DownArrow) 
                {
                    counter++;
                } else if(ck.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }else if(ck.Key == ConsoleKey.Enter)
                {
                    outNumber = counter;
                    break;
                }
                else
                {
                    this.write("error key input", ConsoleColor.Red);
                }
                Console.Clear();
            }
        }
        /// <summary>
        /// Dynamic waterfall menu with output
        /// </summary>
        /// <param name="strings">Input text array</param>
        /// <param name="outNumber">Returns the menu number</param>
        /// <param name="fSelColor">Select menu forground</param>
        /// <param name="bSelColor">Select menu background</param>
        /// <param name="fColor">forgound color</param>
        /// <param name="bColor">background color</param>
        /// <param name="top">positin Top menu</param>
        /// <param name="left">position left menu</param>
        public void waterfallMenu(string[] strings, ref int outNumber, ConsoleColor fSelColor, ConsoleColor bSelColor,
            ConsoleColor fColor, ConsoleColor bColor,int top,int left)
        {
            int counter = 0;
            int posTop = 0;
            ConsoleKeyInfo ck;

            while (true)
            {
                posTop = top;

                if (counter >= strings.Length)
                {
                    counter = 0;
                }
                else if (counter < 0)
                {
                    counter = strings.Length - 1;
                }
                for (int i = 0; i < strings.Length; i++)
                {
                    if (counter == i)
                    {
                        
                        this.positionText("[" + i.ToString() + "] " + strings[i],left, posTop, fSelColor, bSelColor);
                    }
                    else
                    {
                        this.positionText("[" + i.ToString() + "] " + strings[i], left, posTop, fColor, bColor);
                    }
                    posTop++;
                }
                ck = Console.ReadKey();
                if (ck.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (ck.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }
                else if (ck.Key == ConsoleKey.Enter)
                {
                    outNumber = counter;
                    break;
                }
                else
                {
                    this.write("error key input", ConsoleColor.Red);
                }
                Console.Clear();
            }
        }
        /// <summary>
        /// Dynamic waterfall menu with output
        /// </summary>
        /// <param name="strings">Input text array</param>
        /// <param name="symbol">bela bela bela</param>
        /// <param name="outNumber">Returns the menu number</param>
        /// <param name="fSelColor">Select menu forground</param>
        /// <param name="bSelColor">Select menu background</param>
        /// <param name="fColor">forgound color</param>
        /// <param name="bColor">background color</param>
        /// <param name="top">positin Top menu</param>
        /// <param name="left">position left menu</param>
        public void waterfallMenu(string[] strings,string symbol, ref int outNumber, ConsoleColor fSelColor, ConsoleColor bSelColor,
            ConsoleColor fColor, ConsoleColor bColor, int top, int left)
        {
            int counter = 0;
            int posTop = 0;
            ConsoleKeyInfo ck;

            while (true)
            {
                posTop = top;

                if (counter >= strings.Length)
                {
                    counter = 0;
                }
                else if (counter < 0)
                {
                    counter = strings.Length - 1;
                }
                for (int i = 0; i < strings.Length; i++)
                {
                    if (counter == i)
                    {

                        this.positionText("[" + symbol + "] " + strings[i], left, posTop, fSelColor, bSelColor);
                    }
                    else
                    {
                        this.positionText("[" + i.ToString() + "] " + strings[i], left, posTop, fColor, bColor);
                    }
                    posTop++;
                }
                ck = Console.ReadKey();
                if (ck.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (ck.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }
                else if (ck.Key == ConsoleKey.Enter)
                {
                    outNumber = counter;
                    break;
                }
                else
                {
                    this.write("error key input", ConsoleColor.Red);
                }
                Console.Clear();
            }
        }
        /// <summary>
        /// Dynamic waterfall menu with output
        /// </summary>
        /// <param name="strings">Input text array</param>
        /// <param name="outNumber">Returns the menu number</param>
        /// <param name="fSelColor">Select menu forground</param>
        /// <param name="bSelColor">Select menu background</param>
        /// <param name="fColor">forgound color</param>
        /// <param name="bColor">background color</param>
        /// <param name="top">positin Top menu</param>
        /// <param name="left">position left menu</param>
        public void waterfallMenuBox(string[] strings, ref int outNumber, ConsoleColor fSelColor, ConsoleColor bSelColor,
                                     ConsoleColor fColor, ConsoleColor bColor, int top, int left)
        {
            int counter = 0;
            int posTop = 0;
            string line = "";
            ConsoleKeyInfo ck;
            
            if(strings.Length < 0){return;}

            int maxLength = strings.Max(x => x).Length;
            line = line.PadLeft(maxLength+8, '-');
       
            while (true)
            {
                posTop = top;

                if (counter >= strings.Length)
                {
                    counter = 0;
                }
                else if (counter < 0)
                {
                    counter = strings.Length - 1;
                }
                //up line
                this.positionText(line, left, posTop++, fColor, bColor);
                
                for (int i = 0; i < strings.Length; i++)
                {
                    if (counter == i)
                    {
                        this.positionText("| [" + i.ToString() + "] " + strings[i] + " |", left, posTop, fSelColor, bSelColor);
                    }
                    else
                    {
                        this.positionText("| [" + i.ToString() + "] " + strings[i] + " |", left, posTop, fColor, bColor);
                    }
                    posTop++;
                }
                //down line
                this.positionText(line, left, posTop, fColor, bColor);
                
                ck = Console.ReadKey();
                if (ck.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (ck.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }
                else if (ck.Key == ConsoleKey.Enter)
                {
                    outNumber = counter;
                    break;
                }
                
                Console.Clear();
            }
        }
        /// <summary>
        /// Dynamic waterfall menu with output
        /// </summary>
        /// <param name="strings">Input text array</param>
        /// <param name="symbol">bela bela bela</param>
        /// <param name="outNumber">Returns the menu number</param>
        /// <param name="fSelColor">Select menu forground</param>
        /// <param name="bSelColor">Select menu background</param>
        /// <param name="fColor">forgound color</param>
        /// <param name="bColor">background color</param>
        /// <param name="top">positin Top menu</param>
        /// <param name="left">position left menu</param>
        public void waterfallMenuBox(string[] strings,char symbol, ref int outNumber, ConsoleColor fSelColor, ConsoleColor bSelColor,
                                     ConsoleColor fColor, ConsoleColor bColor, int top, int left)
        {
            int counter = 0;
            int posTop = 0;
            string line = "";
            ConsoleKeyInfo ck;

            if (strings.Length < 0) { return; }

            int maxLength = strings.Max(x => x).Length;
            line = line.PadLeft(maxLength + 8, '-');

            while (true)
            {
                posTop = top;

                if (counter >= strings.Length)
                {
                    counter = 0;
                }
                else if (counter < 0)
                {
                    counter = strings.Length - 1;
                }
                //up line
                this.positionText(line, left, posTop++, fColor, bColor);

                for (int i = 0; i < strings.Length; i++)
                {
                    if (counter == i)
                    {
                        this.positionText("| [" + symbol.ToString() + "] " + strings[i] + " |", left, posTop, fSelColor, bSelColor);
                    }
                    else
                    {
                        this.positionText("| [" + i.ToString() + "] " + strings[i] + " |", left, posTop, fColor, bColor);
                    }
                    posTop++;
                }
                //down line
                this.positionText(line, left, posTop, fColor, bColor);

                ck = Console.ReadKey();
                if (ck.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (ck.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }
                else if (ck.Key == ConsoleKey.Enter)
                {
                    outNumber = counter;
                    break;
                }

                Console.Clear();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="outNumber"></param>
        /// <param name="fSelColor"></param>
        /// <param name="bSelColor"></param>
        /// <param name="fSelMarkColor"></param>
        /// <param name="bSelMarkColor"></param>
        /// <param name="fColor"></param>
        /// <param name="bColor"></param>
        /// <param name="fMarkColor"></param>
        /// <param name="bMarkColor"></param>
        /// <param name="top"></param>
        /// <param name="left"></param>
        public void waterfallMenuBox(string[] strings, ref int outNumber, ConsoleColor fSelColor, ConsoleColor bSelColor,ConsoleColor fSelMarkColor,
        ConsoleColor bSelMarkColor,ConsoleColor fColor, ConsoleColor bColor, ConsoleColor fMarkColor, ConsoleColor bMarkColor, int top, int left)
        {
            int counter = 0;
            int posTop = 0;
            string line = "";
            string temp1 = string.Empty;
            string temp2 = string.Empty;
            string temp3 = string.Empty;
            ConsoleKeyInfo ck;

            if (strings.Length < 0) { return; }

            int maxLength = strings.Max(x => x).Length;
            line = line.PadLeft(maxLength + 8, '-');

            while (true)
            {
                posTop = top;

                if (counter >= strings.Length)
                {
                    counter = 0;
                }
                else if (counter < 0)
                {
                    counter = strings.Length - 1;
                }
                //up line
                this.positionText(line, left, posTop++, fColor, bColor);

                for (int i = 0; i < strings.Length; i++)
                {
                    if (counter == i)
                    {
                        temp1 = "| ";
                        this.positionText(temp1, left, posTop, fColor, bColor);
                        temp2 = "[" + i.ToString() + "] ";
                        this.positionText(temp2,(left + temp1.Length),posTop,fSelMarkColor,bSelMarkColor);
                        this.positionText(strings[i], (left + temp1.Length + temp2.Length), posTop, fSelColor, bSelColor);
                        temp3 = " |";
                        this.positionText(temp3, (left + temp1.Length + temp2.Length + strings[i].Length), posTop, fColor, bColor);
                    }
                    else
                    {
                        temp1 = "| ";
                        this.positionText(temp1, left, posTop, fColor, bColor);
                        temp2 = "[" + i.ToString() + "] ";
                        this.positionText(temp2, (left + temp1.Length), posTop, fMarkColor, bSelMarkColor);
                        this.positionText(strings[i], (left + temp1.Length + temp2.Length), posTop, fColor, bColor);
                        temp3 = " |";
                        this.positionText(temp3, (left + temp1.Length + temp2.Length + strings[i].Length), posTop, fColor, bColor);
                    }
                    posTop++;
                }
                //down line
                this.positionText(line, left, posTop, fColor, bColor);

                ck = Console.ReadKey();
                if (ck.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (ck.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }
                else if (ck.Key == ConsoleKey.Enter)
                {
                    outNumber = counter;
                    break;
                }

                Console.Clear();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="symbol"></param>
        /// <param name="outNumber"></param>
        /// <param name="fSelColor"></param>
        /// <param name="bSelColor"></param>
        /// <param name="fSelMarkColor"></param>
        /// <param name="bSelMarkColor"></param>
        /// <param name="fColor"></param>
        /// <param name="bColor"></param>
        /// <param name="fMarkColor"></param>
        /// <param name="bMarkColor"></param>
        /// <param name="top"></param>
        /// <param name="left"></param>
        public void waterfallMenuBox(string[] strings,char symbol, ref int outNumber, ConsoleColor fSelColor, ConsoleColor bSelColor, ConsoleColor fSelMarkColor,
        ConsoleColor bSelMarkColor, ConsoleColor fColor, ConsoleColor bColor, ConsoleColor fMarkColor, ConsoleColor bMarkColor, int top, int left)
        {
            int counter = 0;
            int posTop = 0;
            string line = "";
            string temp1 = string.Empty;
            string temp2 = string.Empty;
            string temp3 = string.Empty;
            ConsoleKeyInfo ck;

            if (strings.Length < 0) { return; }

            int maxLength = strings.Max(x => x).Length;
            line = line.PadLeft(maxLength + 8, '-');

            while (true)
            {
                posTop = top;

                if (counter >= strings.Length)
                {
                    counter = 0;
                }
                else if (counter < 0)
                {
                    counter = strings.Length - 1;
                }
                //up line
                this.positionText(line, left, posTop++, fColor, bColor);

                for (int i = 0; i < strings.Length; i++)
                {
                    if (counter == i)
                    {
                        temp1 = "| ";
                        this.positionText(temp1, left, posTop, fColor, bColor);
                        temp2 = "[" + symbol.ToString() + "] ";
                        this.positionText(temp2, (left + temp1.Length), posTop, fSelMarkColor, bSelMarkColor);
                        this.positionText(strings[i], (left + temp1.Length + temp2.Length), posTop, fSelColor, bSelColor);
                        temp3 = " |";
                        this.positionText(temp3, (left + temp1.Length + temp2.Length + strings[i].Length), posTop, fColor, bColor);
                    }
                    else
                    {
                        temp1 = "| ";
                        this.positionText(temp1, left, posTop, fColor, bColor);
                        temp2 = "[" + i.ToString() + "] ";
                        this.positionText(temp2, (left + temp1.Length), posTop, fMarkColor, bSelMarkColor);
                        this.positionText(strings[i], (left + temp1.Length + temp2.Length), posTop, fColor, bColor);
                        temp3 = " |";
                        this.positionText(temp3, (left + temp1.Length + temp2.Length + strings[i].Length), posTop, fColor, bColor);
                    }
                    posTop++;
                }
                //down line
                this.positionText(line, left, posTop, fColor, bColor);

                ck = Console.ReadKey();
                if (ck.Key == ConsoleKey.DownArrow)
                {
                    counter++;
                }
                else if (ck.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }
                else if (ck.Key == ConsoleKey.Enter)
                {
                    outNumber = counter;
                    break;
                }

                Console.Clear();
            }
        }
    }

}
