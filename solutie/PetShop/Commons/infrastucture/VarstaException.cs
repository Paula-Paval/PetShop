/**************************************************************************
 *                                                                        *
 *  File:        FisierNotFoundException.cs                               *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description:  Exceptie de varsta                                      *
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
    /// Clasa VarstaException
    /// </summary>
    public class VarstaException : Exception
    {
        /// <summary>
        /// Mesajul exceptiei
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Exceptie varsta
        /// </summary>
        /// <param name="message">Mesaj de tip string/param>
        public VarstaException(string message)
        {
            Message = message.ToString();
        }
    }
}
