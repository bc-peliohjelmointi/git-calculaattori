using System;

Console.WriteLine("Tervettuloa Calculaattoriin! Lasketaan yksinkertainen yhteenlasku ja vähennyslasku.");

int firstNumber, secondNumber;

Console.WriteLine("Anna x:");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Anna y:");
secondNumber = Convert.ToInt32(Console.ReadLine());

int summa = firstNumber + secondNumber;
int erotus = firstNumber - secondNumber;


Console.WriteLine("Lasketaanko näiden x:n ja y:n summa vai erotus?");
string operaattorinValinta = Console.ReadLine().ToLower();

if (operaattorinValinta == "summa" || operaattorinValinta == "+")
{
    Console.WriteLine("Lasketaan x + y...");
    Console.WriteLine(firstNumber + " + " + secondNumber + " = " + summa);
}

else if (operaattorinValinta == "erotus" || operaattorinValinta == "-")
{
    Console.WriteLine("Lasketaan x - y...");
    Console.WriteLine(firstNumber + " - " + secondNumber + " = " + erotus);
}

