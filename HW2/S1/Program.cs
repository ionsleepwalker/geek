//Веретенников Димитрий
/*Задача 1. Рассчитать минимальное из трёх чисел.*/
Console.Write("Программа подсчета минимального из трех чисел\nВведите первое значение: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое значение: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое значение: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a < b && a < c){
    Console.WriteLine("Минимальное значение a = " + a);
} else if(b < a && b < c) {
    Console.WriteLine("Минимальное значение b = " + b);
} else {
    Console.WriteLine("Минимальное значение c = " + c);
}