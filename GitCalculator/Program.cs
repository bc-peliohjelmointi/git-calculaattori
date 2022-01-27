using System;

Console.WriteLine("Tervettuloa Calculaattoriin! Lasketaan yksinkertainen yhteenlasku.");

int firstNumber, secondNumber;

Console.WriteLine("Lasketaan x + y. Anna x:");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Anna y:");
secondNumber = Convert.ToInt32(Console.ReadLine());

int summa = firstNumber + secondNumber;

Console.WriteLine("Lasketaan...");
Console.WriteLine(firstNumber + " + " + secondNumber + " = " + summa);