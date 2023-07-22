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
    }
}
