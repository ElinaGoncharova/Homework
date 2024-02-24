// 1 ЗАДАЧА:
// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23

// пример: 
// а = 50  => нет
// а = 7   => нет
// а = 322 => да


// РЕШЕНИЕ

// int a = 322;
// int b = 7;
// int c = 23;

// if (a % b == 0  && a % c == 0)
// {
//     Console.WriteLine("Нет");
// }
// else
// {
//     Console.WriteLine("Да");
// }

// 2 ЗАДАЧА 

// Напишите программу, которая принимает на вход координаты точки (X и Y),причем X неравен 0,  
// Y неравен 0 и выдает номер координатной четверти плоскости, в которой находится эта точка.

// пример: 
// 2, 3    => 1   ++
// -5, 3   => 2   -+
// -3, -2  => 3   --
// 4, -2   => 4   +-

// int x = 2;
// int y = 3;


// РЕШЕНИЕ:

// if (x!=0 && y!=0)
// {
//     if (x > 0 && y > 0)
//         {
//             Console.WriteLine("1");
//         }
//     if (x < 0 && y > 0)
//         {
//             Console.WriteLine("2");
//         }
//     if (x < 0 && y < 0)
//         {
//             Console.WriteLine("3");
//         }
//     if (x > 0 && y < 0)
//         {
//             Console.WriteLine("4");
//         }
// }


// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// пример:
// 40 => 4
// 96 => 9
// 72 => 7

// // РЕШЕНИЕ

// int c = 72; // ввод числа в переменную с

// int a = 10;
// int b = 99;
// int numFirst = c / 10;
// int numSecond = c % 10;

// if (c <= b && c >= a)
// if (numFirst == numSecond)
// { Console.WriteLine(numFirst + " = " + numSecond);}
// if (numFirst > numSecond)
// {    Console.WriteLine(numFirst);}
// if (numFirst < numSecond)
// {Console.WriteLine(numFirst);}


// 4 ЗДАЧА
// Напишите программу, которая на вход принимает натуральное 
// число N, а на выходе показывает его цифры через запятую.

//пример:
//  568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

// РЕШЕНИЕ:

int n = 9542;
int divisor = 1;

while (divisor * 10 <= n){
     divisor = divisor * 10;}

while (divisor > 0){
int digit = n / divisor;
 Console.Write(digit);

if (divisor > 1) {
Console.Write(", ");
            }
 {n %= divisor;
 divisor /= 10;}
}
