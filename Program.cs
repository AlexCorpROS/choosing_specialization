

Console.WriteLine("Задайте количество элементов : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальную длину элементов, которые нужно вывести на экран: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] inputArr = getCreatArray(n);
string[] resultArray = getFindElementsGivenLength(inputArr, m);
Console.WriteLine($"Массив элементов максимальной длины {m} имеет вид: ");
Console.WriteLine(string.Join(", ", resultArray));

string[] getCreatArray(int UserNum)
{
string[] inputArray = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Задайте {i+1} элемент : ");
    inputArray[i] = Console.ReadLine();
}
Console.WriteLine("Заданный массив элементов имеет вид : "); 
Console.WriteLine(string.Join(", ", inputArray));
return inputArray;
}

string[] getFindElementsGivenLength(string[] inputArray, int UserNum)
{
    int count = 0;
    for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i].Length <= UserNum)
        count++;
    }
    string[] resultArray = new string[count];
    for (int i = 0, j= 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= UserNum)
        {
            resultArray[j] = inputArray[i];
            j++;
        }
    }
    return resultArray;
}
