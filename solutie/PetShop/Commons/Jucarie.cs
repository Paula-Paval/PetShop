/**************************************************************************
 *                                                                        *
 *  File:        Jucarie.cs                                               *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Punct din aplicatie ce ne permite sa introducem o        *
 *               jucarie cu o anumita denumire.                           *
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
    /// Clasa jucarie
    /// </summary>
    public class Jucarie : Produs
    {
        /// <summary>
        /// Denumirea jucariei
        /// </summary>
        public string Denumire { get; set; }
    }
}
