


Console.Write("Введите имя пользователя: ");

string username = Console.ReadLine();

if (username.ToLower() == "маша")  //ToLower ---- позволяет все символы вашей строки перевести в нижний регистр
{
    Console.Write("уРА, ");
    Console.Write(username);
}
else 
{
    Console.Write("Здорова Отец, ");
    Console.Write(username);
}