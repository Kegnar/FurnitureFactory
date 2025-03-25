using FurnitureFactory.Design;

namespace FurnitureFactory.Factory;

internal abstract class Factory
{
    public abstract Chair CreateChair();
    public abstract Table CreateTable();
    public abstract Wardrobe CreateWardrobe();
}