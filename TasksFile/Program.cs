// Задание 1. Вывести на экран число e (основание натурального логарифма) с точностью до десятых

using System.ComponentModel.Design;
using System.Runtime.InteropServices.JavaScript;

Console.WriteLine("Задание 1");
Console.WriteLine(Math.Round(Math.E,1));
Console.WriteLine();

// Задание 2. Вывести на экран числа 50 и 10 одно под другим.
Console.WriteLine("Задание 2");
Console.WriteLine("50");
Console.WriteLine("10");
Console.WriteLine();

// Задание 3. Составить программу вывода на экран «столбиком» четырех любых чисел.
Console.WriteLine("Задание 3");
Console.WriteLine("3");
Console.WriteLine("6");
Console.WriteLine("7");
Console.WriteLine("4");
Console.WriteLine();

// Задание 4. Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
Console.WriteLine("Задание 4");
string kek = Console.ReadLine();
int newkek = Convert.ToInt32(kek);
Console.WriteLine(newkek + 10);
Console.WriteLine();

// Задание 5. Дана сторона квадрата. Найти его периметр.
Console.WriteLine("Задание 5");
int lol = 2;
Console.WriteLine(lol * 4);
Console.WriteLine();

// Задание 6. Дан радиус окружности. Найти длину окружности и площадь круга.
Console.WriteLine("Задание 6");
int kek1 = 2;
Console.WriteLine(2 * Math.PI * kek1);
Console.WriteLine();

// Задание 7. Найти значение y=cos(x)
Console.WriteLine("Задание 7");
Console.WriteLine(Math.Cos(Math.PI));
Console.WriteLine();

// Задание 8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
Console.WriteLine("Задание 8");
int v = 2;
int o1 = 4;
int o2 = 3;
Console.WriteLine((Math.Sqrt(Math.Pow(o1,2) + Math.Pow(o2,2)))*2 + v + o1 + o2);
Console.WriteLine();

// Задание 9.
Console.WriteLine("задание 9");
int applePrice = 52, cookiePrice = 78, sweetPrice = 90;
double appleAmount = 2, cookieAmount = 0.2, sweetAmount = 0.3;
Console.WriteLine(applePrice * appleAmount + cookiePrice * cookieAmount + sweetPrice * sweetAmount);
Console.WriteLine();


// Задание 10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май".
Console.WriteLine("Задание 10");
Console.WriteLine("Мир Труд Май");
Console.WriteLine("Мир");
Console.WriteLine("\tТруд");
Console.WriteLine("\t\tМай");
Console.WriteLine();

// Задание 11. Программа просит пользователя ввести 2 числовые переменные. А после она
// меняет их местами и выводит результат на экран. Но, так как пользователь может
// ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
// например, букву или строку, а так же учесть, что число может быть дробным, и для
// выделения её дробной части одни используют точку, другие – запятую.
Console.WriteLine("Задание 11");
try
{
    Console.WriteLine("Введите 1 число");
    string F = Console.ReadLine().Replace(',', '.');
    Console.WriteLine("Введите 2 число");
    string T = Console.ReadLine().Replace(',', '.');
    
    double F1 = Convert.ToDouble(F);
    double T1 = Convert.ToDouble(T);
    Console.WriteLine($"Вы ввели: {T1}{F1}");
}
catch (Exception)
{
    Console.WriteLine("Возникло исключение!");
}
Console.WriteLine();

// Задание 12. Программа для подсчета периметра и площади фигур (треугольник,
// четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
// будет считать – площадь или периметр. Задаётся все необходимые значения, а на
// основе полученных результатов, программа должна подсчитать, какими могли бы
// быть периметры или площади остальных фигур.
Console.WriteLine("Задание 12");
Console.WriteLine("Выберите фигуру:");
Console.WriteLine("Нажмите 1 - треугольник");
Console.WriteLine("Нажмите 2 - четырехугольник");
Console.WriteLine("Нажмите 3 - круг");

int figure = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Что хотите вычислить?");
Console.WriteLine("Нажмите 1 - площадь");
Console.WriteLine("Нажмите 2 - периметр");
int choice = Convert.ToInt32(Console.ReadLine());

if (figure == 1) //треугольник
{
    if (choice == 1) //площадь
    {
        Console.Write("Введите основание:");
        double osntr = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту:");
        double hitr = Convert.ToDouble(Console.ReadLine());
        double artr = 0.5*osntr*hitr;
        Console.WriteLine("Площадь треугольника равна"+artr);
    }
    else //периметр
    {
        Console.Write("Введите длины сторон:");
        double atr = Convert.ToDouble(Console.ReadLine());
        double btr = Convert.ToDouble(Console.ReadLine());
        double ctr = Convert.ToDouble(Console.ReadLine());
        double ptr = atr + btr + ctr;
        Console.WriteLine("Периметр треугольника равен:" + ptr);
    }
}
else if (figure == 2) //четырехугольник
{ 
    if (choice == 1) //площадь
    {
        Console.Write("Введите длину:");
        double lengthqu = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите ширину:");
        double widthqu = Convert.ToDouble(Console.ReadLine());
        double arqu = lengthqu*widthqu;
        Console.WriteLine("Площадь четырехугольника равна:" + arqu);
    }
    else //периметр
    {
        Console.Write("Введите длины сторон:");
        double aqu = Convert.ToDouble(Console.ReadLine());
        double bqu = Convert.ToDouble(Console.ReadLine());
        double cqu = Convert.ToDouble(Console.ReadLine());
        double dqu = Convert.ToDouble(Console.ReadLine());
        double pqu = aqu + bqu + cqu + dqu;
        Console.WriteLine("Периметр четырехугольника равен:" + pqu);
    }
}
else if (figure == 3) //круг
{
    Console.Write("Введите радиус:");
    double rci = Convert.ToDouble(Console.ReadLine());
    
    if (choice == 1) //площадь
    {
        double arci = Math.PI * Math.Pow(rci,2) ;
        Console.WriteLine("Площадь круга равна:" + arci);
    }
    else //периметр
    {
        double pci = 2 * Math.PI*rci;
        Console.WriteLine("Периметр круга равен:" + pci);
    }
}
else
{
    Console.WriteLine("Неверный выбор фигуры");
}
Console.WriteLine();

// задание 13. Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
// числу должно предшествовать сообщение «Вы ввели число».
Console.WriteLine("Задание 13");
Console.WriteLine("Введите число");
string epe = Console.ReadLine();
Console.WriteLine($"Вы ввели число: {epe}");
int epe1 = Convert.ToInt32(epe);
Console.WriteLine();

// задание 14. Составить программу вывода на экран следующей информации: 2 кг 13 17
Console.WriteLine("Задание 14");
Console.WriteLine("2 кг");
Console.WriteLine("13 17");
Console.WriteLine();

// задание 15. Составить программу вывода на экран «столбиком» четырех случайных чисел.
Console.WriteLine("Задание 15");
Random Yuppi = new Random();
int value1 = Yuppi.Next();  
int value2 = Yuppi.Next(); 
int value3 = Yuppi.Next(); 
int value4 = Yuppi.Next(); 
Console.WriteLine(value1);
Console.WriteLine(value2);
Console.WriteLine(value3); 
Console.WriteLine(value4);
Console.WriteLine();

//задание 16. Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)
Console.WriteLine("Задание 16");
Console.WriteLine("Введите значение коэффициентов:");
Console.WriteLine("Значение а:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение б:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Значение с:");
double c = Convert.ToDouble(Console.ReadLine());
double D = Math.Pow(b,2)-4 * a * c; // дискриминант
if (D > 0)
{
    double x11 = (-b+Math.Sqrt(D)) / (2* a);
    double x22 = (-b-Math.Sqrt(D)) / (2* a);
    Console.WriteLine($"Уравнение имеет два различных корня: x1 = {x11}, x2 = {x22}");
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
Console.WriteLine();

// Задание 17. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
Console.WriteLine("Задание 17");
Console.WriteLine("Даны числа: 2 и 4. Что вы хотите вычислить?");
Console.WriteLine("Нажмите 1 - среднее арифметическое");
Console.WriteLine("Нажмите 2 - среднее геометрическое");
int choice1 = Convert.ToInt32(Console.ReadLine());
int me = 2;
int ne = 4;

if (choice1 == 1)
{
    int sum = (me + ne) / 2;
    Console.WriteLine("Среднее арифетическое чисел = " + sum);
}
else if (choice1 == 2)
{
    double geom = Math.Sqrt(me*me);
    Console.WriteLine("Среднее геометрическое чисел = " + geom);
}
Console.WriteLine();

// Задание 18. Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
Console.WriteLine("Задание 18");
Console.WriteLine("Введите координаты первой точки (x1, y1):");
Console.Write("x11: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y11: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки (x2, y2):");
Console.Write("x22: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y22: ");
double y2 = Convert.ToDouble(Console.ReadLine());
double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между точками: {dist}");
Console.WriteLine();

// задание 19. Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:
// а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
// б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
Console.WriteLine("задание 19");

Console.WriteLine("Введите значение а:");
int a11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b:");
int b11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение c:");
int c11 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какую смеху вы хотите использовать?");
Console.WriteLine("Нажмите 1 - b присвоить значение c, а присвоить значение b, с присвоить значение а");
Console.WriteLine("Нажмите 2 - b присвоить значение а, с присвоить значение b, а присвоить значение с");
int choice11 = Convert.ToInt32(Console.ReadLine());

if (choice11 == 1)
{ 
    Console.WriteLine($"Перед обменом: a = {a11}, b = {b11}, c = {c11}"); // пункт а
    int a21 = a11;
    int b21 = b11;
    int c21 = c11; // сохраняем значения а11,б11,с11
    a11 = b21;
    b11 = c21;
    c11 = a21;
    Console.WriteLine($"После обмена: a = {b21}, b = {c21}, c = {a21}");
}
else if (choice11 == 2)
{
    Console.WriteLine($"Перед обменом: a = {a11}, b = {b11}, c = {c11}");
    int a31 = a11;
    int b31 = b11;
    int c31 = c11;
    a11 = c31;
    b11 = a31;
    c11 = b31;
    Console.WriteLine($"После обмена: a = {c31}, b = {a31}, c = {b31}");
}
Console.WriteLine();

// задание 20. С начала суток прошло n секунд. Определить:
// а) сколько полных часов прошло с начала суток;
// б) сколько полных минут прошло с начала очередного часа;
// в) сколько полных секунд прошло с начала очередной минуты.

Console.WriteLine("задание 20");
Console.WriteLine("Напишите количество секунд с начала суток");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Что хотите определить?");
Console.WriteLine("Нажмите 1 - Сколько полных часов прошло с начала суток");
Console.WriteLine("Нажмите 2 - Сколько полных минут прошло с начала очередного часа");
Console.WriteLine("Нажмите 3 - Сколько полных секунд прошло с начала очередной минуты");
int choice20 = Convert.ToInt32(Console.ReadLine());
if (choice20 == 1)
{
    int hours = n / 3600;
    Console.WriteLine("Полных часов прошло с начала суток =" + hours);
}
else if (choice20 == 2)
{
    int minutes = (n % 3600) / 60;
    Console.WriteLine("полных минут прошло с начала очередного часа =" + minutes);
}
else if (choice20 == 3)
{
    int seconds = n % 60;
    Console.WriteLine("Полных секунд прошло с начала очередной минуты =" + seconds);
}
Console.WriteLine();

// Задание 21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?
Console.WriteLine("Задание 21");
int shirina = 543;  
int visyata = 130; 
int kvadrati = 130; 

int kradratiPOshir = shirina / kvadrati;
int kradratiPOvis = visyata / kvadrati;
int vsekvadrati = kradratiPOshir*kradratiPOvis;
Console.WriteLine($"Количество квадратов со стороной {kvadrati} мм, которые можно отрезать от прямоугольника = " +
                  $"{vsekvadrati}");
Console.WriteLine();

// Задание 22. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале.
// Найти полученное число.    
Console.WriteLine("задание 22");
int number;
while (true)
{
    Console.Write("Введите трехзначное число: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out number))
    {
        if (number >= 100 && number <= 999)
            break;
        
        else
        {
            Console.WriteLine("Ошибка! Введите трехзначное число");
        }
    }
    else
    {
        Console.WriteLine("Ошибка! Введите трехзначное число");
    }
}
Console.WriteLine($"Вы ввели трехзначное число: {number}");
int num3 = number % 10;
int num12 = number / 10;
int num123 = num3 * 100 + num12;
Console.WriteLine($"Полученное число: {num123}");

Console.WriteLine();

// Задание 23. Дано натуральное число n (n > 999). Найти: а) число сотен в нем; б) число тысяч в нем.
Console.WriteLine("Задание 23");
int n1;
while (true)
{
    Console.Write("Введите четырехзначное число: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out n1))
    {
         if (n1 > 999)
            break;
         else
         {
             Console.WriteLine("Ошибка! Введите черетыхзначное число");
         }
    }
    else
    {
        Console.WriteLine("Ошибка! Введите черетыхзначное число");
    }
}
Console.WriteLine($"Вы ввели черетыхзначное число: {n1}");
Console.WriteLine("Задание 23");
int n11;
while (true)
{
    Console.Write("Введите четырехзначное число: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out n11))
    {
        if (n11 > 999)
            break;

        else
        {
            Console.WriteLine("Ошибка! Введите черетыхзначное число");
        }
    }
    else
    {
        Console.WriteLine("Ошибка! Введите черетыхзначное число");
    }
}
Console.WriteLine($"Вы ввели черетыхзначное число: {n11}");
Console.WriteLine("Выберите действие:");
Console.WriteLine("Нажмите 1 - число сотен в нем");
Console.WriteLine("Нажмите 2 - число тысяч в нем");
int choice30 = Convert.ToInt32(Console.ReadLine());
if (choice30 == 1)
{
    int hundreds = (n11 / 100) % 10;
    Console.WriteLine($"Число сотен: {hundreds}");
}

if (choice30 == 2)
{
    int thousands = (n11 / 1000) % 10;
    Console.WriteLine($"Число тысяч: {thousands}");
}
Console.WriteLine();

// Задание 24. Дано четырехзначное число. Найти:
// а) число, полученное при прочтении его цифр справа налево;
// б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
// заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
// в) число, образуемое при перестановке второй и третьей цифр заданного числа. Например, из числа 5084 получить 5804;
// г) число, образуемое при перестановке двух первых и двух последних цифр
// заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.
Console.WriteLine("Задание 24");
int ui = 1234;
Console.WriteLine($"Дано четырехзначное число: {ui}");
Console.WriteLine("Найти:");
Console.WriteLine("1 - число, полученное при прочтении его цифр справа налево");
Console.WriteLine("2 - число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа");
Console.WriteLine("3 - число, образуемое при перестановке второй и третьей цифр заданного числа");
Console.WriteLine("4 - число, образуемое при перестановке двух первых и двух последних цифр заданного числа");
int choice40 = Convert.ToInt32(Console.ReadLine());
if (choice40 == 1)
{
    int reversion = (ui % 10) * 1000 + // Последняя цифра становится первой
                         ((ui / 10) % 10) * 100 + // Третья цифра становится второй
                         ((ui / 100) % 10) * 10 + // Вторая цифра становится третьей
                         (ui / 1000); // Первая цифра становится последней
    Console.WriteLine($"Число, полученное при прочтении справа налево: {reversion}");
}
if (choice40 == 2)
{
    int n111 = (ui / 1000) % 10;// Первая цифра
    int n12 = (ui / 100) % 10;  // Вторая цифра
    int n13 = (ui / 10) % 10;   // Третья цифра
    int n14 = ui % 10;          // Четвертая цифра
    int change = n12 * 1000 + n111 * 100 + n14 * 10 + n13;
    Console.WriteLine($"Число при перестановке первой и второй, третьей и четвертой цифр: {change}");
}
if (choice40 == 3)
{
    int n21 = (ui / 1000) % 10; // Первая цифра
    int n22 = (ui / 100) % 10;  // Вторая цифра
    int n23 = (ui / 10) % 10;   // Третья цифра
    int n24 = ui % 10;          // Четвертая цифра

    // Формируем новое число с перестановленными второй и третьей цифрами
    int change2 = n21 * 1000 + n23 * 100 + n22 * 10 + n24;
    Console.WriteLine($"Число при перестановке второй и третьей цифр: {change2}");
}
if (choice40 == 4)
{
    int n31 = (ui / 1000) % 10; // Первая цифра
    int n32 = (ui / 100) % 10;  // Вторая цифра
    int n33 = (ui / 10) % 10;   // Третья цифра
    int n34 = (ui % 10); //четвертаяя цифра
    int rearrangedNumber = n33 * 1000 + n34 * 100 + n31 * 10 + n32;
    Console.WriteLine($"Число при перестановке двух первых и двух последних цифр: {rearrangedNumber}");
}
Console.WriteLine();

// Задание 25. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10,
// а к частному слева приписали последнюю цифру числа x, то получилось число n.
// Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом число десятков в n не равно нулю.
Console.WriteLine("Задание 25");
Console.Write("Введите число n (100 =< n =< 999 и десятки не равны 0): ");
int n2024 = Convert.ToInt32(Console.ReadLine());
if (n2024 < 100 || n2024 > 999 || (n2024 / 10) % 10 == 0)
{
    Console.WriteLine("Ошибка: число n должно находиться в диапазоне от 100 до 999 и десяток не должен быть равен 0.");
    return;
}

// условно хотим qwe
bool net = false;
for (int e = 1; e <= 9; e++) 
{
    int qwe = n2024 - 100 * e; 
    if (qwe >= 0 && qwe <= 99)
    {
        int q = qwe / 10; 
        int w = qwe % 10; 
        int x =100 * q + 10 * w+ e ;
        if (x >= 100 && x <= 999)
        {
            Console.WriteLine($"Найдено число x: {x}");
            net = true;
        }
    }
}
 Console.WriteLine();

// Задание 26. Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
// времени: «h часов, m минут, s секунд». Определить угол (в градусах) между
// положением часовой стрелки в начале суток и в указанный момент времени.
// See https://aka.ms/new-console-template for more information
// Задание 26. Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
// времени: «h часов, m минут, s секунд». Определить угол (в градусах) между
// положением часовой стрелки в начале суток и в указанный момент времени.
 Console.WriteLine("задание 26");
 int h; // час
 while (true)
 {
     Console.Write("Введите число часов от 0 до 23: ");
     string input = Console.ReadLine();
     if (int.TryParse(input, out h))
     {
         if (h > 0 && h < 23)
             break;

         else
         {
             Console.WriteLine("Ошибка! Введите число от 0 до 23");
         }
     }
     else
     {
         Console.WriteLine("Ошибка! Введите число от 0 до 23");
     }
 }
 Console.WriteLine("Вы ввели число часов: " + h);

 int m; //минута
 while (true)
 {
     Console.Write("Введите число минут от 0 до 59: ");
     string input = Console.ReadLine();
     if (int.TryParse(input, out m))
     {
         if (m > 0 && m < 59)
             break;

         else
         {
             Console.WriteLine("Ошибка! Введите число от 0 до 59");
         }
     }
     else
     {
         Console.WriteLine("Ошибка! Введите число от 0 до 59");
     }
 }
 Console.WriteLine("Вы ввели число минут: " + m);

 int s; //секунда
 while (true)
 {
     Console.Write("Введите число секунд от 0 до 59: ");
     string input = Console.ReadLine();
     if (int.TryParse(input, out s))
     {
         if (s > 0 && s < 59)
             break;

         else
         {
             Console.WriteLine("Ошибка! Введите число от 0 до 59");
         }
     }
     else
     {
         Console.WriteLine("Ошибка! Введите число от 0 до 59");
     }
 }
 Console.WriteLine("Вы ввели число секунд: " + s);

 double angle = (h % 12) * 30 + m * 0.5 + s * (1 / 120);
 Console.WriteLine($"Угол между положением часовой стрелки и началом суток: {angle} градусов");
 
 // Задание 27. Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
 // соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2 . Определить значение угла для
 // минутной стрелки, а также количество полных часов и полных минут.
 // Ввод значений
 Console.WriteLine("Задание 27");
 Console.WriteLine("Введите количество полных часов (h):");
 int hh = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите количество полных минут (m):");
 int mm = Convert.ToInt32(Console.ReadLine());
 if (hh < 0 || mm < 0 || hh >= 24 || mm >= 60)
 {
     Console.WriteLine("Некорректно.Введите Часы от 0 до 23, а минуты от 0 до 59.");
     return;
 }
 double angmm = mm * 6; 
 int vsehh = hh % 12; 
 int vsemm = mm;
 Console.WriteLine($"Угол минутной стрелки (y): {angmm} градусов");
 Console.WriteLine($"Полные часы: {vsehh}");
 Console.WriteLine($"Полные минуты: {vsemm}");
 Console.WriteLine();
 
 // Задание 28. Создать программу, которая будет выводить на экран меньшее по модулю из трёх
 // введённых пользователем вещественных чисел
 Console.WriteLine("Задание 28");
 Console.WriteLine("Введите первое вещественное число:");
 double Num1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите второе вещественное число:");
 double Num2 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите третье вещественное число:");
 double Num3 =  Convert.ToDouble(Console.ReadLine());

 // модули чисел
 double absFirst = Math.Abs(Num1);
 double absSecond = Math.Abs(Num2);
 double absThird = Math.Abs(Num3);

 double minAbsValue = Math.Min(absFirst, Math.Min(absSecond, absThird));

 if (minAbsValue == absFirst)
 {
     Console.WriteLine($"Меньшее по модулю число: {Num1}");
 }
 else if (minAbsValue == absSecond)
 {
     Console.WriteLine($"Меньшее по модулю число: {Num2}");
 }
 else // minAbsValue == absThird
 {
     Console.WriteLine($"Меньшее по модулю число: {Num3}");
 }

 Console.WriteLine();

 // Задание 29. Найти сумму большего и меньшего из трёх заданных чисел
 Console.WriteLine("Задание 29");
 Console.WriteLine("Введите первое число:");
 double N1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите второе число:");
 double N2 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите третье число:");
 double N3 = Convert.ToDouble(Console.ReadLine());

 double maxN = Math.Max(N1, Math.Max(N2, N3));
 double minN = Math.Min(N1, Math.Min(N2, N3));
 double sum11 = maxN + minN;

 Console.WriteLine($"Сумма большего ({maxN}) и меньшего ({minN}) числа равна: {sum11}");
 Console.WriteLine();
 
//Задание 30. Подсчитать общее количество делителей натурального числа
 Console.WriteLine("Задание 30");
int num = Convert.ToInt32(Console.ReadLine());
 while (true)
 {
     Console.WriteLine("Введите натуральное число:");
     string input = Console.ReadLine();
     if (int.TryParse(input, out num))  
     {
         if (num >= 0)
             break;
         else
         {
             Console.WriteLine("Ошибка! Введите число > 0");
         }
     }
     else
     {
         Console.WriteLine("Ошибка! Введите число > 0");
     }
 }
 Console.WriteLine("Вы ввели число минут: " + num);
 int delit = 0;
 for (int i = 1; i <= number; i++)
 {
     if (number % i == 0)
     {
         delit++;
     }
 }
 Console.WriteLine($"Общее количество делителей числа {num}: {delit}");
 Console.WriteLine();
 
 //Задание 31.
 // Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
 // вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
 // уравнений вида A*X3 + B*X2 + C*X + D = 0. На факультативе по математике Васе
 //задали решить около ста уравнений как раз такого вида. Но, к сожалению, Вася
 //забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все
 //корни уравнений – целые числа и находятся на отрезке [-100, 100]. Поэтому у Васи
 //есть шанс найти их методом перебора, но для этого ему придется затратить уйму
 // времени, т.к. возможно необходимо будет осуществить перебор нескольких тысяч
 //значений. Помогите Васе написать программу, которая поможет ему найти корни
 //кубических уравнений!
 Console.WriteLine("Задание 31");
 Console.WriteLine("Введите коэффициенты А, B, C, D для кубического уравнения A*X^3 + B*X^2 + C*X + D = 0");
 Console.WriteLine("A: ");
 int A1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("B: ");
 int B1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("C: ");
 int C1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("D: ");
 int D1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Корни уравнения:");
 bool aa = false;
 for (int x = -100; x <= 100; x++)
 {
     // Вычисляем значение функции
     int result1 = A1 * x * x * x + B1 * x * x + C1 * x + D1;
    
     if (result1 == 0)
     {
         Console.WriteLine($"X = {x} является корнем уравнения.");
         aa = true;
     }
 }
 if (!aa)
 {
     Console.WriteLine("Корни уравнения не найдены в заданном диапазоне.");
 }
 Console.WriteLine();
 
// Задание 32.Заданы первый и второй элементы арифметической прогрессии. Требуется
// написать программу, которая вычислит элемент прогрессии по ее номеру.
 Console.WriteLine("Задание 32");
 Console.WriteLine("Введите первый элемент арифметической прогрессии (a1):");
 double a1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите второй элемент арифметической прогрессии (a2):");
 double a2 = Convert.ToDouble(Console.ReadLine());
 double d = a2 - a1;

 Console.WriteLine("Введите номер элемента прогрессии (n):");// n = p
 int p = Convert.ToInt32(Console.ReadLine());
 double ap = a1 + (p - 1) * d;
 Console.WriteLine($"Элемент прогрессии под номером {p}: {ap}");
 Console.WriteLine();
 
 // Задание 33. Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
 //трудоустроен - не получаю кредит. Ну а если я, и пенсионер и
 //студент,(трудоустройство тут не имеет значения) то не должен получить.
 //Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
 //или кто-то ещё. Вывести информацию: дадут кредит или нет.
 Console.WriteLine("Задание 33");
 Console.WriteLine("Введите ваш статус (пенсионер, студент, трудоустроен, кто-то еще):");
 string role = Console.ReadLine().ToLower(); //ToLower - в строчный вид
 if (role == "пенсионер" || role == "студент")
 {
     Console.WriteLine("Кредит будет выдан.");
 }
 else if (role == "трудоустроен")
 {
     Console.WriteLine("Кредит не будет выдан.");
 }
 else
 {
     Console.WriteLine("Кредит не будет выдан.");
 }
 Console.WriteLine();

 // Задание 34. Составить программу, которая:
 // а) запрашивает имя человека и повторяет его на экране;
 // б) запрашивает имя человека и повторяет его на экране с приветствием.
 Console.WriteLine("Задание 34");
 Console.WriteLine("Введите ваше имя:");
 string name = Console.ReadLine();
 Console.WriteLine($"Ваше имя: {name}");
 Console.WriteLine("Введите ваше имя для приветствия:");
 string nameForGreeting = Console.ReadLine();
 Console.WriteLine($"Здравствуйте, {name}!");
 Console.WriteLine();

// Задание 35. Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с консолью.
// Консоль спрашивает, как зовут пользователя. Пользователь называет имя.
// Консоль пишет: привет, <имя пользователя>. После этого пользователь
// спрашивает, знает ли консоль что-то о тайной комнате. Консоль отвечает «Да».
// После этого пользователь спрашивает, может ли рассказать. Консоль отвечает
// «Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет
// цвет на любой случайный цвет.

Console.WriteLine("Задание 35");
Console.WriteLine("Как тебя зовут?");
string name1 = Console.ReadLine();
Console.WriteLine($"Привет, {name1}");
Console.WriteLine("Ты знаешь что-нибудь о тайной команате?");
string response1 = Console.ReadLine();
Console.WriteLine("Да");
Console.WriteLine("Можешь ли ты показать");
string response2 = Console.ReadLine();
Console.WriteLine("Нет");
Thread.Sleep(5000);
Console.WriteLine("Но могу показать.");
Console.WriteLine();
Random rnd = new Random(); 
Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
Console.WriteLine();

// Задание 36. Вычислить контрольную цифру штрихкода(EAN13).
// a. 12 цифр определяются случайным образом.
// b. 12 цифр вводит пользователь
// Сложите все цифры на четных позициях и умножьте сумму на 3;
// Добавьте все цифры на нечетных позициях, кроме последней (контрольной);
// Разделите результат на 10 и возьмите остаток от деления;
// Если остаток не 0, то вычтите его из 10;

 Console.WriteLine("Задание 36");
 Console.WriteLine("Выберите опцию:");
 Console.WriteLine("1 - Случайные 12 цифр для EAN-13");
 Console.WriteLine("2 - Ввести свои 12 цифр");
 Random rnd11 = new Random(); 
 string choice60 = Console.ReadLine();
 string ean12="";
 if (choice60 == "1")
 {
     for (int i = 0; i < 12; i++)
     {
         ean12 += rnd.Next(0, 10).ToString();
     }
     Console.WriteLine(ean12);
 }
 else if (choice60 == "2")
 {
     Console.Write("Введите 12 цифр:");
     ean12 = Console.ReadLine();
 }

 int totalsum = 0;
 for (int i = 0; i < 12; i++)
 {
     int digit10 = Convert.ToInt32(ean12[i].ToString());
     if ((i + 1) % 2 == 0)
     {
         totalsum += digit10 * 3;
     }
     else
     {
         totalsum += digit10;
     }
 }

 int rez = (10 - (totalsum % 10))%10;
 Console.WriteLine(rez);
 