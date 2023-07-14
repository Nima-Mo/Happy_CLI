using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_CLI
{
    public class OutStyle:Happy_CLI.AdvText
    {
        public OutStyle(){}
        public void columnOut(string[]list,int row,int col,ConsoleColor color = ConsoleColor.White)
        {
            if (list.Length == 0)
            {
                return;
            }

            int counter = 0;
            string tempo = string.Empty;
            
            for( int Col = 0;Col < col;Col++)
            {
                for(int Row = 0;Row < row;Row++)
                {
                    if(counter != list.Length)
                    {
                        tempo = string.Format("{0,-15}", list[counter]);
                        this.write(tempo, color);
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                Console.WriteLine();
            }
        }
        public void columnOut(string[] list,int col, ConsoleColor color = ConsoleColor.White)
        {
            if(list.Length == 0)
            {
                return;
            }

            int counter = 0;
            int Col = 0;
            string tempo = string.Empty;

            for (; counter < list.Length ;)
            {
                for(Col = 0; Col < col;Col++)
                {
                    if(counter != list.Length)
                    {
                        tempo = string.Format("{0,-15}", list[counter]);
                        this.write(tempo, color);
                        counter++;
                    }
                    else
                    {
                        break;
                    }    
                }
                Col = 0;
                Console.WriteLine();
            }
        }
        public void listComment(SortedList<string, string> slist, int countTab = 1)
        {
            string tab = string.Empty;
            for (int i = 0; i < countTab; i++) { tab += "\t"; }
            foreach (string s in slist.Keys)
            {
                Console.Write("{0,-15}{1}", s, tab);
                Console.Write("{0,-15}", slist[s]);
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public void listComment(SortedList<string,string> slist,ConsoleColor fKeyColor, ConsoleColor fValColor, int countTab = 1)
        {
            string tab = string.Empty;
            for (int i = 0; i < countTab; i++) { tab += "\t"; }
            foreach (string s in slist.Keys)
            {
                Console.ForegroundColor = fKeyColor;
                Console.Write("{0,-15}{1}",s,tab);
                Console.ForegroundColor = fValColor;
                Console.Write("{0,-15}", slist[s]);
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public void listComment(SortedList<string, string> slist, ConsoleColor fKeyColor, ConsoleColor fValColor, ConsoleColor bKeyColor, ConsoleColor bValColor, int countTab = 1)
        {
            string tab = string.Empty;
            for (int i = 0; i < countTab; i++) { tab += "\t"; }
            foreach (string s in slist.Keys)
            {
                Console.ForegroundColor = fKeyColor;
                Console.BackgroundColor = bKeyColor;
                Console.Write("{0,-15}{1}", s, tab);
                Console.ForegroundColor = bKeyColor;
                Console.BackgroundColor = bValColor;
                Console.Write("{0,-15}", slist[s]);
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public void dialog(string[][]dialog,ConsoleColor titleColor = ConsoleColor.White,ConsoleColor textColor = ConsoleColor.White)
        {
           for(int i = 0; i < dialog.Length;i++) 
            {
                for(int j = 0; j < dialog[i].Length;j++)
                {
                    if( j == 0 )
                    {
                        this.writeLine(dialog[i][j],titleColor);
                    }
                    else
                    {
                        this.writeLine("\t" + dialog[i][j],textColor);
                    }
                }  
            } 
        }
        public void olListNumber(string[] strings,int start = 1,string sep = "-",ConsoleColor numColor = ConsoleColor.White,ConsoleColor textColor = ConsoleColor.White)
        {
            string tempo = string.Empty;

            for(int i = 0;i < strings.Length;i++)
            {
                tempo = start.ToString() + sep;
                this.write(tempo,numColor);
                this.write(strings[i],textColor);
                Console.WriteLine();
                start++;
            }
        }
        public void olListChar(string[] strings,bool upperCase , string sep = "-", ConsoleColor numColor = ConsoleColor.White, ConsoleColor textColor = ConsoleColor.White)
        {
            string tempo = string.Empty;
            int min = 0;
            int max = 0;
            int min2 = 0;
            bool key = false;
            
            if (upperCase)
            {
                min = 65;
                min2 = 64;
                max = 90;

                for (int i = 0; i < strings.Length; i++)
                {
                    if (min == max)
                    {
                        min = 65;
                        key = true;
                        min2++;
                    }
                    if (key)
                    {
                        tempo = ((char)min).ToString() + ((char)min2).ToString() + sep;
                    }
                    else
                    {
                        tempo = ((char)min).ToString() + sep;
                    }
                    this.write(tempo, numColor);
                    this.write(strings[i], textColor);
                    Console.WriteLine();
                    min++;
                }
            }
            else
            {
                min = 97;
                min2 = 96;
                max = 122;
                for (int i = 0; i < strings.Length; i++)
                {
                    if (min == max)
                    {
                        min = 97;
                        key = true;
                        min2++;
                    }
                    if(key)
                    {
                        tempo = ((char)min).ToString()+ ((char)min2).ToString() + sep;
                    }
                    else
                    {
                        tempo = ((char)min).ToString() + sep;
                    }
                    this.write(tempo, numColor);
                    this.write(strings[i], textColor);
                    Console.WriteLine();
                    min++;
                }
            }
        }
        public void ribon(string text,bool alignCenter , ConsoleColor bColor,ConsoleColor fColor)
        {
            int max = 0;
            if(alignCenter)
            {
                max = (Console.WindowWidth / 2) - (text.Length / 2);
            }
            else
            {
                max = (Console.WindowWidth / 4) - (text.Length / 2);
            }
            for (int i = 0; i < (Console.WindowWidth - text.Length); i++)
            {
                Console.BackgroundColor = bColor;
                Console.ForegroundColor = fColor;
                Console.Write(" ");
                if (i == max)
                {
                    Console.Write(text);
                }
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
