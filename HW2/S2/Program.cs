//Веретенников Димитрий
/*2. Написать метод подсчета количества цифр числа.*/
Console.WriteLine("Программа подсчета количества цифр числа");
string a = Console.ReadLine();
int count = 0;
foreach (char c in a){
    if(Char.IsNumber(c)) {
        count++; 
    }
}
Console.WriteLine("Количество цифр в числе: " + count);


