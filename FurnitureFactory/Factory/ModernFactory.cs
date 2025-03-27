using FurnitureFactory.Interfaces;
using FurnitureFactory.Product;

namespace FurnitureFactory.Factory;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}