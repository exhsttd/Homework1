// Упр. 1. Написать программу, которая спрашивает имя пользователя, и затем приветствует пользователя по имени.
// (Создать консольное приложение.)

Console.WriteLine("Лабораторная 1 (1.1).");
Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine();
Console.WriteLine($"Здравствуйте, {name}!");
Console.WriteLine();

// Упр.2. Упражнение 2. Написать программу, которой на вход подается два
// целых числа, на выходе – результат деления одного числа на другое.
// Предусмотреть обработку исключительной ситуации, возникающей при делении числа на ноль.
Console.WriteLine("Лабораторная 1.2.");
try
{
    Console.Write("Введите первое целое число: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double num12 = num1 / num2;
    Console.WriteLine($"Результат деления {num1} на {num2} равен {num12}.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Деление на ноль невозможно.");
}
Console.WriteLine();

// Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать
// следующую за ней букву в алфавитном порядке.
Console.WriteLine("Домашнее задание 2.1");
char letter;

while (true)
{
    Console.Write("Введите букву (кириллическую или латинскую): ");
    string eppe = Console.ReadLine().ToLower();
    
    if (eppe.Length == 1 && char.IsLetter(eppe[0])) //eppe (0) - присвоение 1го индекса;"и" чтобы обе части выполнялись 
    {
        letter = eppe[0]; // Берем первый символ как букву

        char nextLetter;

        // Проверяем, является ли буква последней в алфавите
        if (letter == 'z')
        {
            nextLetter = 'a'; 
        }
        else if (letter == 'я')
        {
            nextLetter = 'а'; 
        }
        else
        {
            nextLetter = (char)(letter + 1); // Следующая буква, если не последняя
        }
        Console.WriteLine($"Следующая буква после '{letter}' в алфавите: '{nextLetter}'");
        break;
    }
    else
    {
        Console.WriteLine("Ошибка: Введите корректную букву.");
    }
}
Console.WriteLine();

// Домашнее задание 2.2 Написать программу, которая решает квадратное уравнение.
// Входные данные – коэффициенты уравнения, выходные – найденные корни.
Console.WriteLine("Домашнее задание 2.2");
Console.WriteLine("Введите значение коэффициентов:");
Console.WriteLine("Значение а:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение б:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение с:");
double c = Convert.ToDouble(Console.ReadLine());
double D = Math.Pow(b,2) - 4 * a * c; // дискриминант
if (D > 0)
{
    double x1 = (-b+Math.Sqrt(D)) / (2 * a);
    double x2 = (-b-Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"Уравнение имеет два различных корня: x1 = {x1}, x2 = {x2}");
}
else if (D == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"Уравнение имеет один корень: x = {x}");
}
else if (D < 0);
{
    Console.WriteLine("Уравнение не имеет действительных корней");
}