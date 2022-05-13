/**************************************************************************
 *                                                                        *
 *  File:        Animal.cs                                                *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Punct din aplicatie ce ne permite sa introducem varsta   *
 *               animalului si categoria lui (caine sau pisica)           *   
 *                                                                        *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    /// <summary>
    /// Clasa animal
    /// </summary>
    public class Animal : Produs
    {
        /// <summary>
        /// Varsta animalului
        /// </summary>
        public int Varsta { get; set; }

        /// <summary>
        /// Categoria animalului (caine sau pisica)
        /// </summary>
        public string Categorie { get; set; }
    }

}
