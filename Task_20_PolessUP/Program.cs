int n = 11;
Console.WriteLine("Ввод: " + n);
Console.WriteLine("Вывод(количество простых чисел < n): " + PrimesNumberLessThen(n)); 

int PrimesNumberLessThen(int n) 
{
    var numbers = new List<int>();
    for (int i = 2; i < n; i++)
    {
        numbers.Add(i);
    }

    for (int i = 0; i < numbers.Count; i++)
    {
        for (int j = 2; j < n; j++)
        {
            numbers.Remove(numbers[i] * j);
        }
    }
    return numbers.Count;
}


