/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Principalul punct de intrare pentru aplicație.           *
 *                                                                        *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    static class Program
    {
        /// <summary>
        /// Principalul punct de intrare pentru aplicație.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new FormPetShop();
            form.SetPresenter(new Presenter.Presenter());
            Application.Run(form);
        }
    }
}
