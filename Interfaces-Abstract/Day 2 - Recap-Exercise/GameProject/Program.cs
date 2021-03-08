using GameProject.Classes;
using GameProject.Interfaces;
using System;
using static GameProject.Classes.MenuManager;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Best Game Ever";

            MenuManager menuManager = new MenuManager();
            Player player = new Player();

            Console.Write("Please enter your name: ");
            player.Name = Console.ReadLine();

            MenuLocation current = MenuLocation.Main;

            do
            {
                Console.Clear();

                switch (current)
                {
                    case MenuLocation.Main:
                        current = menuManager.MainMenuBuilder($"Hello {player.Name}, choose an action : ");
                        break;
                    case MenuLocation.ShowInventory:
                        menuManager.ShowInventory(player.InventoryItems);
                        current = MenuLocation.Main;
                        break;
                    case MenuLocation.ShowPlayerInfo:
                        menuManager.ShowPlayerInfo(player);
                        current = MenuLocation.Main;
                        break;
                    case MenuLocation.BattleArena:
                        menuManager.GoToBattleArena(player);
                        current = MenuLocation.Main;
                        break;
                    default:
                        break;
                }
            } while (current != MenuLocation.Exit);

            Console.Clear();
            menuManager.PrintGoBackMessage("Press a button to exit the game.");



            Console.ReadLine();
        }
    }
}
