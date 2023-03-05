// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

System.Console.Write("Введите количество элементов массива: ");

int elementsCount = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elementsCount];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());                           // пользователь сам задает числа массива
}

System.Console.WriteLine("Массив: ");

for (int i = 0; i < array.Length; i++)       // вывод массива
{
    System.Console.Write(array[i] + " ");
}
