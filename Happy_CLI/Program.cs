// See https://aka.ms/new-console-template for more information
using Happy_CLI;
ColorText colorText = new ColorText();
colorText.writeLine("hello word",ConsoleColor.Green);
colorText.writeLine("hellonima", ConsoleColor.Red, ConsoleColor.White);
colorText.write("hello guy", ConsoleColor.Cyan);
colorText.write("i am nima", ConsoleColor.Blue);
colorText.write("mohammadi", ConsoleColor.Cyan,ConsoleColor.DarkGray);
Console.WriteLine();
colorText.RepeatCharacter('-', 20);
