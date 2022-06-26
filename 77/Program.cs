Console.Write("введите 1 число ");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите 2 число ");
double num2 = Convert.ToInt32(Console.ReadLine());

if(num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine("квадрат есть");
}
else
{
    Console.WriteLine("квадратa нет");
}