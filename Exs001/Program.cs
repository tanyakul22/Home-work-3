﻿Console.Write("Введите пятизначное число для проверки на полиндром: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int c = a;
while(c > 0)
{
    b = b * 10 + c % 10;
    c = c/10;
}
if (a==b) Console.Write("{0} число полиндром", a);
else Console.Write("{0} число не полиндром", a);
