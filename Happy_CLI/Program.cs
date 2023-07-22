using Happy_CLI;

Menu menu = new Menu();
string[] lst = {
    "Menu item one in system",
    "Menu item one in system",
    "Menu item one in system",
    "Menu item one in       ",
    "Menu item one in system",
    "Menu item one in system",
    "Menu item one in       ",
    "Menu item one in system",
    "Menu item one in system" 
};
int num = 0;
menu.waterfallMenu(lst, ref num, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.White, ConsoleColor.Black,5,5);
Console.WriteLine(num);
