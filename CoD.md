# Лекция 1
## Задача 1
```
// (//) - комментарии 
Console.WriteLine("2 Hello, World!");
Console.WriteLine("2 Hello, World!");
Console.WriteLine("2 Hello, World!");
```
## Задача 2
```
Console.WriteLine("Введите ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username);
```
## Задача 3
```
int NumberA = 13;
int NumberB = 5;
int result = NumberA+NumberB;
Console.WriteLine(result);
```
## Задача 4
```
double NumberA = 18;
double NumberB = 5;
Console.WriteLine(NumberA/NumberB);
```
## Задача 5
```
int NumberA = new Random().Next(1,10);         // 1,2,3,4,5.....
int NumberB = new Random().Next(1,10);
Console.WriteLine(NumberA);
Console.WriteLine(NumberB);
int result = NumberA + NumberB;
Console.WriteLine(result);
```
## Задача 6
```
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
```
## Задача 7
```
// задача - гири(определить максимальный вес гири)
int a = new Random().Next(1,100);
int b = new Random().Next(1,100);
int c = new Random().Next(1,100);
int d = new Random().Next(1,100);
int e = new Random().Next(1,100);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);

int max = a;

if (b>max)
{
        max=b;
}
if (c>max)
{
        max=c;
}
if (d>max)
{
        max=d;
}
if (e>max)
{
        max=e;
}
Console.Write("max = ");
Console.WriteLine(max);
```
## Задача 8

```
Console.Clear();

int xa = 1;
int ya = 1;
int xb = 1;
int yb = 15;
int xc = 15;
int yc = 15;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("*");

int x = xa, y = xb;

int count = 0;

while (count < 100)
{
    int what = new Random().Next(0,3);
    if(what == 0)
        {
            x = (x+xa) / 2;
            y = (y+ya) / 2;
        }
    if(what == 1)
        {
            x = (x+xb) / 2;
            y = (y+xb) / 2;
        }    
    if(what == 2)
        {
            x = (x+xc) / 2;
            y = (y+yc) / 2;
        }    

Console.SetCursorPosition(x, y);
Console.WriteLine("*");
count ++;}

```
## Задача 8
```
// найти наибольшее значение

int a1 = 13;
int a2 = 34;
int a3 = 44;
int b1 = 1234;
int b2 = 11;
int b3 = 99;
int c1 = 1;
int c2 = 8;
int c3 = 90;

int max = a1;

if (b1>max) max = b1;
if (c1>max) max = c1;
if (a2>max) max = a2;
if (b2>max) max = b2;
if (c2>max) max = c2;
if (a3>max) max = a3;
if (b3>max) max = b3;
if (c3>max) max = c3;

Console.WriteLine(max);
```