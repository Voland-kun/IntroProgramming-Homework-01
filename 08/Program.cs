Console.WriteLine("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber == 1)
{
    Console.WriteLine("Нет чисел");
}
/* кусок для отрицательных чисел
else if (userNumber < 1)
{
    int count = 0;
    while (count >= userNumber)
    {
        Console.Write($"{count} ");
        count = count - 2;
    }
}
*/
else
{
    int count = 2;
    while (count <= userNumber)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}