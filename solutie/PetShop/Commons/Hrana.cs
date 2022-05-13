/**************************************************************************
 *                                                                        *
 *  File:        Hrana.cs                                                 *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Punct din aplicatie ce ne permite sa introducem          *
 *               categoria de mancare si denumirea acesteia               *
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
    /// Clasa hrana
    /// </summary>
    public class Hrana : Produs
    {
        /// <summary>
        /// Categoria hranei
        /// </summary>
        public string Categorie { get; set; }

        /// <summary>
        /// Denumirea hranei
        /// </summary>
        public string Denumire { get; set; }
    }
}
