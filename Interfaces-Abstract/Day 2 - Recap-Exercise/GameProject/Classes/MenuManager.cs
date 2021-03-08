using GameProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameProject.Classes
{
    class MenuManager
    {
        public enum MenuLocation
        {
            Main,
            ShowInventory,
            ShowPlayerInfo,
            BattleArena,
            Exit
        }

        private List<MenuLocation> _menuItems;

        public MenuManager()
        {
            _menuItems = new List<MenuLocation>() { MenuLocation.ShowInventory, MenuLocation.ShowPlayerInfo, MenuLocation.BattleArena, MenuLocation.Exit };
        }

        public MenuLocation MainMenuBuilder(string title = "Choose an action : ")
        {
            int indexSelectedItem = 0;
            ConsoleKey key;

            do
            {
                Console.CursorVisible = false;
                Console.Clear();

                Console.WriteLine(title);
                Console.WriteLine();

                //Print the menu items
                for (int i = 0; i < _menuItems.Count; i++)
                {
                    if (i == indexSelectedItem)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(_menuItems[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(_menuItems[i]);
                    }
                }

                key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (indexSelectedItem > 0)
                        {
                            indexSelectedItem--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (indexSelectedItem < _menuItems.Count - 1)
                        {
                            indexSelectedItem++;
                        }
                        break;
                    default:
                        break;
                }

            } while (key != ConsoleKey.Enter);

            return _menuItems[indexSelectedItem];
        }

        public void ShowInventory(List<InventoryItem> inventoryItems)
        {
            List<string> inventoryLocations = new List<string> { "Weapons", "Armors", "Consumables" };

            int index = MenuBuilder(inventoryLocations, "Choose an Inventory category: ");

            if (index == -1) // No items
            {
                PrintNoItems();
                return;
            }
            else if (index == -2) // Escape
            {
                return;
            }
            else if(index == 0) //Weapons
            {
                ShowWeapons(inventoryItems);
            }
            else if (index == 1) //Armors
            {
                ShowArmors(inventoryItems);
            }
            else if (index == 2) //Consumables
            {
                Showconsumables(inventoryItems);
            }
        }

        //Alle Show... methodes kunnen in 1 methode gestoken worden door Generics, maar dat zien jullie later nog.
        public void ShowWeapons(List<InventoryItem> inventoryItems)
        {
            Console.Clear();

            if (inventoryItems.Count == 0)
            {
                PrintNoItems();
            }
            else
            {
                foreach (var item in inventoryItems)
                {
                    if (item is IWeapon)
                    {
                        Console.WriteLine(item.GetDetails());
                    }
                }
            }

            PrintGoBackMessage();
        }

        public void ShowArmors(List<InventoryItem> inventoryItems)
        {
            Console.Clear();

            if (inventoryItems.Count == 0)
            {
                PrintNoItems();
            }
            else
            {
                foreach (var item in inventoryItems)
                {
                    if (item is IArmor)
                    {
                        Console.WriteLine(item.GetDetails());
                    }
                }
            }

            PrintGoBackMessage();
        }

        public void Showconsumables(List<InventoryItem> inventoryItems)
        {
            Console.Clear();

            if (inventoryItems.Count == 0)
            {
                PrintNoItems();
            }
            else
            {
                foreach (var item in inventoryItems)
                {
                    if (item is IConsumable)
                    {
                        Console.WriteLine(item.GetDetails());
                    }
                }
            }

            PrintGoBackMessage();
        }

        public void ShowPlayerInfo(Player player)
        {
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Health Points: {player.CurrentHealthPoints}/{player.MaxHealthPoints}");
            var equippedWeapon = player.EquippedWeapon as InventoryItem;
            Console.WriteLine($"Equipped Weapon: {equippedWeapon.GetDetails()}");

            PrintGoBackMessage();
        }

        public void GoToBattleArena(ICharacter player)
        {
            Console.WriteLine(@",  ____  ,");
            Console.WriteLine(@"|\/    \/|");
            Console.WriteLine(@"\ ° 1 °  /");
            Console.WriteLine(@" | wwww |");
            Console.WriteLine(@" \__Y___/");

            var enemy = new Enemy();

            do
            {
                int playerDamage = player.DoDamage();
                enemy.TakeDamage(playerDamage);
                Console.WriteLine();
                Thread.Sleep(2000);

                if (enemy.CurrentHealthPoints <= 0) break;

                player.TakeDamage(enemy.DoDamage());
                Thread.Sleep(2000);

                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine();
            }
            while (player.CurrentHealthPoints > 0 && enemy.CurrentHealthPoints > 0);

            Console.WriteLine("*****************");
            Console.WriteLine();

            if (player.CurrentHealthPoints <= 0)
            {
                Console.WriteLine("You've lost the game.");
            }
            else if (enemy.CurrentHealthPoints <= 0)
            {
                Console.WriteLine("You've defeated the enemy!");
            }

            PrintGoBackMessage();
        }

        private int MenuBuilder(List<string> items, string title = "Choose an item :")
        {
            if (items.Count == 0)
            {
                return -1;
            }

            int indexSelectedItem = 0;
            ConsoleKey key;
            do
            {
                Console.CursorVisible = false;
                Console.Clear();

                Console.WriteLine(title);
                Console.WriteLine();

                for (int i = 0; i < items.Count; i++)
                {
                    if (i == indexSelectedItem)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(items[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(items[i]);
                    }
                }

                key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (indexSelectedItem > 0)
                        {
                            indexSelectedItem--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (indexSelectedItem < items.Count - 1)
                        {
                            indexSelectedItem++;
                        }
                        break;
                    case ConsoleKey.Escape:
                        return -2;
                    default:
                        break;
                }

            } while (key != ConsoleKey.Enter);

            return indexSelectedItem;
        }

        void PrintNoItems()
        {
            Console.Clear();
            Console.WriteLine("No items available.");

            PrintGoBackMessage();
        }

        public void PrintGoBackMessage(string title = "Press a button to return.")
        {
            Console.WriteLine();
            Console.WriteLine(title);
            Console.ReadKey();
        }

        //StackOverflow example: https://stackoverflow.com/questions/31996519/listen-on-esc-while-reading-console-line
        ConsoleKeyInfo ReadLine(out string text)
        {
            ConsoleKeyInfo inputKey;
            text = string.Empty;

            do
            {
                inputKey = Console.ReadKey();
                if (inputKey.Key != ConsoleKey.Escape && inputKey.Key != ConsoleKey.Enter)
                {
                    text += inputKey.KeyChar;
                }
            } while (inputKey.Key != ConsoleKey.Escape && inputKey.Key != ConsoleKey.Enter);

            return inputKey;
        }
    }
}
