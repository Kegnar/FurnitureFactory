using FurnitureFactory.Product;

namespace FurnitureFactory.Factory;

class ModernFactory: Factory
{
    public override Chair CreateChair()
    {
        return new ModernChair();
    }
         
    public override Table CreateTable()
    {
        return new ModernTable();
    }
    public override Wardrobe CreateWardrobe()
    {
        return new ModernWardrobe();
    }
}