#region метод вибора
int[] numbers = { 9, -13, 20, -2, 5, 7, -10, 0, 9, -11 };
int min;
int temp;
for (int i = 0;i < numbers.Length;i++)
{
    min = i;
    for (int j = i+1 ;j < numbers.Length; j++)
    {
        if (numbers[j] < numbers[min])
        {
            min = j;
        }
    }
    temp = numbers[min];
    numbers[min] = numbers[i];
    numbers[i] = temp;
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
#endregion
#region метод пузирька
int[] numbers1 = { 9, -13, 20, -2, 5, 7, -10, 0, 9, -11 };
int temp1;
for (int i = 0;i<numbers1.Length; i++)
{
    for (int j = 0 ; j < numbers1.Length-1-i; j++)
    {
        if (numbers1[j] > numbers1[j + 1])
        {
            temp = numbers1[j];
            numbers1[j] = numbers1[j+1];
            numbers1[j+1] = temp;
        }
    }
}
for (int i = 0;i < numbers1.Length; i++)
{
    Console.WriteLine(numbers1[i]);
}
#endregion
#region метод вставка
int [] numbers2={ 9, -13, 20, -2, 5, 7, -10, 0, 9, -11 };
int index;
int currentNumber;
for (int i = 0; i < numbers2.Length; i++)
{
    index = i;
    currentNumber = numbers2[i];
    while ( index > 0 && currentNumber < numbers2[index-1])
    {
        numbers2[index]= numbers2[index-1];
        index--;
    }
    numbers2[index] = currentNumber;
}
for (int i = 0; i < numbers2.Length; i++)
{
    Console.WriteLine(numbers2[i]);
}
#endregion
//checked
