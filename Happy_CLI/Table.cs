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
           this._tempFormating = new string[temp.GetUpperBound(0)];
            for(int i = 0 ;i < this._tempFormating.Length; i++)
            {
                this._tempFormating[i] = "|";
            }
           for (int i = temp.GetLowerBound(0);i < temp.GetUpperBound(0); i++)
            {
                for(int j = temp.GetLowerBound(1);j < temp.GetUpperBound(1);j++) 
                {
                    this._tempFormating[i] += string.Format("{0,15}|", temp[j]);
                }
            }
        }
    }
}
