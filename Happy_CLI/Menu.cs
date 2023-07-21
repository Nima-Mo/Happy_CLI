﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_CLI
{
    public class Menu:AdvText
    {
        public void menu(string[] strings,ref int number)
        {
            int counter = 0;
            int i = 0;
            ConsoleKeyInfo ck;
            while (true)
            {
                for(i = 0; i < strings.Length; i++) 
                {
                    if(counter == i)
                    {
                        this.writeLine("[" + i.ToString() + "]" + strings[i],ConsoleColor.Green);
                    }
                    else
                    {
                        this.writeLine("[" + i.ToString() + "]" + strings[i], ConsoleColor.White);
                    }
                }
             
                ck = Console.ReadKey();
                if(counter >= strings.Length)
                {
                    counter = 0;
                }else if(counter <= 0)
                {
                    counter = strings.Length;
                }
                if (ck.Key == ConsoleKey.DownArrow) 
                {
                    counter++;
                } else if(ck.Key == ConsoleKey.UpArrow)
                {
                    counter--;
                }else if(ck.Key == ConsoleKey.Enter)
                {
                    number = counter;
                    break;
                }
                else
                {

                }
                Console.Clear();
                i++;
            }
        }
    }
}