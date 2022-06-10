//Exercise 8 and 4 of control flow section

var rand = new Random();
var secretNumber = rand.Next(1, 10);

Console.WriteLine(secretNumber);

while (true)
{
    Console.WriteLine("Adivina el numero, inserta un numero del 1 al 10: ");
    var numb = Convert.ToInt32(Console.ReadLine());
    if (secretNumber == numb)
    {
        Console.WriteLine("You Won");
        break;
    }
    Console.WriteLine("You lost");
    continue;
}
