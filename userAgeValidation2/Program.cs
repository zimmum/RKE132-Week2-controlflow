﻿// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutaja sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to instagram!");
}
else //if (userAge < 13)
{
    Console.WriteLine("You are too young to use instagram.");
}
