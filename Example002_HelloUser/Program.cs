// Console.WriteLine вывести в новую строку
// Console.ReadLine ввод переменной
// string - строка, своего рода контейнер обьема памяти Пример :string username = Console.ReadLine (); ------без("")
// string username = Console.ReadLine (""); -команда для ввода данных в строке
// Console.WriteLine(username); вывод введенной переменной (без"")
// Console.WriteLine("Введите ваше имя "); -пробел после текста и закрываю скобки, новвроде без этого тоже работает прога
//Console.Write("Привет, "); Console.Write("Привет, "); ----вывод в одну строку
// (//) - комментарии 

Console.WriteLine("Введите ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username);