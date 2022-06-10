//Excercice 2 


Console.WriteLine("Number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

string maxNumber = number1 > number2 ? @"the biggest number is: " + number1 : @"The bisggest number is: " + number2;
Console.WriteLine(maxNumber);

