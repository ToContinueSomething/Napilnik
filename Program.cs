using Napilnik.Sources;
using System;

namespace Napilnik
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Delive(iPhone12, 10);
            warehouse.Delive(iPhone11, 1);

            Console.WriteLine("Вывод всех товаров на складе с их остатком");
            CellsView cellsView = new CellsView();
            cellsView.ShowProductCells(shop.Warehouse.Cells);

            Cart cart = shop.Cart();
            cart.Add(iPhone12, 3);
            cart.Add(iPhone11, 1);
            cart.Add(iPhone12, 2);

            Console.WriteLine("Вывод всех товаров в корзине");
            cellsView.ShowProductCells(cart.Cells);
            Console.WriteLine(cart.Order().Paylink);

            cart.Add(iPhone12, 5);
        }
    }
}