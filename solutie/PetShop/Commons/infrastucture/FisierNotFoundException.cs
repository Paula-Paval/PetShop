/**************************************************************************
 *                                                                        *
 *  File:        FisierNotFoundException.cs                               *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description:  Exceptie daca fiserul nu este gasit                     *
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
    /// Clasa FisierNotFoundException
    /// </summary>
    public class FisierNotFoundException : Exception
    {
        public string Message { get; }

        /// <summary>
        /// Exceptie fisier negasit
        /// </summary>
        /// <param name="message">Mesaj de tip string/param>
        public FisierNotFoundException(string message)
        {
            Message = $"{message}";
        }

    }
}
