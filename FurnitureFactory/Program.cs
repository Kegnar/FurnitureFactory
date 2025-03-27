using FurnitureFactory.Factory;


var modernFactory = new ModernFurnitureFactory();
var modernChair = modernFactory.CreateChair();
var modernTable = modernFactory.CreateTable();

Console.WriteLine("Современный стиль:");
modernChair.View();
modernTable.View();


var classicFactory = new ClassicFurnitureFactory();
var classicChair = classicFactory.CreateChair();
var classicTable = classicFactory.CreateTable();

Console.WriteLine("\nКлассический стиль:");
classicChair.View();
classicTable.View();