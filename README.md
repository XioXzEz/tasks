# Задания массивы .NET Framework 4.8

## Вопросы:

### 1. Ответ: 18

### 2. Ответ: 2

### 3. Ответ: Ошибка IndexOutOfRangeException

### 4. Ответ: nums[2][1]

### 5.
```c#
using System;

class Program
{
    static void Main()
    {
        int[,,] mas = { { { 1, 2 }, { 3, 4 } }, 
                         { { 4, 5 }, { 6, 7 } }, 
                         { { 7, 8 }, { 9, 10 } }, 
                         { { 10, 11 }, { 12, 13 } } 
                       };

        Console.Write("{");
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            if (i > 0) Console.Write(" , ");
            Console.Write("{");
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (j > 0) Console.Write(" , ");
                Console.Write("{");
                for (int k = 0; k < mas.GetLength(2); k++)
                {
                    if (k > 0) Console.Write(" , ");
                    Console.Write(mas[i, j, k]);
                }
                Console.Write("}");
            }
            Console.Write("}");
        }
        Console.Write("}");
    }
}
```
