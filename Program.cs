Console.Write($"Введите элементы массива через пробел или запятую, или точку: \n");
string[] array=Console.ReadLine()!.Split(' ',',','.');
int count=0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length<=3)
        {Console.WriteLine($"{array[i]}\n");
        count++;}
    if (count ==0)
        Console.WriteLine($"Все элементы массива содержат больше 3 символов");
