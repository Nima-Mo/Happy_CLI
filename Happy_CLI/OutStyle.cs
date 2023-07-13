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

    }
}
