

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