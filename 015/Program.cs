int day = Convert.ToInt32(Console.ReadLine());
while (day < 1 || day > 7) day = Convert.ToInt32(Console.ReadLine());
if (day <= 5) Console.WriteLine("нет");
else Console.WriteLine("да");