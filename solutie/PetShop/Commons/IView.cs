/**************************************************************************
 *                                                                        *
 *  File:        IView.cs                                             *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description:                                                          *
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
    /// Interfata IView
    /// </summary>
    public interface IView
    {
        void SetPresenter(IPresenter presenter);

    }
}
