/**************************************************************************
 *                                                                        *
 *  File:        Produs.cs                                                *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Punct din aplicatie ce ne permite sa introducem un       *
 *               produs cu o anumit ID si un anumit pret.                 *
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
    /// Clasa produs
    /// </summary>
    public class Produs
    {
        /// <summary>
        /// ID-ul produsului
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Pretul produsului
        /// </summary>
        public double Pret { get; set; }

    }
}
