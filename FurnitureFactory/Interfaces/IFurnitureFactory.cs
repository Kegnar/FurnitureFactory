namespace FurnitureFactory.Interfaces;

// 4. Абстрактная фабрика
public interface IFurnitureFactory
{
    IChair CreateChair();
    ITable CreateTable();
}