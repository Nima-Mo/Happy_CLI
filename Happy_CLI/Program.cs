using Happy_CLI;

AdvText adv = new AdvText();
OutPutStyle outPutStyle = new OutPutStyle();

adv.write("hello word");
adv.write("hello word",ConsoleColor.Green);
adv.write("hello word", ConsoleColor.Green,ConsoleColor.Gray);
adv.posTop = 0;
adv.posLeft = 0;
for (int i = 0; i < 10; i++)
{
    adv.positionTextAt("  ",i,i+1,ConsoleColor.Green,ConsoleColor.Red);
}
adv.FlashingText("wink",-1,ConsoleColor.Cyan,ConsoleColor.Red);
adv.newLine();

adv.arrow("nima mohammadi",10,ConsoleColor.Cyan,ConsoleColor.Red,true);
adv.arrow("nima mohammadi", 10, ConsoleColor.Cyan, ConsoleColor.Red,20,20, true);

string[] list = 
    {
    "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat",
    "Luca", "Mads", "Luke", "Dinesh","206-555-0108", "425-555-0001",
    "Karen", "Suma", "Frances","Hanying Feng","650-555-0199",
    };

outPutStyle.ColumnarText(list,5,5,ConsoleColor.Green);
outPutStyle.ColumnarText(list, 5, 5, ConsoleColor.Green,ConsoleColor.Gray);
outPutStyle.textBar("hello gayshjgjhjgjgjghjjghjghjghjghjhhgjghjgjgjgjgjhjgjgjgjgjgjgjgjgj",Align.CENTRT,ConsoleColor.White,ConsoleColor.Green);
outPutStyle.olListChar(list,false,ConsoleColor.Green,ConsoleColor.Magenta,"-->");
outPutStyle.olListNumber(list, ConsoleColor.Green, ConsoleColor.Magenta,"-->");

List<string> list2 = new List<string>();
list2.Add("Sun,Mon,Tue,Wed,TTTTTTTTTTThu,Fri,Sat");
list2.Add("Sun,Mon,Tue,Wed,Thu,Fri,Sat");
list2.Add("Sun,Mon,Tue,Wed,Thu,Fri,Sat");
list2.Add("Sun,Mon,Tue,Wed,Thu,Fri,Sat");
list2.Add("Sun,Mon,Tue,Wed,Thu,Fri,Sat");

Table table = new Table("my table my my", "this is test", "SunC,MonC,TueC,WedC,ThuC,FriC,SatC", list2);
table.drawTable(ConsoleColor.Red,ConsoleColor.Green);



