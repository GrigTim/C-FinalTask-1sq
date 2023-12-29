﻿//FinalTask 1 sq .

#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. ");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вводим число элементов массива первым методом и вторым заполняем сам массив

int n = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка! Введите целое число.");
string[] array = GetArrayString(n);

#endregion --- 01. Input operations ---

#region --- 02. logic and output ---
// Ну... Тут метод создает конечный массив 

string[] newArray = GetArrayElementLenghtMin3(array);

// И выводим исходный массив и конечный массив

Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", newArray)}]");

#endregion --- 02. logic and output ---


// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------

// собственно, основной метод создающий конечный массив
string[] GetArrayElementLenghtMin3(string[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(inArray[i].Length <= 3) count++;
    }
    
    string[] newArr = new string[count];

    int j = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(inArray[i].Length <= 3) {
            newArr[j] = inArray[i];
            j++;
        }
    } 
    return newArr;
}
// Заполнение массива пользователем
string[] GetArrayString(int size){
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
}
// метод запрашивает число у пользователя
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}