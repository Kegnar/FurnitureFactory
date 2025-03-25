namespace FurnitureFactory.Factory;

public abstract class Factory
{
    public abstract ChairFactory CreateChair();
    public abstract TableFactory CreateTable();
    public abstract WadrobeFactory CreateWadrobe();
}

