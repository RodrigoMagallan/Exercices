// See https://aka.ms/new-console-template for more information
//Excercise 1, Write a p[rogram and ask the user to enter a number.The number should be between 1 to 10. valid if is bettween this range and invalid if its aout of this range
Console.WriteLine("Excercise 1\n");
int number;


Console.WriteLine("Ingresa un numero del 1-10");
number = Convert.ToInt32(Console.ReadLine());

if (number > 1 && number< 10)
{

   Console.WriteLine("Valid number");
}
else
{
    Console.WriteLine("Invalid");
}


String resp = number > 1 && number < 10 ? "Valid ternary" : "Invalid ternary";
Console.WriteLine(resp);