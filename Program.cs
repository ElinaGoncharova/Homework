﻿// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23

// пример: 
// а = 50  => нет
// а = 7   => нет
// а = 322 => да


int a = 322;
int b = 7;
int c = 23;

if (a % b == 0  && a % c == 0)
{
    Console.WriteLine("Tru");
}
else
{
    Console.WriteLine("Fols");
}

