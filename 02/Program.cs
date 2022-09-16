Console.WriteLine("Введите числа ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int min = 0, max = 0;
if(userNumber1 == userNumber2)
    Console.WriteLine("Числа равны");
else if(userNumber1 < userNumber2)
{
    min = userNumber1;
    max = userNumber2;
    Console.WriteLine($"Максимальное число = {max} минимальное число = {min}");
}
else
{
    max = userNumber1;
    min = userNumber2;
    Console.WriteLine($"Максимальное число = {max} минимальное число = {min}");
}