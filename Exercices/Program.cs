// See https://aka.ms/new-console-template for more information

//string pato = "Anita lava la tina";
//string reverse = String.Empty;
//for (int i = pato.Length - 1 ; i >= 0 ; i--)
//{
//    reverse += pato[i];
//}
//Console.WriteLine(reverse);

//foreach (var item in reverse)
//{
//    Console.WriteLine(item);
//}

//var num = new int[]  // Object initialization
//{
//    1,
//    2,
//    3,
//    4,
//    4
//};

//foreach (var number in num)  // it an easier way to iterate over a list
//{
//    Console.WriteLine(number);
//}

//for (int i = num.Length -1 ; i >= 0; i--)
//{
//    if (num[i] == num[i])
//    {
//        num[i] = num[i + 1];
//    }
//    Console.WriteLine(num[i]);
//}

//var name = "Thomas Shelby";

//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}

//foreach (var item in name)
//{
//    Console.WriteLine(item);
//}

//const int passwordLength = 14;
//var buffer = new char[passwordLength];
//var rand = new Random();  //instance of tha random class
//for (int i = 0; i < passwordLength; i++)
//    buffer[i] = (char)( 'a' + rand.Next(0, 26));
//var pswd = new string(buffer);
//Console.WriteLine(pswd);

//var aux = 0;
//var rest = 0;
//for (int i = 1; i <= 100; i++)
//{
//    rest = i % 3;
//    if (rest == 0)
//    {
//        Console.WriteLine(i);
//        aux++;
//    }

//}
//Console.WriteLine("numeros totales divisibles entre 3 sin residuo:  " + aux);
//Exercise 2
//var aux = 0;
//while (true)
//{
//    Console.WriteLine("Enter a number: ");
//    var num = Console.ReadLine();
//    if (num == "ok" || String.IsNullOrWhiteSpace(num))
//    {
//        Console.WriteLine("You have exit the sum, the total at the moment is: " + aux);
//        break;
//    }
//    aux += Convert.ToInt32(num);


//}

//Console.WriteLine("The sum is: " + aux);


//Console.WriteLine("Enter a number: ");
//var toFact = Convert.ToInt32(Console.ReadLine());
//int aux = 1;
//for (int i = 1; i <= toFact; i++)
//{
//    aux *= i;
//}

//Console.WriteLine(aux);

//int fact = 1;
//for ( var i = toFact ;  i >= 1; i--)
//{

//     fact *= i; 
//}
//Console.WriteLine(fact);


//var rand = new Random();
//var secretNumber = rand.Next(1,10);

//Console.WriteLine(secretNumber);

//while (true)
//{
//    Console.WriteLine("Adivina el numero, inserta un numero del 1 al 10: ");
//    var numb = Convert.ToInt32(Console.ReadLine());
//    if (secretNumber == numb)
//    {
//        Console.WriteLine("You Won");
//        break;
//    }
//    Console.WriteLine("You lost");
//    continue;
//}

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
Console.WriteLine("El numero mayor de los que ingresaste es: "+ aux);



