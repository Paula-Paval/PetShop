/**************************************************************************
 *                                                                        *
 *  File:        IView.cs                                             *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Interfata ce contine operatiile view-ului, punctul       *
 *              din interfata ce comunica cu utilizatorul                 *
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
    /// Interfata IView
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Set Presenter
        /// </summary>
        /// <param name="presenter">Obiect de ti IPrsenter</param>
        void SetPresenter(IPresenter presenter);

    }
}
