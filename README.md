# Задания Циклы .NET Framework 4.8

## Первое задание

```
﻿using System;

class Program
{
    static void Main()
    {
        decimal procent = 0.07m;
        Console.WriteLine("Процентная ставка банка равна 7%/мес.");
        Console.Write("Введите сумму вклада: ");
        decimal summ = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Введите количество месяцев: ");
        decimal month = Convert.ToDecimal(Console.ReadLine());
        decimal res = summ;
        for (int i = 0; i < month; i++)
        {
            res += res * procent;
        }
        Console.WriteLine($"Итоговая сумма равна: {res:F2}");
    }
}
```

## Второе задание

```
﻿using System;

class Program
{
    static void Main()
    {
        decimal procent = 0.07m;
        int i = 0;
        Console.WriteLine("Процентная ставка банка равна 7%/мес.");
        Console.Write("Введите сумму вклада: ");
        decimal summ = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Введите количество месяцев: ");
        int month = Convert.ToInt32(Console.ReadLine());
        decimal res = summ;
        while (i < month) 
        {
            res += res * procent;
            i++;
        }
        Console.WriteLine($"Итоговая сумма равна: {res:F2}");
    }
}
```

## Третье задание

```
﻿using System;

class Program
{
    static void Main()
    {
        int size = 10;
        Console.WriteLine();
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
    }
}
```

## Четвёртое задание

```
﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Принимаются числа только в диапозоне от 0 до 10!");
        while (true)
        {
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
            {
                result = num1 * num2;
                Console.WriteLine($"Ответ = {result}");
                break;
            }
            else
            {
                Console.WriteLine("Недопустимые значения!");
                
            }
            
        }
    }
}
```
