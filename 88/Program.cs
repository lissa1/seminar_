int num = new Random().Next(99, 1000);
int num1 = num % 10;
int num2 = num / 100;
Console.WriteLine(num2 + "" + num1);
Console.WriteLine("исходное число " + num);
