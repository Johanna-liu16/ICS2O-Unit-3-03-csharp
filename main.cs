// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function states user's address input.
        double radius;
        double volume;

        //Input
        Console.WriteLine("This program will calculate the volume of a sphere.");
        Console.WriteLine("");
        Console.Write("Enter radius: ");
        radius = float.Parse(Console.ReadLine());

        //Process
        volume = ((double)4 / (double)3) * Math.PI * Math.Pow(radius, 3);

        //Output
        Console.WriteLine("");
        Console.WriteLine("The volume is: " + (volume.ToString("0.00") + " mm³."));

        Console.WriteLine("\nDone.");
    }
}