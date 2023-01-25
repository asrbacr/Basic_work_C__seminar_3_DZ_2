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
Console.Write("Введите пятизначное число для проверки является ли оно палиндромом: ");
int a = UserInput();

bool Polindrom(int a)
{

if (a < 0)
    a *= (-1);

if (!(a > 9999 && a < 100000))
    Console.WriteLine("Придётся выбрать задачу заново, т.к. число не пятизначное");
else
{
    if (a % 10 == a / 10000 && (a / 1000) % 10 == (a % 100) / 10)
        Console.WriteLine("да");
    else
        Console.WriteLine("Нет");
}
return a;
}
System.Console.WriteLine(Polindrom(a));



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
