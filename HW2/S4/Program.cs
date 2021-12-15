//Веретенников Димитрий
/* Задача 4. Реализовать метод проверки логина и пароля.
На вход метода подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.*/
string login = "root";
string password = "GeekBrains";
int tryes = 3;
string loginCheck;
string passwordCheck;
do {
    Console.Write("Введите логин: ");
    loginCheck = Console.ReadLine();
    Console.Write("Введите логин: ");
    passwordCheck = Console.ReadLine();
    if(loginCheck != login || passwordCheck != password){
        tryes -= 1;
        Console.WriteLine("Введенные Вами данные не верны. Попыток для входа: " + tryes);
    }
    else{
        Console.WriteLine("Успешная авторизация!");
    }
} while (tryes != 0);
Console.WriteLine("Попыток больше нет!");
