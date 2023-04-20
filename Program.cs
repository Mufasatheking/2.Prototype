﻿// See https://aka.ms/new-console-template for more information

using Prototype;

Console.WriteLine("***Prototype Pattern Demo***\n");

BasicCar nano_base = new Nano("Green Nano") {Price = 100000};
BasicCar ford_base = new Ford("Ford Yellow") {Price = 500000};

BasicCar bc1;
//Nano
bc1 = nano_base.Clone();
bc1.Price = nano_base.Price+BasicCar.SetPrice();
Console.WriteLine("Car is: {0}, and it's price is Rs. {1} ",bc1.ModelName,bc1.Price);

//Ford            
bc1 = ford_base.Clone();
bc1.Price = ford_base.Price+BasicCar.SetPrice();
Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", bc1.ModelName, bc1.Price);
Console.ReadLine();