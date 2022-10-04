void CheckLengthOfElements(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++) // задаём цикл, который будет работать, пока номер эл-та меньше длины массива
        if(array1[i].Length < 4) // проверяем длину элемента
            {
                array2[j] = array1[i]; // записываем во 2 массив значение, прошедшее проверку
                j++; // увеличиваем счётчик на 1
            }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i]+" ");
    Console.WriteLine();
}
string[] array1 = new string[7] {"134", "15977", "-2", "computer science", "+", "hello", "GB"}; // задаём массив, который будем проверять
string[] array2 = new string[array1.Length]; // задаём массив, куда будем записывать значения, прошедшие проверку
CheckLengthOfElements(array1, array2);
PrintArray(array2);