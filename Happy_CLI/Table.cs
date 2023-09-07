using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_CLI
{
    public class Table:OutPutStyle
    {
        private string _title;
        private string _description;
        private List<string> _columns;
        protected const char sep = '|';
        public Table(string title,string description) 
        {
            _title = title;
            _description = description;
        }
        protected void printColumn(char typeLine,ConsoleColor lineColor,ConsoleColor titleColor)
        {
            string temp = string.Empty;
            temp = sep.ToString();
            foreach (var column in _columns)
            {
                temp += string.Format("{0,5}|",column);
            }
            this.printLine(temp.Length, lineColor, typeLine);
            this.writeLine(sep.ToString() + this.title + sep.ToString(), titleColor);
            this.printLine(temp.Length, lineColor, typeLine);
            this.writeLine(temp);
            this.printLine(temp.Length, lineColor, typeLine);

        }
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public List<string> columns
        {
            get { return _columns; }
            set { _columns = value; }
        }
        public void printTable(char typeLine, ConsoleColor lineColor, ConsoleColor titleColor)
        {
            this.printColumn(typeLine,lineColor,titleColor);

        }

    }
}
