﻿using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int ticketPrice;

        if (age <= 12 || age >= 65)
            ticketPrice = 7;
        else
            ticketPrice = 10;

        Console.WriteLine("Your ticket price is: GHC" + ticketPrice);
    }
}