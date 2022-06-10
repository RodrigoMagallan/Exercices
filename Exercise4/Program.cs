//Exercise 4
Console.WriteLine("\nExcercie 4, Speed Limit");

Console.WriteLine("Enter the speed limit: ");
int speedLimit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the speed: ");
int speed = Convert.ToInt32(Console.ReadLine());

if (speedLimit > speed)
{
    Console.WriteLine("You're ok");
}
else
{
    int demeritsPoint = (speed - speedLimit) / 5;
    if (demeritsPoint >= 12)
    {
        Console.WriteLine("License Suspended");
    }
    else
    {
        Console.WriteLine("You have: " + demeritsPoint, "Demerit Points");
    }
}
