//Exercise 9 and exerise 5 of control flow section

Console.WriteLine("Ingresa numeros separados por comas: ");
var num = Console.ReadLine();


var useArray = num.ToString().Split(',').Select(i => int.Parse(i)).ToArray();

var aux = 0;
for (int i = 0; i < useArray.Length; i++)
{
    if (useArray[i] > aux)
    {
        aux = useArray[i];
    }
}
Console.WriteLine("El numero mayor de los que ingresaste es: " + aux);
