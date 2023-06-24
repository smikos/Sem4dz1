int Prompt(string message)
{
    System.Console.Write($"{message} >");
    string inputeStr = Console.ReadLine();
    int value;
    if ( int.TryParse(inputeStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Извините, но вы ввели не число");
    Environment.Exit(0);
    return 0;
}
int a = Prompt("Введите число");
int b = Prompt("Введите число");
int c =1;
int r =1;
while ( c<=b)
{
    r=r*a;
    c=c+1;
}
System.Console.WriteLine(r);