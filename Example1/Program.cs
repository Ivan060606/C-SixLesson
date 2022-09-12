void StringToArrayAndPositiveNumbers()
{
    Console.Write("Введите числа массива через запятую : ");
    string arrayNumber = Console.ReadLine();
    var array = arrayNumber.Split(',').Select(Int32.Parse).ToArray();
    //Console.WriteLine(array[2]);
    Console.WriteLine($"Вы ввели массив чисел :[{arrayNumber}]");
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) k++;
    }
    Console.WriteLine($"{k} положительных чисел");
}

StringToArrayAndPositiveNumbers();