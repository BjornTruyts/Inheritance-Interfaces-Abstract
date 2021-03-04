using CarCompany.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static CarCompany.Classes.MenuManager;

namespace CarCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuManager menuManager = new MenuManager();

            Company company = new Company("DDT Oké Cars");

            Console.Title = company.CompanyName;

            MenuLocation current = MenuLocation.Main;

            do
            {
                Console.Clear();

                switch (current)
                {
                    case MenuLocation.Main:
                        current = menuManager.MainMenuBuilder();
                        break;
                    case MenuLocation.ShowCars:
                        menuManager.ShowCars(company.Cars);
                        current = MenuLocation.Main;
                        break;
                    case MenuLocation.AddCar:
                        menuManager.AddCar(company.Cars);
                        current = MenuLocation.Main;
                        break;
                    case MenuLocation.EditCar:
                        menuManager.EditCar(company.Cars);
                        current = MenuLocation.Main;
                        break;
                    case MenuLocation.RemoveCar:
                        menuManager.RemoveCar(company.Cars);
                        current = MenuLocation.Main;
                        break;
                    default:
                        break;
                }
            } while (current != MenuLocation.Exit);

            Console.Clear();
            menuManager.PrintGoBackMessage("Press a button to exit the application.");
        }
    }

}
