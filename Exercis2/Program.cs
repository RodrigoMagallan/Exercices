//Excercice 2 


Console.WriteLine("Number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

string maxNumber = number1 > number2 ? @"the biggest number is: " + number1 : @"The bisggest number is: " + number2;
Console.WriteLine(maxNumber);

//Exercice 3

Console.WriteLine("Insert the Height of the image: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the width of the image: ");
int width = Convert.ToInt32(Console.ReadLine());

string typeOfImage = height > width ? "Your image is a portrait" : "Your image is a landscape :) ";
Console.WriteLine(typeOfImage);