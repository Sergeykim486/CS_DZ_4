// ═══════════════════════════════ общие функции ═══════════════════════════════

// СОДЕРЖИМОЕ МЕНЮ И ТЕКУЩИЙ ВЫБРАННЫЙ ЭЛЕМЕНТ
int choice = 1;
int CurrentLine = 1;
string[] ListMenu = {
"  Задача 25: Число [A] в натуральной степени [B]                  ",
"  Задача 27: Сумма всех разрядов числа                            ",
"  Задача 23: Массив [N] размера + запрос значений                 ",
"  Задача 26*: Количество цифр в целом или вещественном числе      ",
"  ВЫХОД ИЗ ПРОГРАММЫ                                              "};
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;

// ОТРИСОВКА МЕНЮ
void menu()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(choice);
    int i = 0;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("═══════════════════  Г Л А В Н О Е   М Е Н Ю  ════════════════════\n");
    Console.ForegroundColor = ConsoleColor.White;
    while (i < ListMenu.Length)
    {
        CurrentLine = i + 1;
        if (choice == CurrentLine)
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            Console.Write($"{ListMenu[i].ToUpper()}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.Write($"{ListMenu[i]}\n");
        }
        i++;
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n" +
    "╔════════════════════════════════════════════════╤═══════════════╗\n" +
    "║  Используйте [стрелки] для навигации.          │   ▲ : Вверх   ║\n" +
    "║  [ENTER] - Выбор выделенного пункта            │   ▼ : Вниз    ║\n" +
    "╚════════════════════════════════════════════════╧═══════════════╝\n");
    Console.BackgroundColor = ConsoleColor.Black;
}

// ВВОД ЧИСЛА
int GetData()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое число... ");
    int result1 = Convert.ToInt32(Console.ReadLine());
    return result1;
}

// ОБРАБОТКА ОШИБКИ
void ErrorCatch()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("" +
    "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
    "  ║  Возможно вы ввели не верные данные.                ║\n" +
    "  ║  Программа будет перезапущена...                    ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    pause();
}

// ПАУЗА ДЛЯ ЧТЕНИЯ ВЫВОДИМЫХ ДАННЫХ
void pause()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("" +
    "  ╔═════════════════════════════════════════════════════╗\n" +
    "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    try
    {
        main();
    }
    catch
    {
        ErrorCatch();
    }
}

// ВЫХОД ИЗ ПРОГРАММЫ
void ext()
{
AskAgayn:
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("" +
    "  ╔═ В Ы Х О Д   И З   П Р О Г Р А М М Ы ═══════════════╗\n" +
    "  ║      Вы уверены что хотите закрыть программу?       ║\n" +
    "  ║              [ENTER] Да     [ESC] Нет               ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("" +
        "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
        "  ║  Вам нужно нажать [ENTER] или [ESC].                ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("" +
        "  ╔═════════════════════════════════════════════════════╗\n" +
        "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        ConsoleKeyInfo key1;
        key1 = Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
        goto AskAgayn;
    }
    else if (key.Key == ConsoleKey.Escape) main();
    else if (key.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        System.Environment.Exit(0);
    }
    else main();
}

// ═════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Домашнее задание ═══════════════════════════════

// 1 ЗАДАЧА //
int NumberSum(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return (result);
}

// 2 ЗАДАЧА //
int number(int num)
{
    if (num < 0) num = num + num * 2;
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return (sum);
}

// 3 ЗАДАЧА //
int[] Array(int n)
{
    int[] ar = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е значение массива...");
        ar[i] = GetData();
    }
    return (ar);
}

// 4 ЗАДАЧА //
int numc(double num)
{
    int result = 0;
    while (num % 1 > 0)
    {
        num = num * 10;
    }
    while (num >= 1)
    {
        num = num / 10;
        result++;
    }
    return (result);
}

string word(int w)
{
    string result = "ЦИФРА";
    int w1 = w % 10;
    if (w < 0) w = w + w * 2;
    if (w1 == 1) result = "ЦИФРУ";
    else if (w1 > 1 && w1 < 5) result = "ЦИФРЫ";
    else if (w > 4 && w < 20) result = "ЦИФР";
    else result = "ЦИФР";
    return (result);
}

// ═════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Обработка выбранного элемента в меню ═══════════════════════════════

// ВЫПОЛНЕНИЕ ПРОГРАММЫ И ОТСЛЕЖИВАНИЕ НАЖАТИЯ КЛАВИШ
void main()
{
restart:
    menu();
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        if (choice <= ListMenu.Length)
        {
            if (choice == 1)
            {
                choice = ListMenu.Length;
                goto restart;
            }
            else
            {
                choice = choice - 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (choice >= 1)
        {
            if (choice == ListMenu.Length)
            {
                choice = 1;
                goto restart;
            }
            else
            {
                choice = choice + 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        switch (choice)
        {
            case 1:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nВведите число [a]...");
                int a = GetData();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nВведите число [b]...");
                int b = GetData();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" +
                "  ╔═══════════════════════════════════╗\n" +
                $"      ВВЕДЕННОЕ ЧИСЛО {a}\n" +
                $"      В {b}-Й СТЕПЕНИ, РАВНО {NumberSum(a, b)} \n" +
                "  ╚═══════════════════════════════════╝\n");
                pause();
                goto restart;
            case 2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nВведите число...");
                int aa = GetData();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" +
                "  ╔════════════════════════════════════════════════╗\n" +
                $"      СУММА ВСЕХ ЦИФР ЧИСЛА {aa} РАВНА {number(aa)} \n" +
                "  ╚════════════════════════════════════════════════╝\n");
                pause();
                goto restart;
            case 3:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nВведите число...");
                int ArL = GetData();
                int[] array1 = Array(ArL);
                for (int i = 0; i < ArL; i++)
                {
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
                        Console.Write($"    {array1[i]}, ");
                    }
                    else if (i == ArL - 1) Console.Write($"{array1[i]}.\n");
                    else Console.Write($"{array1[i]}, ");
                }
                Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
                pause();
                goto restart;
            case 4:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача 26 HARD - необязательная: Напишите программу, которая принимает на вход число (целое или вещественное) и выдаёт количество цифр в числе.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nВведите любоае число...");
                string numdouble = Convert.ToString(Console.ReadLine());
                double nn = Convert.ToDouble(numdouble.Replace('.', ','));
                Console.ForegroundColor = ConsoleColor.Green;
                int numbers = numc(nn);
                Console.WriteLine("\n" +
                "  ╔═════════════════════════════════════════════════════╗\n" +
                $"      ЧИСЛО {nn} СОДЕРЖИТ {numbers} {word(numbers)}\n" +
                "  ╚═════════════════════════════════════════════════════╝\n");
                pause();
                goto restart;
            case 5:
                ext();
                goto restart;
        }
    }
    else goto restart;
}

// ═════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Запуск обработки меню и выбранного элемента ═══════════════════════════════

try
{
    main();
}

catch
{
    ErrorCatch();
}