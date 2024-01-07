// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] NewArrayString(string[] pull)    // Метод создания массива с клавиатуры.
{
    string[] chars = new string[pull.Length];   
        for (int i = 0; i < pull.Length; i++)   
        {
            chars[i] = pull[i];                 
        }
    return chars;                               
}

void ShowArray(string[] array)            // Метод вывода массива на консоль.
{
    Console.Write(" " + " ");
        foreach (string elem in array)
        {
            Console.Write(elem + " ");
        }
}

string[] ModArray(string[] array)         // метод формирования нового массива из строк,
                                          // длина которых меньше, либо равна 3 символам
{
    string[] newArray = new string[array.Length];  
    int count = 0;                                  
        for (int i = 0; i < array.Length; i++)    
        {
            if (array[i].Length <= 3)              
            {
                newArray[count] = array[i];       
                count++;                          
            }
        }

    return newArray;                              
}

Console.WriteLine($"Введите элементы строкового массива через запятую");
string s = Console.ReadLine();     // Ввод строки с клавиатуры.
string[] pull = s.Split(',');      // Разбивка строки на группы для записи массива 
                                   // по элементно через запятую ",".
string[] myArray = NewArrayString(pull); 
Console.Write($"Получен исходный массив: ");
ShowArray(myArray);
Console.WriteLine();
string[] newArray = ModArray(myArray);
Console.Write($"Определен конечный массив: ");
ShowArray(newArray);