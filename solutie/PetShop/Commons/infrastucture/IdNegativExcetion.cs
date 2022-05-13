/**************************************************************************
 *                                                                        *
 *  File:        FisierNotFoundException.cs                               *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description:  Exceptie daca ID este negativ                           *
 *                                                                        *   
 *                                                                        *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.infrastucture
{
    /// <summary>
    /// Clasa IdNegativExcetion
    /// </summary>
    public class IdNegativExcetion : Exception
    {
        public string Message { get; }

        /// <summary>
        /// Exceptie ID negativ
        /// </summary>
        /// <param name="message">Mesaj de tip string/param>
        public IdNegativExcetion(string message)
        {
            Message = $"{message}";
        }
    }
}
