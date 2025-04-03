﻿using Dolgozok.Console.Models;
using Dolgozok.Console.Repos;

Console.WriteLine("1. feladat");

try
{
    Employee empty = new Employee("", "Null");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("2. feladat");
Employee janos = new Employee("janos@ceg.hu", "Dolgozó János");
Console.WriteLine(janos);

Console.WriteLine("3. feladat");
try
{
    janos.Pay(-300000);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("4. feladat");
janos.Pay(200000);
janos.Pay(300000);
Console.WriteLine(janos);

EmployeeRepo repo = new EmployeeRepo();
Console.WriteLine($"Dolgozók száma: {repo.GetNumberOfWorkers()}");
