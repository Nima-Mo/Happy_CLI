using Happy_CLI;

AdvText advtext = new AdvText();
OutStyle outStyle = new OutStyle();

SortedList<string,string> slist = new SortedList<string,string>();
slist.Add("niam", "mohammadi");
slist.Add("liana", "mohammadi");
slist.Add("parisa", "mohammadi");
slist.Add("parisadfg", "mohammadigdfgdfgfdgfgdfgdfgfdgfdgfdg");

outStyle.listComment(slist,ConsoleColor.Green,ConsoleColor.Red
    , ConsoleColor.Yellow,ConsoleColor.Blue, 2);

