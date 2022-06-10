//Exercise 6 and exercise  2 of control flow
var aux = 0;
while (true)
{
    Console.WriteLine("Enter a number: ");
    var num = Console.ReadLine();
    if (num == "ok" || String.IsNullOrWhiteSpace(num))
    {
        Console.WriteLine("You have exit the sum, the total at the moment is: " + aux);
        break;
    }
    aux += Convert.ToInt32(num);


}

Console.WriteLine("The sum is: " + aux);
