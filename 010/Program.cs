int n = Convert.ToInt32(Console.ReadLine());
while (n > 999 || n < 100)
    n = Convert.ToInt32(Console.ReadLine());
int res = (n/10)%10;
Console.WriteLine(res);
