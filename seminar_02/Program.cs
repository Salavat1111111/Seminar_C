//11 - задача. Напишит епрограмму, которая выдает случайное число и удаляет вторую цифру этого числа.

Console.Clear();

int num = new Random(). Next (100, 1000);
Console.WriteLine(num);


Console.WriteLine( num / 100 * 10 + num % 10);


