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

        
    

        public static void AdminMenu(out List<MenuOption> options)
        {         
            options = new List<MenuOption>(5);
            options.Add(new MenuOption("1", "Introducerea unui produs", UserChoice.AddProdus));
            options.Add(new MenuOption("2", "Stegerea unui produs", UserChoice.RemoveProdus));
        
        }

        public static void UserMenu(out List<MenuOption> options)
        {
            
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
