using System;
using System.Collections.Generic;
using System.Text;

namespace CarCompany.Classes
{
    public class MenuManager
    {
        public enum MenuLocation
        {
            Main,
            ShowCars,
            AddCar,
            EditCar,
            RemoveCar,
            Exit
        }

        private List<MenuLocation> _menuItems;

        public MenuManager()
        {
            _menuItems = new List<MenuLocation>() { MenuLocation.ShowCars, MenuLocation.AddCar, MenuLocation.EditCar, MenuLocation.RemoveCar, MenuLocation.Exit };
        }

        public void ShowCars(List<Car> cars)
        {
            Console.Clear();
            if (cars.Count == 0)
            {
                PrintNoItems();
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car.GetDetails());
                }

                PrintGoBackMessage();
            }
        }

        public void AddCar(List<Car> cars)
        {
            do
            {
                Car newCar = CarBuilder();

                if(newCar != null)
                {
                    cars.Add(newCar);
                }
            } while (CreateBoolMenu("Do you want to add another car?"));
        }

        public void EditCar(List<Car> cars)
        {
            do
            {
                int index = MenuBuilder(cars, "Choose a car to edit : ");

                if (index == -1) // No items
                {
                    PrintNoItems();
                    return;
                }
                else if (index == -2) // Escape
                {
                    return;
                }

                Car car = CarBuilder();

                if (car != null)
                {
                    cars[index] = car;
                }
            } while (CreateBoolMenu("Do you want to modify another car? "));
        }

        public void RemoveCar(List<Car> cars)
        {
            do
            {
                int index = MenuBuilder(cars, "Select a car you wish to remove :");

                if (index == -1)
                {
                    PrintNoItems();
                    return;
                }
                else if (index == -2)
                {
                    return;
                }

                if (CreateBoolMenu("Are you certain you want to remove this car ?"))
                {
                    cars.RemoveAt(index);
                }

            } while (CreateBoolMenu("Do you want to remove another car ?"));
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

        //StackOverflow example: https://stackoverflow.com/questions/46908148/controlling-menu-with-the-arrow-keys-and-enter
        /// <summary>
        /// Generates a menu with items that can be selected with the arrow keys
        /// </summary>
        /// <param name="items">List items</param>
        /// <param name="title">Title above list</param>
        /// <returns>Returns id of selected item , returns -1 when list is empty , return -2 on esc</returns>
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
        
        private int MenuBuilder(List<Car> cars, string title)
        {
            List<string> carDetails = new List<string>();

            foreach (var car in cars)
            {
                carDetails.Add(car.GetDetails());
            }

            return MenuBuilder(carDetails, title);
        }

        private Car CarBuilder()
        {
            Console.Clear();
            List<string> questionList = new List<string>();
            questionList.Add("Type (Gas/Hybrid/Electric)");
            questionList.Add("Brand");
            questionList.Add("Model");
            questionList.Add("Construction Year");

            string[] resultList = new string[questionList.Count];

            for (int i = 0; i < resultList.Length; i++)
            {
                Console.Clear();
                string value;
                Console.Write($"Give a value for { questionList[i] } : ");
                var key = ReadLine(out value);

                if (key.Key == ConsoleKey.Escape)
                {
                    return null;
                }
                else
                {
                    resultList[i] = value;
                }
            }

            //int constructionYear = int.Parse(resultList[3]); //This will cause an exception if the value is not numeric.

            //--------|One way to validate the Construction year|--------

            bool validNumber = int.TryParse(resultList[3], out int constructionYear);
            while (!validNumber)
            {
                Console.Clear();
                Console.WriteLine("Construction Year needs to be a number!");

                Console.Write("Give a value for {0} : ", questionList[3]);
                var key = ReadLine(out string value);

                if (key.Key == ConsoleKey.Escape)
                {
                    return null;
                }
                else
                {
                    validNumber = int.TryParse(value, out constructionYear);
                }
            }

            //--------|Another way to validate the Construction year|--------

            //int constructionYear;
            //try
            //{
            //    constructionYear = int.Parse(resultList[3]);
            //}
            //catch (FormatException)
            //{
            //    PrintGoBackMessage("You have to input a valid number for Construction Year!");

            //    return CarBuilder();
            //}

            Car newCar;
            switch (resultList[0])
            {
                case "Gas":
                    newCar = new GasCar(resultList[1], resultList[2], constructionYear);
                    break;
                case "Hybrid":
                    newCar = new HybridCar(resultList[1], resultList[2], constructionYear);
                    break;
                case "Electric":
                    newCar = new ElectricCar(resultList[1], resultList[2], constructionYear);
                    break;
                default:
                    newCar = new Car(resultList[1], resultList[2], constructionYear);
                    break;
            }

            return newCar;
        }

        bool CreateBoolMenu(string title)
        {
            return !Convert.ToBoolean(MenuBuilder(
                        new List<String>() { "Yes", "No" },
                        title));
        }

        void PrintNoItems()
        {
            Console.Clear();
            Console.WriteLine("No cars available.");

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
