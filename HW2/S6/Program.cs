﻿//Пока не готова
//Веретенников Димитрий
/*6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.*/
int a = 0;
int b = 0;
int c = 0;
int count = 0;

for(int i = 1; i <= 100; i++){
   c = i;
   while(c > 0){
       a = a + (c%10);
       c = c / 10;
   }
   b = i%a;
   if(b == 0){
       count++;
       Console.Write($"{i}, ");
   }
}

Console.WriteLine($"Хороших цифр{count}");