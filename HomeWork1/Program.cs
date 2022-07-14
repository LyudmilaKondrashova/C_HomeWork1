// Задача 2 - поиск максимального и минимального числа
// из двух введенных чисел
void MaxMin()
{
    Console.WriteLine("Задача 2 - найти максимальное и минимальное число из двух введенных чисел:");
    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2)
    {
        Console.WriteLine("Максимальное число равно " + number1);
        Console.WriteLine("Минимальное число равно " + number2);
    }
    else if (number2 > number1)
    {
        Console.WriteLine("Максимальное число равно " + number2);
        Console.WriteLine("Минимальное число равно " + number1);
    }
    else
        Console.WriteLine("Числа равны");
}

// Задача 4 - поиск максимального числа из трех введенных чисел
void MaxNumb()
{
    Console.WriteLine("Задача 4 - найти максимальное число из трех введенных чисел:");
    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int number3 = Convert.ToInt32(Console.ReadLine());
    int MaxNumber = number1;

    if (number2 > MaxNumber)
        MaxNumber = number2;
    if (number3 > MaxNumber)
        MaxNumber = number3;
    
    Console.WriteLine("Максимальное число равно " + MaxNumber);
}

// Задача 6 - определение четности введенного числа
void Chetn()
{
    Console.WriteLine("Задача 6 - определение четности введенного числа");
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 0)
        Console.WriteLine("Число " + number + " является четным");
    else
        Console.WriteLine("Число " + number + " является нечетным");
}

// Задача 8 - вывод всех четных числе от 1 до введенного числа
void VseChetn()
{
    Console.WriteLine("Задача 8 - вывод всех четных числе от 1 до введенного числа");
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 2;

    if (number <= 0)
        Console.WriteLine("Введите положительное число");
    else if (number == 1)
        Console.WriteLine("Четных чисел нет");
    else
    {
        Console.Write("Четные числа: ");
        while (count <= number)
        {
            if (count % 2 == 0)
                Console.Write(count + " ");
            count++;
        }
        Console.WriteLine();
    }
}



MaxMin();
MaxNumb();
Chetn();
VseChetn();
