﻿using FurnitureFactory.Interfaces;
namespace FurnitureFactory.Product;

public class ModernTable : ITable
{
    public void View()
    {
        Console.WriteLine("Создан современный стол");
    }
}