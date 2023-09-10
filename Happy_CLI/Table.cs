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
        private string[] _temp;
        public Table() { }
        public Table(string tableName, string description, string columns, List<string> rows)
        {
            _tableName = tableName;
            _description = description;
            _columns = columns;
            _rows = rows;
        }
        public string tableName {  get { return _tableName; } set { _tableName = value; } }
        public string description { get { return _description; } set { _description = value; } }
        public string columns { get { return _columns; } set { _columns = value; } }
        public List<string> rows { get { return rows; } set { rows = value; } }
        protected void combine(List<string> rows,string columns) 
        {
            this._rows.Insert(0, columns);
        }
        protected string[] spliter(string str)
        {
            this._temp = str.Split(',');
            return this._temp;
        }

    }
}
