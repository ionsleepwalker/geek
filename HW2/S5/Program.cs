//Веретенников Димитрий
/* Задача 5.
а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
Console.WriteLine("Программа по расчету индекса массы Вашего тела\nВведите свой вес в кг:");
double mass = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите свой рост в метрах:");
double height = Convert.ToDouble(Console.ReadLine());
double imt = mass/(Math.Pow(height,2));
if(imt >= 18.5 && imt <= 25){
    Console.WriteLine($"Вы в отличном состоянии! Ваш индекс массы равен: {imt:F2}");
} else if(imt < 18.5 && imt > 16){
    double needs = 18.5;
    needs = (needs - imt)*(Math.Pow(height,2));
    Console.WriteLine($"У Вас недостаточная масса тела! Ваш индекс массы равен: {imt:F2}\nДля нормализации веса Вам необходимо набрать: {needs:F2}кг");
} else if (imt < 16) {
    double needs = 18.5;
    needs = (needs - imt)*(Math.Pow(height,2));
    Console.WriteLine($"Выраженный дефицит массы тела! Ваш индекс массы равен: {imt:F2}\nДля нормализации веса Вам необходимо набрать: {needs:F2}кг");
} else if (imt > 25 && imt < 30) {
    double needs = 25;
    needs = (imt - needs)*(Math.Pow(height,2));
    Console.WriteLine($"Избыточная масса тела! Ваш индекс массы равен: {imt:F2}\nДля нормализации веса Вам необходимо сбросить: {needs:F2}кг");
} else if (imt > 30 && imt < 35) {
    double needs = 25;
    needs = (imt - needs)*(Math.Pow(height,2));
    Console.WriteLine($"Ожирение 1-й степени! Ваш индекс массы равен: {imt:F2}\nДля нормализации веса Вам необходимо сбросить: {needs:F2}кг");
} else if (imt > 35  && imt < 40) {
    double needs = 25;
    needs = (imt - needs)*(Math.Pow(height,2));
    Console.WriteLine($"Ожирение 2-й степени! Ваш индекс массы равен: {imt:F2}\nДля нормализации веса Вам необходимо сбросить: {needs:F2}кг");
}
else if (imt > 40) {
    double needs = 25;
    needs = (imt - needs)*(Math.Pow(height,2));
    Console.WriteLine($"Ожирение 3-й степени! Ваш индекс массы равен: {imt:F2}\nДля нормализации веса Вам необходимо сбросить: {needs:F2}кг");
}