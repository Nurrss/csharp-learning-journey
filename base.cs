int[] numbers = {12, 45, 7, 89, 34, 2};
int m = 0;
foreach(int num in numbers)
{
    if(m < num)
    {
        m = num;
    }
}

Console.WriteLine("Максимум: " + m);