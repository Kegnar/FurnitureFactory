using FurnitureFactory.Product;

namespace FurnitureFactory.Factory;

abstract class Factory
{
    public abstract Chair CreateChair();
    public abstract Table CreateTable();
    public abstract Wardrobe CreateWardrobe();
}