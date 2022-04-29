using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class Meniu
    {
        public enum UserChoice { AdminMenu, UserMenu, PreviousMenu, Exit, AddProdus, RemoveProdus,ListHrana, ListJucarii, ListAnimale, ListObiecteDeIngrijire, Undefined, Cumparare };
        public enum MenuState { Main, Administrator, User };

        public struct MenuOption
        {
            // structura pentru construirea dinamica a unui meniu
            // reprezinta o optiune intr-un meniu

            public readonly string Number;
            public readonly string Text;
            public readonly UserChoice Choice;

            public MenuOption(string number, string text, UserChoice choice)
            {
                Number = number;
                Text = text;
                Choice = choice;
            }
        }

        // metodele de mai jos trebuie plasate in clasele potrivite
        public static void MainMenu(out List<MenuOption> options, out string action)
        {
            action = "Selectati rolul";
            options = new List<MenuOption>(3);
            options.Add(new MenuOption("1", "Utilizator", UserChoice.UserMenu));
            options.Add(new MenuOption("2", "Administrator", UserChoice.AdminMenu));
            options.Add(new MenuOption("3", "Iesire", UserChoice.Exit));
        }

        public static void AdminMenu(out List<MenuOption> options, out string action)
        {
            action = "Selectati actiunea dorita";
            options = new List<MenuOption>(5);
           options.Add(new MenuOption("1", "Introucerea unui produs", UserChoice.AddProdus));
            options.Add(new MenuOption("2", "Stegerea unui produs", UserChoice.RemoveProdus));
            options.Add(new MenuOption("3", "Intoarcere la meniul principal", UserChoice.PreviousMenu));
            options.Add(new MenuOption("4", "Iesire", UserChoice.Exit));
        }

        public static void UserMenu(out List<MenuOption> options, out string action)
        {
            action = "Selectati actiunea dorita";
            options = new List<MenuOption>();
            options.Add(new MenuOption("1", "Afisare tuturor animalelor", UserChoice.ListAnimale));
            options.Add(new MenuOption("2", "Afisare tuturor jucariilor", UserChoice.ListJucarii));
            options.Add(new MenuOption("3", "Afisare tuturor obiectlor de ingrijire ", UserChoice.ListObiecteDeIngrijire));
            options.Add(new MenuOption("4", "Afisare hranei ", UserChoice.ListHrana));
            options.Add(new MenuOption("5", "Cumparare", UserChoice.Cumparare));
            options.Add(new MenuOption("6", "Intoarcere la meniul principal", UserChoice.PreviousMenu));
            options.Add(new MenuOption("7", "Iesire", UserChoice.Exit));
        }
    }
}
