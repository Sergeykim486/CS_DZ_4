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
    Console.ForegroundColor = ConsoleColor.DarkGreen;
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
    Console.Write("\n_______________________________________________\n" +
    "Введите целое число... ");
    int result1 = Convert.ToInt32(Console.ReadLine());
    return result1;
}

// ОБРАБОТКА ОШИБКИ
void ErrorCatch()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА!\n" +
    "Неверный ввод данных.\n" +
    "Программа будет перезапущена.");
    Console.ForegroundColor = ConsoleColor.White;
    pause();
}

// ПАУЗА ДЛЯ ЧТЕНИЯ ВЫВОДИМЫХ ДАННЫХ
void pause()
{
    Console.WriteLine("Для продолжения нажмите любую клавишу...");
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
    Console.Clear();
AskAgayn:
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n" +
    "  ╔═════════════════════════════════════════════════════╗\n" +
    "  ║      Вы уверены что хотите закрыть программу?       ║\n" +
    "  ║              [ENTER] Да     [ESC] Нет               ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("ОШИБКА!\n" +
        "Вы нажали не ту клавишу." +
        "Нажмите [ENTER] или [ESC].");
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

// 2 ЗАДАЧА //

// 3 ЗАДАЧА //

// 4 ЗАДАЧА //

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
                pause();
                goto restart;
            case 2:
                pause();
                goto restart;
            case 3:
                pause();
                goto restart;
            case 4:
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