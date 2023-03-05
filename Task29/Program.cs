// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

System.Console.Write("Введите количество элементов массива: ");

int elementsCount = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elementsCount];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100);      // генерирует числа от 1 до 99
}

System.Console.WriteLine("Массив: ");

for (int i = 0; i < array.Length; i++)       // вывод массива
{
    System.Console.Write(array[i] + " ");
}
