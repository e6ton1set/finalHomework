// Метод записи строковых значений пользователем в исходный массив
// размер которого также задаёт пользователь.
string[] WriteStringsToArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите значение для строки: {i + 1} ");
        array[i] = Console.ReadLine();
    }

    return array;
}

// Метод, проверяющий исходный массив на условие 
// "Элемент меньше или равен 3-ём символам",
// и возвращающий новый массив.
string[] GiveWorldsMore3Char(string[] array)
{
    int resultLenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultLenght = resultLenght + 1;
        }
    }

    string[] resultArray = new string[resultLenght];
    int tmp = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[tmp] = array[i];
            tmp++;
        }
    }

    return resultArray;
}

// Встроенный метод, который позволяет избежать ошибки 
// с неверным вводом значения размера исходного массива.
try
{
    Console.WriteLine("Введите количество строк в массиве: ");
    int size = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    string[] array = WriteStringsToArray(size);

    Console.WriteLine();
    string[] resultArray = GiveWorldsMore3Char(array);

    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.WriteLine($"Строковый элемент {i} нового массива отвечает требованию задания, его значение: {resultArray[i]}");
    }
}

// Встроенный метод, который позволяет вывести пользователю
// сообщение в случае ошибки в методе try.
catch
{
    Console.WriteLine();
    Console.WriteLine("Вы ввели неверное значение для размера исходного массива. \nПожалуйста, перезапустите программу и введите целое число.");
}