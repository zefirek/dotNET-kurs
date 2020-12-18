using System;
using Transport.Data.Services;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPozycjaService actionService = new MenuPozycjaService();
            ItemService itemService = new ItemService();
            actionService = Initialize(actionService);

            Console.WriteLine("LOGISTYKA WITA");
            Console.WriteLine();
            Console.WriteLine("Toco robimy?");

            var mainMenu = actionService.GetMenuActionsByMenuName("Main");



        }
    }
}
