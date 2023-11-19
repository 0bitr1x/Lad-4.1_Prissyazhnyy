Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целочисленный массив: ");
int[] mas = new int[n];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = int.Parse(Console.ReadLine());
}
int difference = mas[1] - mas[0];
for (int i = 2; i < mas.Length; i++)
{
    if (difference != mas[i] - mas[i - 1]) { Console.WriteLine("не образуют"); return; }
}
Console.WriteLine("Разность прогрессии: " + difference);




