using FurnitureFactory.Interfaces;
namespace FurnitureFactory.Product;

public class ClassicTable : ITable
{
    public void View()
    {
        Console.WriteLine("Создан классический стол");
    }
}