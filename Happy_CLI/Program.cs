using Happy_CLI;

AdvText adv = new AdvText();

adv.write("hello word");
adv.write("hello word",ConsoleColor.Green);
adv.write("hello word", ConsoleColor.Green,ConsoleColor.Gray);
adv.posTop = 0;
adv.posLeft = 0;
for (int i = 0; i < 10; i++)
{
    adv.positionTextAt("  ",i,i+1,ConsoleColor.Green,ConsoleColor.Red);
}
adv.wink("wink",-1,ConsoleColor.Cyan,ConsoleColor.Red);
adv.newLine();
adv.arrow("nima mohammadi",10,ConsoleColor.Cyan,ConsoleColor.Red,true);
adv.arrow("nima mohammadi", 10, ConsoleColor.Cyan, ConsoleColor.Red,20,20, true);
