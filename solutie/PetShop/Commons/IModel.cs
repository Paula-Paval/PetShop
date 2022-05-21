/**************************************************************************
 *                                                                        *
 *  File:        IModel.cs                                             *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description:   Interfata ce contine operatiile pe care le poate       *
 *               realiza  modelul, reprezinta contractul punctului din    *
 *               aplicatie cel mai aproape de nivelul de persistenta al datelor *
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
        /// <summary>
        /// Adaugare animal
        /// </summary>
        /// <param name="produs">Obiect de tip Animal</param>
        void AddAnimal(Animal produs);

        /// <summary>
        /// Adaugare obiecte de ingrijire
        /// </summary>
        /// <param name="produs">Obiect de tip ObiectIngrijire</param>
        void AddObiecteIngrijire(ObiectIngrijire produs);

        /// <summary>
        /// Adaugare jucarii
        /// </summary>
        /// /// <param name="produs">Obiect de tip Jucarie</param>

        void AddJucarii(Jucarie produs);

        /// <summary>
        /// Adaugare hrana
        /// </summary>
        /// <param name="produs">Obiect de tip Hrana</param>

        void AddHrana(Hrana produs);

        /// <summary>
        /// Stergerea unui animal
        /// </summary>
        /// /// <param name="id">ID-ul animalului</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>

        bool DeleteAnimal(int id);

        /// <summary>
        /// Stergerea unui obiect de ingrijire
        /// </summary>
        /// /// <param name="id">ID-ul obiectului de ingrijire</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>

        bool DeleteObiectIngrijire(int id);
        /// <summary>
        /// Stergerea unei jucarii
        /// </summary>
        /// /// <param name="id">ID-ul jucariei</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>

        bool DeleteJucarii(int id);

        /// <summary>
        /// Stergerea hranei
        /// </summary>
        /// <param name="id">ID-ul hranei</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>

        bool DeleteHrana(int id);

        /// <summary>
        /// Lista
        /// </summary>
        /// <param name="tip">Tipul listei</param>
        /// <returns>Retuneaza conversia listei la tipul de date string</returns>

        string ListAll(string tip);

        /// <summary>
        /// Cumpararea unui produs
        /// </summary>
        /// <param name="tip">Tipul unui produs cumparat</param>
        /// <param name="denumire">Denumirea unui produs cumparat</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>

        void Cumpara(string tip, string denumire);
        /// <summary>
        /// Existenta unui animal/ unui obiect de ingrijire/ hranei/ unei jucarii
        /// </summary>
        /// <param name="tip">Tipul unui produs existent</param>
        /// <param name="denumire">Denumirea unui produs existent</param>
        /// <returns>Returneaza daca exista</returns>


        bool Exists(string tip, string denumire);

        /// <summary>
        /// Initializare date
        /// </summary>
        void InitializeData();

        /// <summary>
        /// GetAnimals
        /// </summary>
        /// <returns>Returneaza obiectele de tip animale</returns>

        List<Animal> GetAnimals();

        /// <summary>
        /// GetJucarii
        /// </summary>
        /// <returns>Returneaza obiectele de tip jucarii</returns>

        List<Jucarie> GetJucarii();
        /// <summary>
        /// GetObiecteIngrijire
        /// </summary>
        /// <returns>Returneaza obiectele de tip Obiecte de Ingrijire</returns>

        List<ObiectIngrijire> GetObiecteIngrijire();

        /// <summary>
        /// GetHrana
        /// </summary>
        /// <returns>Returneaza obiectele de tip Hrana</returns>
        List<Hrana> GetHrana();


        /// <summary>
        /// SetAnimals
        /// </summary>
        /// <param name="animals" >Parametru de tip List<Animal> </param>

        void SetAnimals(List<Animal> animals);
        /// <summary>
        /// SetAnimals
        /// </summary>
        /// <param name="jucarii" >Parametru de tip List<Jucarie> </param>

        void SetJucarii(List<Jucarie> jucarii);
        /// <summary>
        /// SetAnimals
        /// </summary>
        /// <param name="obiectIngrijire" >Parametru de tip List<ObiectIngrijire>> </param>

        void SetObiecteIngrijire(List<ObiectIngrijire> obiectIngrijire);

        /// <summary>
        /// SetAnimals
        /// </summary>
        /// <param name="hrana" >Parametru de tip List<Hrana>> </param>

        void SetHrana(List<Hrana> hrana);

    }
}
