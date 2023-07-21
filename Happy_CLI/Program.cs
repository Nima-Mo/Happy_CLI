using Happy_CLI;

Menu menu = new Menu();
string[] lst = {"asdsa","asdasd","fhfffg","dfgdfgdg","ytuytuy","weqwere","cvxcvxc","kljkljk","7567fhgfhf" };
int num = 0;
menu.menu(lst,ref num);
Console.WriteLine(num);
