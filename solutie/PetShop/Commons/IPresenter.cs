/**************************************************************************
 *                                                                        *
 *  File:        IPresenter.cs                                             *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Interfata ce contine operatiile pe care le poate realiza *
 *               presenter-ul, punctul din aplicatie ce leaga modelul de view *
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
    /// Interfata IPresenter
    /// </summary>
    public interface IPresenter
    {
        /// <summary>
        /// Adaugare animal
        /// </summary>
        /// <param name="p">Obiect de tip Animal</param>
        void AddAnimal(Animal p);

        /// <summary>
        /// Adaugare obiecte de ingrijire
        /// </summary>
        /// <param name="p">Obiect de tip ObiectIngrijire</param>
        void AddObiecteIngrijire(ObiectIngrijire p);

        /// <summary>
        /// Adaugare jucarii
        /// </summary>
        /// <param name="p">Obiect de tip Jucarie</param>
        void AddJucarii(Jucarie p);

        /// <summary>
        /// Adaugare hrana
        /// </summary>
        /// <param name="p">Obiect de tip Hrana</param>
        void AddHrana(Hrana p);

        /// <summary>
        /// stergerea unui produs
        /// </summary>
        /// <param name="id">ID-ul produsului</param>
        /// <param name="tip">Tipul produsului</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        bool RemoveProdus(int id, string tip);
        /// <summary>
        /// Cumpararea unui produs
        /// </summary>
        /// <param name="tip">Tipul produsului cumparat</param>
        /// <param name="denumire">Denumirea produsului cumparat</param>
        /// <returns>Returneaza produsul cumparat</returns>
        bool Cumpara(string tip, string denumire);
        /// <summary>
        /// Lista
        /// </summary>
        /// <param name="tip">Tipul listei</param>
        /// <returns>Returneaza lista</returns>
        string List(string tip);

        /// <summary>
        /// Initializare
        /// </summary>
        void Init();
    }
}
