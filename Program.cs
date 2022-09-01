// Задача4* (со звёздочкой). Программа которая принимает на вход координаты двух точек A и В
//и находит между ними в 2D пространстве расстояние 

// A (3,6); В (2,1) => 5,099
// A(7,-5); B (1,-1) => 7,21
/*
Console.WriteLine ("");
Console.WriteLine ("Давайте найдем расстояние между точками в пространстве"); 
Console.WriteLine ("");
// Метод Рассчета расстояния и вывод данных
void Distance (int x1, int x2, int y1, int y2){
    Console.Write ("Расстояние: " + Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1)));
    Console.WriteLine (""); 
    }
// Ввод данных
Console.Write ("Введите координаты Х точки А: "); 
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Y точки А: "); 
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Х точки В: "); 
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Y точки B: "); 
int y2 = Convert.ToInt32(Console.ReadLine());

Distance (x1, x2, y1, y2);
*/

// Домашнее задание. 
// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine (""); 
Console.WriteLine ("Давайте определим является ли число палиндромом");
Console.WriteLine ("");
// Вычленение цифры. Метод возвратный
int Palindrome(int num){
    int num4 = num /10 % 10;
    int num2 = num /1000 % 10;
    int num5 = num % 10;
    int num1 = num /10000;
    if (num4==num2 && num5==num1) Console.WriteLine ("Число " + num + " является палиндромом");   
    else Console.WriteLine ("Число " + num + " не является палиндромом");   
    Console.WriteLine ("");
    return num;
}
// Ввод данных
Console.Write ("Введите пятизначное число число: "); 
int num = Convert.ToInt32(Console.ReadLine());
if(num<10000 || num>99999){
    Console.WriteLine ("Не корректный ввод");
}
else {
    Palindrome(num);
}

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("");
Console.WriteLine ("Давайте найдем расстояние между точками в пространстве"); 
Console.WriteLine ("");
// Метод Рассчета расстояния и вывод данных
void Distance (int x1, int x2, int y1, int y2, int z1, int z2){
    Console.Write ("Расстояние: " + Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1))); 
    Console.WriteLine ("");
    }
// Ввод данных
Console.Write ("Введите координаты Х точки А: "); 
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Y точки А: "); 
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Z точки А: "); 
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Х точки В: "); 
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Y точки B: "); 
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите координаты Y точки B: "); 
int z2 = Convert.ToInt32(Console.ReadLine());

Distance (x1, x2, y1, y2, z1, z2);


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("");
Console.WriteLine ("Давайте найдем куб каждого числа от 1 до N"); 
Console.WriteLine ("");
// Метод поиск квадратов и вывод
void Square(int n){
    int i=1;
    while (i<=n) {
        Console.Write (i*i*i +", ");
        i ++;
    }
}
// Ввод данных
Console.Write ("Введите число N: "); 
int n = Convert.ToInt32(Console.ReadLine());
if (n<= 0) Console.Write ("Некорректный ввод");
else Square(n);

