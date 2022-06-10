// Exercise 7 and 3 of control flow section
Console.WriteLine("Enter a number: ");
var toFact = Convert.ToInt32(Console.ReadLine());
int aux = 1;
for (int i = 1; i <= toFact; i++)
{
    aux *= i;
}

Console.WriteLine(aux);

int fact = 1;
for (var i = toFact; i >= 1; i--)
{

    fact *= i;
}
Console.WriteLine(fact);
