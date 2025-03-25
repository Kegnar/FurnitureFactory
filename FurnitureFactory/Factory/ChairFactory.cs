namespace FurnitureFactory.Factory;

class ChairFactory:Factory
{
    public override ChairFactory CreateChair()
    {
        return new Chair();
    }
}