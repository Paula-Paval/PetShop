/**************************************************************************
 *                                                                        *
 *  File:        IModel.cs                                             *
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
    /// Interfata IModel
    /// </summary>
    public interface IModel
    {
        void AddAnimal(Animal produs);
        void AddObiecteIngrijire(ObiectIngrijire produs);
        void AddJucarii(Jucarie produs);
        void AddHrana(Hrana produs);

        bool DeleteAnimal(int id);
        bool DeleteObiectIngrijire(int id);
        bool DeleteJucarii(int id);
        bool DeleteHrana(int id);

        string ListAll(string tip);
        void Cumpara(string tip, string denumire);

        bool Exists(string tip, string denumire);
        void InitializeData();

        List<Animal> GetAnimals();
        List<Jucarie> GetJucarii();
        List<ObiectIngrijire> GetObiecteIngrijire();
        List<Hrana> GetHrana();

        void SetAnimals(List<Animal> animals);
        void SetJucarii(List<Jucarie> jucarii);
        void SetObiecteIngrijire(List<ObiectIngrijire> obiectIngrijire);
        void SetHrana(List<Hrana> hrana);

    }
}
