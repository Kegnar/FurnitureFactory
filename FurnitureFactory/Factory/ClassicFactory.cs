using FurnitureFactory.Product;

namespace FurnitureFactory.Factory;

class ClassicFactory: Factory
{
    public override Chair CreateChair()
    {
        return new ClassicChair();
    }
         
    public override Table CreateTable()   
    {
        return new ClassicTable(); 
    }

    public override Wardrobe CreateWardrobe()
    {
        return new ClassicWardrobe();
    }
}