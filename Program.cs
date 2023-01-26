// Формула к 19

// if (number % 10 == number / 10000 && (number /1000) % 10 == (number % 100) / 10)
// {
//      Console.WrireLine ("да");
// }

// Формула к 21
// return result = Mach.Qwert(Math.Pow(xb - xa) +  Math.Pow(yb - ya) + Math.Pow(zb - za));

// Формула к 23

// Console.Write("Введите номер задачи для проверки: ");

// int UserInput(int number)
// {
//     while (!int.TryParse(Console.ReadLine(), out number))
//         Console.Write("Вы ввели не число. Повторите попытку ввода: ");
//     return number;
// }
// int b;
// // int a = UserInput(b);

// // swift(UserInput):
// // {
//     case 19:
// Console.Write("Введите пятизначное число для проверки является ли оно палиндромом: ");
// int a = UserInput();

// Polindrom(a);

// void Polindrom(int a)
// {
//     if (a < 0)
//         a *= (-1);

//     if (!(a > 9999 && a < 100000))
//     {
//         Console.WriteLine("Придётся выбрать задачу заново, т.к. число не пятизначное");
//     }
//     else
//     {
//         if (a % 10 == a / 10000 && (a / 1000) % 10 == (a % 100) / 10)
//         {
//             {
//                 Console.WriteLine("да");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Нет");
//         }
//     }
// }


// case 21:

int x1, y1, z1, x2, y2, z2;
Console.Write("Введите значение X для 1 точки: ");
x1 = UserInput();
Console.Write("Введите значение Y для 1 точки: ");
y1 = UserInput();
Console.Write("Введите значение Z для 1 точки: ");
z1 = UserInput();
Console.Write("Введите значение X для 2 точки: ");
x2 = UserInput();
Console.Write("Введите значение Y для 2 точки: ");
y2 = UserInput();
Console.Write("Введите значение Z для 2 точки: ");
z2 = UserInput();

Console.WriteLine($"Расстояние между точками А ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Distance.ToString("0.##")}");

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x2 - x1) + (y2 - y1) + (z2 - z1));
}


// bool Polindrom(int number)
// {
//     if (number % 10 == number / 10000 && (number / 1000) % 10 == (number % 100) / 10)
//     {
//         Console.WrireLine("да");
//     }
// }


// // }


// Console.Write("Введите номер задачи для проверки ДЗ: ");


//_________Funcs

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

