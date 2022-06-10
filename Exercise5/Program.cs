//Exercise 5 control flow exercise 1

var aux = 0;
var rest = 0;
for (int i = 1; i <= 100; i++)
{
    rest = i % 3;
    if (rest == 0)
    {
        Console.WriteLine(i);
        aux++;
    }

}
Console.WriteLine("numeros totales divisibles entre 3 sin residuo:  " + aux);
