using Happy_CLI;

OutPutStyle outPutStyle = new OutPutStyle();
string[] lst = {"asdsa","asdasd","fhfffg","dfgdfgdg","ytuytuy","weqwere","cvxcvxc","kljkljk","7567fhgfhf" };
SortedList<string,string> keyValues = new SortedList<string,string>();
keyValues.Add("one", "dfdsfsfsdfdsfs");
keyValues.Add("tow", "fsdfsdfsdfsdf");
outPutStyle.explanationText(keyValues,2);
outPutStyle.ColumnarText(lst, 5,2,ConsoleColor.Red,ConsoleColor.Green);





