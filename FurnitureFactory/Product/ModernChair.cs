using FurnitureFactory.Interfaces;
namespace FurnitureFactory.Product;

public class ModernChair : IChair
{
    public void View()
    {
        Console.WriteLine("Создан современный стол");
    }
}