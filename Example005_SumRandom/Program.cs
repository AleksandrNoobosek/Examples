// Console.WriteLine вывести в новую строку
// Console.ReadLine ввод переменной
// string - строка, своего рода контейнер обьема памяти Пример :string username = Console.ReadLine (); ------без("")
// string username = Console.ReadLine (""); -команда для ввода данных в строке
// Console.WriteLine(username); вывод введенной переменной (без"")
// Console.WriteLine("Введите ваше имя "); -пробел после текста и закрываю скобки, новвроде без этого тоже работает прога
//Console.Write("Привет, "); Console.Write("Привет, "); ----вывод в одну строку
// (//) - комментарии 
// int -для хранения целых чисел
// NumberA --при наисенование цифра не должна стоять на первом месте
// int result переменная которой присвоили сумму (int result = NumberA+NumberB;)
// Double- контейнер который позволяет работать  с вещественными числами (Double NumberA = 13;)
//int - целое 32 разрядое число со знаком от -2147483648 до 2147483647
//double- 64 разрядное целое число со знаком 
//string------- от 0 до много символов
// bool------- логический тип даных true and false истина или ложь
// + -  / * %(нахождение остатка от деления) ()

int NumberA = new Random().Next(1,10);         // 1,2,3,4,5.....
int NumberB = new Random().Next(1,10);
Console.WriteLine(NumberA);
Console.WriteLine(NumberB);
int result = NumberA + NumberB;
Console.WriteLine(result);