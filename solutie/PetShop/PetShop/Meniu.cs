/**************************************************************************
 *                                                                        *
 *  File:        Meniu.cs                                                 *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Aplicația va permite două roluri: utilizator             *
 *               și administrator, cu funcții diferite.                   *
 *                                                                        *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Clasa pentru construirea meniului.
    /// </summary>
    public class Meniu
    {
        /// <summary>
        /// Alegerea rolului
        /// </summary>
        public enum UserChoice { AdminMenu, UserMenu, PreviousMenu, Exit, AddProdus, RemoveProdus, ListHrana, ListJucarii, ListAnimale, ListObiecteDeIngrijire, Undefined, Cumparare };

        /// <summary>
        /// Starea meniului
        /// </summary>
        public enum MenuState { Main, Administrator, User };

        /// <summary>
        /// Optiunile meniului.
        /// </summary>
        public struct MenuOption
        {

            public readonly string Number;
            public readonly string Text;
            public readonly UserChoice Choice;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="number">Numarul de optiuni</param>
            /// <param name="text">Tipul de text</param>
            /// <param name="choice">Obiect de tip UserChoice</param>
            public MenuOption(string number, string text, UserChoice choice)
            {
                Number = number;
                Text = text;
                Choice = choice;
            }
        }

        /// <summary>
        /// Administrator
        /// </summary>
        public static void AdminMenu(out List<MenuOption> options)
        {
            options = new List<MenuOption>(5);
            //Introducerea unui produs
            options.Add(new MenuOption("1", "Introducerea unui produs", UserChoice.AddProdus));
            //Stegerea unui produs
            options.Add(new MenuOption("2", "Stegerea unui produs", UserChoice.RemoveProdus));

        }

        /// <summary>
        /// Utilizator
        /// </summary>
        public static void UserMenu(out List<MenuOption> options)
        {

            options = new List<MenuOption>();
            //Afisarea tuturor animalelor
            options.Add(new MenuOption("1", "Afisarea tuturor animalelor", UserChoice.ListAnimale));
            //Afisarea tuturor jucariilor
            options.Add(new MenuOption("2", "Afisarea tuturor jucariilor", UserChoice.ListJucarii));
            //Afisarea tuturor obiectlor de ingrijire
            options.Add(new MenuOption("3", "Afisarea tuturor obiectlor de ingrijire ", UserChoice.ListObiecteDeIngrijire));
            //Afisarea hranei
            options.Add(new MenuOption("4", "Afisarea hranei ", UserChoice.ListHrana));
            //Cumparare
            options.Add(new MenuOption("5", "Cumparare", UserChoice.Cumparare));

        }
    }
}
