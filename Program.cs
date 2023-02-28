/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/
/*
int N = new Random().Next(100,1000); Console.WriteLine(N);
if(100 <= N || N <= 999){int Sec = N / 10 % 10; Console.WriteLine(Sec);}*/


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/
/*
Console.WriteLine("Введите число"); 
int N = Convert.ToInt32(Console.ReadLine());
if(N > 99 && N < 1000){int result = N % 10; Console.WriteLine(result);}
else if(N < 100){Console.WriteLine("Число не имеет третьей цифры");}
else if(N > 999){{while(N > 999){N /= 10;}} int result = N % 10; Console.WriteLine(result);}*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.*/

Console.WriteLine("Введите цифру от 1 до 7");
int N = Convert.ToInt32(Console.ReadLine());

if(N > 7 || N < 1){Console.WriteLine("Не правильное значение, повторите попытку!!!");}
else {if(N == 1){Console.Write("Понедельник ");}
else if(N == 2){Console.Write("Вторник ");}
else if(N == 3){Console.Write("Среда ");}
else if(N == 4){Console.Write("Четверг ");}
else if(N == 5){Console.Write("Пятница ");}
else if(N == 6){Console.Write("Суббота ");}
else if(N == 7){Console.Write("Воскресенье ");}}
if(N == 6 || N == 7){Console.WriteLine("- Выходной день");}
else{Console.WriteLine("- Рабочий день");}
