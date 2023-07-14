using Happy_CLI;
using System.Runtime.InteropServices.JavaScript;

AdvText advtext = new AdvText();
OutStyle outStyle = new OutStyle();

SortedList<string,string> slist = new SortedList<string,string>();
string[][] dialog = new string[2][];
dialog[0] = new string[4] {"dialog1",
    "tow = Array does not have that many dimensions.",
    "tree Array does not have that many dimensions.",
    "for Array does not have that many dimensions."
};
dialog[1] = new string[4] { "dialog2", "tow", "tree", "for" };

outStyle.dialog(dialog,ConsoleColor.Red,ConsoleColor.Green);