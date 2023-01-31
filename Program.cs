﻿Console.Write("Введите номер задачи для проверки: ");

int a = UserInput();

switch (a)
{
    /*   case 19:
           Console.Write("Введите пятизначное число для проверки является ли оно палиндромом: ");
           a = UserInput();
           Polindrom(a);
           break;

       case 21:
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

           Console.Write($"Расстояние между точками А ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> ");
           double res = Distance(x1, y1, z1, x2, y2, z2);
           Console.Write(res.ToString("0.##"));
           break;

       case 23:
           Console.Write("Введите число, а программа выведет таблицу кубов чисел от 1 до введённого вами: ");
           a = UserInput();
           Console.Write($"Таблица кубов числа {a}-> ");
           TryTable(a);
           break;

       case 25:
           Console.Write("Введите число, которое будем возводить в степень: ");
           a = UserInput();
           if (a == 0)
           {
               System.Console.WriteLine("Если 0 возводить в степень, то будет получаться всегда 0.");
               System.Console.WriteLine("Дальнейшее выполнение не целесообразно.");
               break;
           }
           Console.Write($"Введите степерь в которую будем возводить число {a}: ");
           int b = UserInput();
           if (b < 0)
           {
               System.Console.WriteLine("Я ещё не достиг уровня отображения степени из отрицательного числа, но обязательно буду стараться.");
               System.Console.WriteLine("Выполнение программы прервано.");
               break;
           }

           Console.WriteLine($"Ответ: {a} ^ {b} = {PowNumber(a, b).ToString("### ### ### ###")}");
           break;

       case 27:
           System.Console.Write("Введите число, что бы посчитать сумму чисел: ");
           a = UserInput();
           Console.Write($"Сумма цифр числа {a} ");
           if (a < 0)
               a *= (-1);

           Console.Write($"-> {SumNumber(a)}");
           break;

       case 29:
           System.Console.Write("Введите значение сколько элементов будет в массиве: ");
           int N = UserInput();

           if (N < 0)
           {
               System.Console.WriteLine("Нельзя чтобы значение было отрицательным");
               break;
           }
           else if (N == 0)
           {
               System.Console.WriteLine("Ну тогда массив будет выглядеть []");
               break;
           }

           int[] array = new int[N];

           System.Console.Write("Введите нижнее значение массива: ");
           int min = UserInput();
           System.Console.Write("Введите верхнее значение массива: ");
           int max = UserInput();
           if (max < min)
           {
               int i = max;
               max = min;
               min = i;
           }

           for (int i = 0; i < array.Length; i++)
           {
               array[i] = new Random().Next(min, max + 1);
           }

           System.Console.Write($"[{String.Join(",", array)}]\n");
           break; 
    */
    case 34:
        System.Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        System.Console.Write("Сколько элементов будет в массиве: ");
        a = UserInput();
        int[] arrayNew = GenArray(a, 100, 999); //тут макс указано 999, потому что в функции идёт max+1
        int resultSerch = FuncSerch(arrayNew);
        Console.Write($"В массиве [");
        PrintArray(arrayNew);
        System.Console.Write($"], четный элементов -> {resultSerch}");
        break;

    case 36:
        System.Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        System.Console.Write("Сколько элементов будет в массиве: ");
        a = UserInput();
        System.Console.Write("Введите минимальное значение массива: ");
        int min = UserInput();
        System.Console.Write("Введите максимальное значение массива: ");
        int max = UserInput();


        arrayNew = GenArray(a, min, max);
        Console.Write($"В массиве [");
        PrintArray(arrayNew);
        System.Console.Write($"], сумма элементов, стоящих на нечётных позициях -> {FuncSummOdd(arrayNew)}");
        break;

    case 38:
        System.Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        System.Console.Write("Сколько элементов будет в массиве: ");
        a = UserInput();
        // Console.Write("Введите максимальный элемент массива: ");
        // int b = UserInput();
        // if (b <= 0)
        // {
        //     Console.WriteLine("Ошибка, число не может быть меньше или равно 0, по условию задачи требуется массив из вещественных чисел.");
        //     break;
        // }
        // int[] array = GenArray(a, 0, b);

        int[] array = FillArray(a);
        Console.Write("В массиве [");
        PrintArray(array);
        Console.Write($"] максимальный элемент {SerchMax(array)}, {SerchMin(array)} разница между ними равна {SerchMax(array) - SerchMin(array)}");
        break;



    default:
        //Console.WriteLine("Программа по выбору находится ещё в разработку, поэтому можно выбрать только № 19, 21, 23, 25, 27 или 29.");
        Console.WriteLine("Можно выбрать только № 34, 36 или 38");
        break;
}


// _________Funcs

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

void Polindrom(int a)
{
    if (a < 0)
        a *= (-1);

    if (!(a > 9999 && a < 100000))
    {
        Console.WriteLine("Придётся выбрать задачу заново, т.к. число не пятизначное");
    }
    else
    {
        if (a % 10 == a / 10000 && (a / 1000) % 10 == (a % 100) / 10)
        {
            {
                Console.WriteLine($"да, введёное число {a}, является пониндромом.");
            }
        }
        else
        {
            Console.WriteLine($"Нет, введёное число {a}, не является пониндромом.");
        }
    }
}

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

void TryTable(int N)
{
    int count = 1;
    if (N < 0)
        N *= (-1);

    while (count <= N - 1)
    {
        Console.Write(count * count * count + ", ");
        count++;
    }
    Console.Write(count * count * count);

}

int PowNumber(int Num, int Degree)
{
    int res = 1;
    for (int i = 1; i <= Degree; i++)
    {
        res *= Num;
    }
    return res;
}

int SumNumber(int Num)
{
    double res = 0;
    for (int i = 0; Num > 0; i++)
    {
        res += Num % 10;
        Num /= 10;
    }
    return (int)res;
}

int[] GenArray(int a, int min, int max)
{
    if (max < min) //я решил вынести проверку мин и макс в формулу, чтобы не писать её каждый раз
    {
        int b = max;
        max = min;
        min = b;
    }
    int[] RandomArray = new int[a];
    int count = 0;
    for (int i = 0; i < RandomArray.Length; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1);
        if (RandomArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return RandomArray;
}

int FuncSerch(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    System.Console.Write(arr[arr.Length - 1]);
    // Console.WriteLine();
}

int FuncSummOdd(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        res += array[i];
    }
    return res;
}

int SerchMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

int SerchMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

int[] FillArray(int a)
{
    int[] AddNumbArrya = new int[a];
    for (int i = 0; i < AddNumbArrya.Length; i++)
    {
        System.Console.Write($"Введите {i + 1} элемент: ");
        AddNumbArrya[i] = UserInput();
    }
        return AddNumbArrya;
}