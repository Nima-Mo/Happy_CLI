using Happy_CLI;

Menu menu = new Menu();
string[] lst = { };
int num = 0;
menu.waterfallMenuBox(lst,'+',ref num,ConsoleColor.Blue,ConsoleColor.Red,ConsoleColor.Green,ConsoleColor.Black,0,0);
Console.WriteLine(num);

