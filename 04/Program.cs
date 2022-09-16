Console.WriteLine("Введите числа ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int userNumber3 = Convert.ToInt32(Console.ReadLine());
int max = userNumber1;
if (userNumber2 > max) max = userNumber2;
if (userNumber3 > max) max = userNumber3;
Console.WriteLine($"Максимальное число = {max}");