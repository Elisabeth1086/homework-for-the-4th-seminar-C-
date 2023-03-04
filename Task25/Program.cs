// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Degree(int A, int B)
{
    int degree=1;
    for(int i=1; i<=B; i++)
    {
        degree=degree*A;
    }
    System.Console.WriteLine($"Число {A} в степени {B} равно: {degree}");
}


int number1=ReadInt("Введите число, которое нужно возвести в степнь: ");
int number2=ReadInt("Введите степень, в которую нужно возвести число: ");
Degree(number1, number2);

