/**************************************************************************
 *                                                                        *
 *  File:        ObiecteIngrijire.cs                                      *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Punct din aplicatie ce ne permite sa introducem          *
 *               categoria obiectului de ingrijire si denumirea lui      *
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
    /// Clasa pentru obiectele de ingrijire ale animalului
    /// </summary>
    public class ObiectIngrijire : Produs
    {
        /// <summary>
        /// Categoria obiectului de ingrijire
        /// </summary>
        public string Categorie { get; set; }
        /// <summary>
        /// Denumirea obiectului de ingrijire
        /// </summary>
        public string Denumire { get; set; }
    }
}
