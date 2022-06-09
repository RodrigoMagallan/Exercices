//Exercice 3

Console.WriteLine("Insert the Height of the image: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the width of the image: ");
int width = Convert.ToInt32(Console.ReadLine());

string typeOfImage = height > width ? "Your image is a portrait" : "Your image is a landscape :) ";
Console.WriteLine(typeOfImage);
