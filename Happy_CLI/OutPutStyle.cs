using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_CLI
{
    public class OutPutStyle:Happy_CLI.AdvText
    {
        public OutPutStyle(){}
        /// <summary>
        /// Print text in multiple columns and rows
        /// </summary>
        /// <param name="list">strings</param>
        /// <param name="row">rows</param>
        /// <param name="col">column</param>
        /// <param name="fcolor">forground color</param>
        /// <param name="space">The space between the columns</param>
        public void ColumnarText(string[]list,int row,int col,ConsoleColor fcolor,int space = -15)
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
                        tempo = string.Format("{0,"+space.ToString()+"}", list[counter]);
                        this.write(tempo, fcolor);
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
        /// <summary>
        /// Print text in multiple columns and rows
        /// </summary>
        /// <param name="list">strings</param>
        /// <param name="row">rows</param>
        /// <param name="col">column</param>
        /// <param name="fcolor">forground color</param>
        /// <param name="bcolor">Background Color</param>
        /// <param name="space">The space between the columns</param>
        public void ColumnarText(string[] list, int row, int col, ConsoleColor fcolor,ConsoleColor bcolor,int space =-15)
        {
            if (list.Length == 0)
            {
                return;
            }
            int counter = 0;
            string tempo = string.Empty;

            for (int Col = 0; Col < col; Col++)
            {
                for (int Row = 0; Row < row; Row++)
                {
                    if (counter != list.Length)
                    {
                        tempo = string.Format("{0,"+space.ToString()+"}", list[counter]);
                        this.write(tempo, fcolor,bcolor);
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
        /// <summary>
        /// Multi-column text
        /// </summary>
        /// <param name="list">strings</param>
        /// <param name="col">column</param>
        /// <param name="fcolor">forground color</param>
        /// <param name="space">The space between the columns</param>
        public void ColumnarText(string[] list,int col, ConsoleColor fcolor,int space = -15)
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
                        tempo = string.Format("{0," + space.ToString() + "}", list[counter]);
                        this.write(tempo, fcolor);
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
        /// <summary>
        /// Multi-column text
        /// </summary>
        /// <param name="list">strings</param>
        /// <param name="col">column</param>
        /// <param name="fcolor">forground color</param>
        /// <param name="bcolor">background color</param>
        /// <param name="space">The space between the columns</param>
        public void ColumnarText(string[] list, int col, ConsoleColor fcolor,ConsoleColor bcolor, int space = -15)
        {
            if (list.Length == 0)
            {
                return;
            }
            int counter = 0;
            int Col = 0;
            string tempo = string.Empty;

            for (; counter < list.Length;)
            {
                for (Col = 0; Col < col; Col++)
                {
                    if (counter != list.Length)
                    {
                        tempo = string.Format("{0," + space.ToString() + "}", list[counter]);
                        this.write(tempo, fcolor,bcolor);
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
        /// <summary>
        /// Explanatory Text
        /// </summary>
        /// <param name="slist">Sort list</param>
        /// <param name="countTab">Tab For Space</param>
        public void explanationText(SortedList<string, string> slist, int countTab = 1)
        {
            string tab = string.Empty;
            for (int i = 0; i < countTab; i++) { tab += "\t"; }
            foreach (string s in slist.Keys)
            {
                this.write(s);
                this.write(tab);
                this.write(slist[s]);
                this.write("\n");
            }
        }
        /// <summary>
        /// Explanatory Text
        /// </summary>
        /// <param name="slist">Sort List</param>
        /// <param name="fKeyColor">Key Forground Color</param>
        /// <param name="fValueColor">Value Forground Color</param>
        /// <param name="countTab">Tab For Space</param>
        public void explanationText(SortedList<string,string> slist,ConsoleColor fKeyColor, ConsoleColor fValueColor, int countTab = 1)
        {
            string tab = string.Empty;
            for (int i = 0; i < countTab; i++) { tab += "\t"; }
            foreach (string s in slist.Keys)
            {
                this.write(s,fKeyColor);
                this.write(tab);
                this.write(slist[s], fValueColor);
                this.write("\n");
            }
        }
        /// <summary>
        /// Explanatory Text
        /// </summary>
        /// <param name="slist">Sort List</param>
        /// <param name="fKeyColor">Key Forground Color</param>
        /// <param name="fValueColor">Value Forground Color</param>
        /// <param name="bKeyColor">Key Background Color </param>
        /// <param name="bValueColor">Value Background Color</param>
        /// <param name="countTab">Tab For Space</param>
        public void explanationText(SortedList<string, string> slist, ConsoleColor fKeyColor,
            ConsoleColor fValueColor, ConsoleColor bKeyColor, ConsoleColor bValueColor, int space = 1)
        {
            string tab = string.Empty;
            for (int i = 0; i < space; i++) { tab += "\t"; }
            foreach (string s in slist.Keys)
            {
                this.write(s, fKeyColor,bKeyColor);
                this.write(tab);
                this.write(slist[s], fValueColor,bValueColor);
                this.write("\n");
            }
        }
        /// <summary>
        /// Writing the text as a dialogue
        /// </summary>
        /// <param name="dialogue"></param>
        /// <param name="titleColor"></param>
        /// <param name="textColor"></param>
        /// <param name="space">Tab For Space</param>
        public void dialogue(string[][] dialogue, ConsoleColor titleColor,ConsoleColor textColor,int space)
        {
            string tab = string.Empty;
            for (int i = 0; i < space; i++) { tab += "\t"; }

            for (int i = 0; i < dialogue.Length;i++) 
            {
                for (int j = 0; j < dialogue[i].Length;j++)
                {
                    if( j == 0 )
                    {
                        this.writeLine(dialogue[i][j],titleColor);
                    }
                    else
                    {
                        this.writeLine(tab.ToString() + dialogue[i][j],textColor);
                    }
                }  
            } 
        }
        /// <summary>
        /// Ordered list with numbers
        /// </summary>
        /// <param name="strings">Array String Input </param>
        /// <param name="fNumColor">Forground Color Numbers</param>
        /// <param name="fTextColor">Forground Color Text</param>
        /// <param name="sep">Text separator</param>
        /// <param name="start">Start Number</param>
        public void olListNumber(string[] strings,ConsoleColor fNumColor,ConsoleColor fTextColor, string sep = "-", int start = 1)
        {
            string tempo = string.Empty;

            for(int i = 0;i < strings.Length;i++)
            {
                tempo = start.ToString() + sep;
                this.write(tempo,fNumColor);
                this.write(strings[i],fTextColor);
                Console.WriteLine();
                start++;
            }
        }
        /// <summary>
        /// Ordered list with numbers
        /// </summary>
        /// <param name="strings">Array String Input </param>
        /// <param name="fNumColor">Forground Color Numbers</param>
        /// <param name="fTextColor">Forground Color Text</param>
        /// <param name="bNumColor">Background Color Number</param>
        /// <param name="bTextColor">Background Color Text</param>
        /// <param name="sep">Text separator</param>
        /// <param name="start">Start Number</param>
        public void olListNumber(string[] strings, ConsoleColor fNumColor, ConsoleColor fTextColor,ConsoleColor bNumColor,ConsoleColor bTextColor, string sep = "-",int start = 1)
        {
            string tempo = string.Empty;

            for (int i = 0; i < strings.Length; i++)
            {
                tempo = start.ToString() + sep;
                this.write(tempo, fNumColor,bNumColor);
                this.write(strings[i], fTextColor,bTextColor);
                Console.WriteLine();
                start++;
            }
        }
        /// <summary>
        /// Ordered list with Chars
        /// </summary>
        /// <param name="strings">Array String Input</param>
        /// <param name="upperCase">Upper Case Chars</param>
        /// <param name="fCharColor">Forground Color Char</param>
        /// <param name="fTextColor">Forground Color Text</param>
        /// <param name="sep">Text separator</param>       
        public void olListChar(string[] strings,bool upperCase, ConsoleColor fCharColor, ConsoleColor fTextColor, string sep = "-")
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
                    this.write(tempo, fCharColor);
                    this.write(strings[i], fTextColor);
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
                    this.write(tempo, fCharColor);
                    this.write(strings[i], fTextColor);
                    Console.WriteLine();
                    min++;
                }
            }
        }
        /// <summary>
        /// Ordered list with Chars
        /// </summary>
        /// <param name="strings">Array String Input</param>
        /// <param name="upperCase">Upper Case Chars</param>
        /// <param name="fCharColor">Forground Color Char</param>
        /// <param name="fTextColor">Forground Color Text</param>
        /// <param name="bCharColor">Background Color Char</param>
        /// <param name="bTextColor">Background Color Text</param>
        /// <param name="sep">Text separator</param>
        public void olListChar(string[] strings, bool upperCase, ConsoleColor fCharColor, ConsoleColor fTextColor, ConsoleColor bCharColor, ConsoleColor bTextColor, string sep = "-")
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
                    this.write(tempo, fCharColor,bCharColor);
                    this.write(strings[i], fTextColor,bTextColor);
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
                    if (key)
                    {
                        tempo = ((char)min).ToString() + ((char)min2).ToString() + sep;
                    }
                    else
                    {
                        tempo = ((char)min).ToString() + sep;
                    }
                    this.write(tempo, fCharColor,bCharColor);
                    this.write(strings[i], fTextColor,bTextColor);
                    Console.WriteLine();
                    min++;
                }
            }
        }
        /// <summary>
        /// Display text in a bar
        /// </summary>
        /// <param name="text">Text input</param>
        /// <param name="alignCenter">Align Text</param>
        /// <param name="bColor">Background Color</param>
        /// <param name="fColor">Forground Color</param>
        public void textBar(string text,bool alignCenter,ConsoleColor bColor,ConsoleColor fColor)
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
