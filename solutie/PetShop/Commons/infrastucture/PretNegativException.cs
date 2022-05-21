/**************************************************************************
 *                                                                        *
 *  File:        FisierNotFoundException.cs                               *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description:  Exceptie daca pretul este negativ                       *
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
    /// Clasa PretNegativException
    /// </summary>
    public class PretNegativException : Exception
    {
        /// <summary>
        /// Mesajul exceptiei
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Exceptie pret negativ
        /// </summary>
        /// <param name="message">Mesaj de tip string/param>
        public PretNegativException(string message)
        {
            Message = message.ToString();
        }
    }
}
