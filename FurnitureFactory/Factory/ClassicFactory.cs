using FurnitureFactory.Interfaces;
using FurnitureFactory.Product;

namespace FurnitureFactory.Factory;

public class ClassicFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ClassicChair();
    }

    public ITable CreateTable()
    {
        return new ClassicTable();
    }
}