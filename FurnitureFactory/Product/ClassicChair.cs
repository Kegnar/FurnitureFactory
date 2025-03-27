using FurnitureFactory.Interfaces;
namespace FurnitureFactory.Product;

public class ClassicChair : IChair
{
    public void View()
    {
        Console.WriteLine("Создан классический стул");
    }
}