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
## Задача 9
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

## Задача 10
```

int Max(int arg1,int arg2,int arg3)
{
	int result = arg1;
	if(arg2>result) result = arg2;
	if(arg3>result) result = arg3;
	return result;
}

int a1 = 13;
int a2 = 34;
int a3 = 1234;
int b1 = 23;
int b2 = 11;
int b3 = 912345;
int c1 = 1;
int c2 = 8;
int c3 = 90;

int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1,max2,max3);

Console.WriteLine(max);

```
## Задача 11
```


int Max(int arg1,int arg2,int arg3)
{
	int result = arg1;
	if(arg2>result) result = arg2;
	if(arg3>result) result = arg3;
	return result;
}
//             0   1 2 3  4 5 6  7 8
int[] array = {43,45,2,6,76,1,86,7,5};

int max1 = Max(array[0],array[1],array[2]);
int max2 = Max(array[3],array[4],array[5]);
int max3 = Max(array[6],array[7],array[8]);
int max = Max(max1,max2,max3);

Console.WriteLine(max);
```
## Задача 12
```
int []array = {1,45,49,4,65,12,78};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
	if(array[index]==find)
    
	{
		Console.WriteLine(index);
		break;
	}
    index++;
} 

```
## Задача 13
```
void FillArray(int []collection)

{
	int length = collection.Length; 
    int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(1,10);	
		index++;
	}

}

void PrintArray(int []col)

{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.WriteLine(col[position]);
		position++;
	}
}

int []array = new int[10];

FillArray(array);
PrintArray(array);
```
## Задача 14
```
void FillArray(int []collection)

{
	int length = collection.Length; 
    int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(1,10);	
		index++;
	}

}

void PrintArray(int []col)

{
	int count = col.Length;
	int position = 0;
	while (position < count)
	{
		Console.WriteLine(col[position]);
		position++;
	}
}

int IndexOf(int[] collection, int find)//int IndexOf(int []collection, int find)

{
	int count = collection.Length;                 //int count = collection.Lenght;
	int index = 0;
  	int position = -1; // -1 
	while (index < count)
	{
		if(collection[index] == find)
		{
			position = index;
			break;
		}
		index++;
	}
    return position;
}



int []array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos1 = IndexOf(array, 4);//int pos = IndexOf(array, 4);
Console.WriteLine(pos1);

```
## Задача 14 ver find
```
