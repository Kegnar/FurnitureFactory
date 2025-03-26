/*Вариант 2: Реализуйте абстрактную фабрику для создания семейства объектов мебели (например,
             стульев и столов) в различных стилях (например, современный, классический).
    Factory - "мебельный комбинат им.Папы Карло" (абстрактный класс)

TODO:   расписать внутреннюю логику у классов
*/

using FurnitureFactory.Factory;
using FurnitureFactory.Product;

class Client
{
    private Chair _chair;
    private Table _table;
    private Wardrobe _wardrobe;
    public Client(Factory factory)
    {
        _table = factory.CreateTable();
        _chair = factory.CreateChair();
        _wardrobe = factory.CreateWardrobe();
    }
    public void Run()
    { }
}
