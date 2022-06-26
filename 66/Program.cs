Console.Write("введитете 1 число ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("введитете 2 число ");
int num2 = Convert.ToInt32 (Console.ReadLine());
int num3 = num1 % num2;
if (num3 == 0)
{
    Console.WriteLine("кратное");
}
else
{
    Console.WriteLine("некратное, остаток " + num3);
}
