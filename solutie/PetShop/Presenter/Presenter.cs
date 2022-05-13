/**************************************************************************
 *                                                                        *
 *  File:        Presenter.cs                                             *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description:                                                          *
 *                                                                        *
 *                                                                        *
 **************************************************************************/
using Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    /// <summary>
    /// Clasa prezentator
    /// </summary>
    public class Presenter : IPresenter
    {
        private IModel _model;

        /// <summary>
        /// Constructor
        /// </summary>
        public Presenter()
        {
            _model = new Model.Model();
        }
        /// <summary>
        /// Adaugare animal
        /// </summary>
        public void AddAnimal(Animal p)
        {
            _model.AddAnimal(p);
        }

        /// <summary>
        /// Adaugare obiecte de ingrijire
        /// </summary>
        public void AddObiecteIngrijire(ObiectIngrijire p)
        {
            _model.AddObiecteIngrijire(p);
        }

        /// <summary>
        /// Adaugare jucarii
        /// </summary>
        public void AddJucarii(Jucarie p)
        {
            _model.AddJucarii(p);
        }

        /// <summary>
        /// Adaugare hrana
        /// </summary>
        public void AddHrana(Hrana p)
        {
            _model.AddHrana(p);
        }

        /// <summary>
        /// Initializare
        /// </summary>

        public void Init()
        {
            _model.InitializeData();
        }

        /// <summary>
        /// Existenta produs
        /// </summary>
        public bool ProdusExists(string tip, string denumire)
        {
            return _model.Exists(tip, denumire);
        }

        /// <summary>
        /// stergerea unui produs
        /// </summary>
        public bool RemoveProdus(int id, string tip)
        {
            switch (tip)
            {
                case Constante.Animal:
                    return _model.DeleteAnimal(id);

                case Constante.ObiectDeIngrijire:
                    return _model.DeleteObiectIngrijire(id);

                case Constante.Hrana:
                    return _model.DeleteHrana(id);

                case Constante.Jucarie:
                    return _model.DeleteJucarii(id);
                default: return false;

            }
        }

        /// <summary>
        /// Lista
        /// </summary>

        public string List(string tip)
        {
            return _model.ListAll(tip);
        }

        /// <summary>
        /// Cumpararea unui produs
        /// </summary>
        public bool Cumpara(string tip, string denumire)
        {
            if (!ProdusExists(tip, denumire))
                return false;

            _model.Cumpara(tip, denumire);

            return true;
        }


    }
}
