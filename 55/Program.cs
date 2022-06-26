Console.Write("введите 1 число ");
double num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.WriteLine("кратно");
}
else 
{
    Console.WriteLine("не кратно");
}