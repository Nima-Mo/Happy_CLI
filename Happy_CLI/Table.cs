using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_CLI
{
    public class Table:OutPutStyle
    {
        private string _tableName;
        private string _description;
        private string _columns;
        private List<string> _rows;
        private string[][] _temp;
        private string[] _tempFormating;
        public Table(string tableName, string description, string columns, List<string> rows)
        {
            _tableName = tableName;
            _description = description;
            _columns = columns;
            _rows = rows;
        }
        public string TableName 
        {
            get { return _tableName; } 
            set { _tableName = value; } 
        }
        public string Description 
        { 
            get { return _description; } 
            set { _description = value; } 
        }
        public string columns 
        {
            get { return _columns; } 
            set { _columns = value; } 
        }
        public List<string> rows 
        { 
            get { return rows; } 
            set { rows = value;} 
        }
        protected void combine(List<string> rows,string columns) 
        {
            this._rows.Insert(0, columns);
        }
        protected void spliter(List<string>rows)
        {
            this._temp = new string[rows.Count][];
            for (int i = this._temp.GetLowerBound(0);i < this._temp.GetUpperBound(0);i++)
            {
                this._temp[i] = rows[i].Split(',');
            }
        }
        protected void formating(string[][]temp)
        {
            int countSpace = temp[0][0].Length;
            try
            {
                for (int i = temp.GetLowerBound(0)+1; i < temp.GetUpperBound(0); i++)
                {
                    for (int j = temp.GetLowerBound(0)+1; j < temp.GetUpperBound(0); j++)
                    {
                        if(countSpace < temp[i][j].Length)
                        {
                            countSpace = temp[i][j].Length;
                        }
                    }
                }

                this._tempFormating = new string[temp.GetUpperBound(0)];
                for (int i = 0; i < this._tempFormating.Length; i++)
                {
                    this._tempFormating[i] = "|";
                }
                for (int i = temp.GetLowerBound(0); i < temp.GetUpperBound(0); i++)
                {
                    for (int j = temp.GetLowerBound(0); j < temp.GetUpperBound(0); j++)
                    {
                        this._tempFormating[i] += string.Format("{0,-"+countSpace.ToString()+"}|", temp[i][j]);
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                this.writeLine( "ERROR: " + e.Message,ConsoleColor.Red);
            }
            catch(ArgumentOutOfRangeException e)
            {
                this.writeLine("ERROR: " + e.Message, ConsoleColor.Red);
            }
            catch(IndexOutOfRangeException e)
            {
                this.writeLine("ERROR: " + e.Message, ConsoleColor.Red);
            }
            
        }
        protected int maxLine(string[] tempFormating)
        {
            try
            {
                int countLine = this._tempFormating[0].Length;
                for (int i = 1; i < this._tempFormating.Length; i++)
                {
                    if (countLine < this._tempFormating[i].Length)
                    {
                        countLine = this._tempFormating[i].Length;
                    }
                }
                return countLine;
            }
            catch (ArgumentNullException) 
            {
                return 0;
            }
            
        }
        public void drawTable() 
        {
            this.combine(_rows, _columns);
            this.spliter(_rows);
            this.formating(_temp);
            int countLine = this.maxLine(this._tempFormating); 
            this._tableName = this._tableName.PadRight((countLine - 2), ' ');
            this._tableName += "|";
            this.printLine(countLine);
            this.writeLine("|" + this._tableName);
            this.printLine(countLine);
            foreach (string row in this._tempFormating) 
            {
                this.writeLine(row);
                this.printLine(countLine);
            }
            this._description = this._description.PadRight((countLine - 2), ' ');
            this._description += "|";
            this.writeLine("|" + this._description);
            this.printLine(countLine);
        }
        public void drawTable(ConsoleColor cTableName, ConsoleColor cDecription)
        {
            this.combine(_rows, _columns);
            this.spliter(_rows);
            this.formating(_temp);
            int countLine = this.maxLine(this._tempFormating);
            this._tableName = this._tableName.PadRight((countLine - 2), ' ');
            this.printLine(countLine);
            this.write("|");
            this.write(this._tableName,cTableName);
            this.write("|");
            this.newLine();
            this.printLine(countLine);
            foreach (string row in this._tempFormating)
            {
                this.writeLine(row);
                this.printLine(countLine);
            }
            this._description = this._description.PadRight((countLine - 2), ' ');
            this.write("|");
            this.write(this._description,cDecription);
            this.write("|");
            this.newLine();
            this.printLine(countLine);
        }
    }
}
