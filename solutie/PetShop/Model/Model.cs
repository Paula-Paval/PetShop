/**************************************************************************
 *                                                                        *
 *  File:        Model.cs                                             *
 *  Copyright:   (c) 2022, PetShop                                        *
 *  E-mail:      paula.paval@student.tuiasi.ro                            *
 *  Description: Punctului din  aplicatie cel mai aproape de nivelul      *
 *               de persistenta al datelor (datele sunt salvate in fisiere)*
 *                                                                        *
 *                                                                        *
 **************************************************************************/

using Commons;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Commons.infrastucture;
namespace Model
{
    /// <summary>
    /// Clasa model
    /// </summary>
    public class Model : IModel
    {
        private List<Animal> _animale = new List<Animal>();
        private List<ObiectIngrijire> _obiecteIngrijire = new List<ObiectIngrijire>();
        private List<Jucarie> _jucarii = new List<Jucarie>();
        private List<Hrana> _hrana = new List<Hrana>();

        /// <summary>
        /// Adaugare animal
        /// </summary>
        /// <param name="produs">Obiect de tip Animal</param>
        public void AddAnimal(Animal produs)
        {
            if (!File.Exists(Constante.FisierAnimale)) throw new FisierNotFoundException($"Fisierul {Constante.FisierAnimale}");
            if (produs.Id < 0) throw new IdNegativExcetion("Nu se poate realiza adaugarea unui produs cu id negativ");
            if (produs.Varsta < 0 || produs.Varsta > 60) throw new VarstaException("Nu se poate realiza adaugarea unui animal cu varsta negativa sau mai mare ca 50");
            if (produs.Pret < 0) throw new PretNegativException("Nu se poate adauga un produs cu pret negativ");

            _animale.Add(produs);

            ScriereInFisierAnimale();
        }

        /// <summary>
        /// Adaugare obiecte de ingrijire
        /// </summary>
        /// <param name="produs">Obiect de tip ObiectIngrijire</param>
        public void AddObiecteIngrijire(ObiectIngrijire produs)
        {
            if (!File.Exists(Constante.FisierObiecteDeIngrijire)) throw new FisierNotFoundException($"Fisierul {Constante.FisierObiecteDeIngrijire}");
            if (produs.Id < 0) throw new IdNegativExcetion("Nu se poate realiza adaugarea unui produs cu id negativ");
            if (produs.Pret < 0) throw new PretNegativException("Nu se poate adauga un produs cu pret negativ");
            _obiecteIngrijire.Add(produs);

            ScriereInFisierObiecteIngrijire();
        }

        /// <summary>
        /// Adaugare jucarii
        /// </summary>
        /// /// <param name="produs">Obiect de tip Jucarie</param>
        public void AddJucarii(Jucarie produs)
        {
            if (!File.Exists(Constante.FisierJucarii)) throw new FisierNotFoundException($"Fisierul {Constante.FisierJucarii}");
            if (produs.Id < 0) throw new IdNegativExcetion("Nu se poate realiza adaugarea unui produs cu id negativ");
            if (produs.Pret < 0) throw new PretNegativException("Nu se poate adauga un produs cu pret negativ");
            _jucarii.Add(produs);

            ScriereInFisierJucarii();

        }

        /// <summary>
        /// Adaugare hrana
        /// </summary>
        /// <param name="produs">Obiect de tip Hrana</param>

        public void AddHrana(Hrana produs)
        {
            if (!File.Exists(Constante.FisierHrana)) throw new FisierNotFoundException($"Fisierul {Constante.FisierHrana}");
            if (produs.Id < 0) throw new IdNegativExcetion("Nu se poate realiza adaugarea unui produs cu id negativ");
            if (produs.Pret < 0) throw new PretNegativException("Nu se poate adauga un produs cu pret negativ");
            _hrana.Add(produs);

            ScriereInFisierHrana();
        }

        /// <summary>
        /// Initializare date
        /// </summary>

        public void InitializeData()
        {
            if (!File.Exists(Constante.FisierAnimale)) throw new FisierNotFoundException($"Fisierul {Constante.FisierAnimale}");
            if (!File.Exists(Constante.FisierHrana)) throw new FisierNotFoundException($"Fisierul {Constante.FisierHrana}");
            if (!File.Exists(Constante.FisierJucarii)) throw new FisierNotFoundException($"Fisierul {Constante.FisierJucarii}");
            if (!File.Exists(Constante.FisierObiecteDeIngrijire)) throw new FisierNotFoundException($"Fisierul {Constante.FisierObiecteDeIngrijire}");

            _animale = CitireDinFisierAnimale();
            _obiecteIngrijire = CitireDinFisierObiectDeIngrijire();
            _hrana = CitireDinFisierHrana();
            _jucarii = CitireDinFisierJucarii();

        }

        /// <summary>
        /// Lista
        /// </summary>
        /// <param name="tip">Tipul listei</param>
        /// <returns>Retuneaza conversia listei la tipul de date string</returns>
        public string ListAll(string tip)
        {
            switch (tip)
            {
                case Constante.Animal:
                    return ConvertListOfAnimalsToString();
                case Constante.ObiectDeIngrijire:
                    return ConvertListOfObiecteToString();
                case Constante.Hrana:
                    return ConvertListOfHranaToString();
                case Constante.Jucarie:
                    return ConvertListOfJucariiToString();
                default:
                    return "";
            }
        }

        /// <summary>
        /// Stergerea unui animal
        /// </summary>
        /// /// <param name="id">ID-ul animalului</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        public bool DeleteAnimal(int id)
        {
            if (id < 0) throw new IdNegativExcetion("Nu se poate realiza stergerea unui animal cu id negativ");
            if (!File.Exists(Constante.FisierAnimale)) throw new FisierNotFoundException($"Fisierul {Constante.FisierAnimale}");

            var animal = _animale.FirstOrDefault(x => x.Id == id);

            if (animal == null)
                return false;

            _animale.Remove(animal);

            ScriereInFisierAnimale();

            return true;
        }

        /// <summary>
        /// Stergerea unui obiect de ingrijire
        /// </summary>
        /// /// <param name="id">ID-ul obiectului de ingrijire</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        public bool DeleteObiectIngrijire(int id)
        {
            if (id < 0) throw new IdNegativExcetion("Nu se poate realiza stergerea unui obiect de ingrijire cu id negativ");
            if (!File.Exists(Constante.FisierObiecteDeIngrijire)) throw new FisierNotFoundException($"Fisierul {Constante.FisierObiecteDeIngrijire}");

            var obiect = _obiecteIngrijire.FirstOrDefault(x => x.Id == id);

            if (obiect == null)
                return false;

            _obiecteIngrijire.Remove(obiect);



            ScriereInFisierObiecteIngrijire();

            return true;
        }

        /// <summary>
        /// Stergerea unei jucarii
        /// </summary>
        /// /// <param name="id">ID-ul jucariei</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        public bool DeleteJucarii(int id)
        {
            if (id < 0) throw new IdNegativExcetion("Nu se poate realiza stergerea unei jucarii cu id negativ");
            if (!File.Exists(Constante.FisierJucarii)) throw new FisierNotFoundException($"Fisierul {Constante.FisierJucarii}");

            var jucarie = _jucarii.FirstOrDefault(x => x.Id == id);

            if (jucarie == null)
                return false;

            _jucarii.Remove(jucarie);


            ScriereInFisierJucarii();

            return true;
        }

        /// <summary>
        /// Stergerea hranei
        /// </summary>
        /// <param name="id">ID-ul hranei</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        public bool DeleteHrana(int id)
        {
            if (id < 0) throw new IdNegativExcetion("Nu se poate realiza stergerea hranei cu id negativ");
            if (!File.Exists(Constante.FisierHrana)) throw new FisierNotFoundException($"Fisierul {Constante.FisierHrana}");

            var hrana = _hrana.FirstOrDefault(x => x.Id == id);

            if (hrana == null)
                return false;

            _hrana.Remove(hrana);


            ScriereInFisierHrana();

            return true;
        }

        /// <summary>
        /// Cumpararea unui produs
        /// </summary>
        /// <param name="tip">Tipul unui produs cumparat</param>
        /// <param name="denumire">Denumirea unui produs cumparat</param>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        public void Cumpara(string tip, string denumire)
        {
            switch (tip)
            {
                case Constante.Animal:
                    var idAnimal = _animale.FirstOrDefault(x => x.Categorie == denumire).Id;
                    DeleteAnimal(idAnimal);
                    break;
                case Constante.ObiectDeIngrijire:
                    var idObiect = _obiecteIngrijire.FirstOrDefault(x => x.Denumire == denumire).Id;
                    DeleteObiectIngrijire(idObiect);
                    break;
                case Constante.Hrana:
                    var idHrana = _hrana.FirstOrDefault(x => x.Denumire == denumire).Id;
                    DeleteHrana(idHrana);
                    break;
                case Constante.Jucarie:
                    var idJucarie = _jucarii.FirstOrDefault(x => x.Denumire == denumire).Id;
                    DeleteJucarii(idJucarie);
                    break;
            }




        }
        /// <summary>
        /// Existenta unui animal/ unui obiect de ingrijire/ hranei/ unei jucarii
        /// </summary>
        /// <param name="tip">Tipul unui produs existent</param>
        /// <param name="denumire">Denumirea unui produs existent</param>
        /// <returns>Returneaza daca exista</returns>
        public bool Exists(string tip, string denumire)
        {
            switch (tip)
            {
                case Constante.Animal:
                    var animal = _animale.FirstOrDefault(x => x.Categorie == denumire);
                    return animal != null;
                case Constante.ObiectDeIngrijire:
                    var obiect = _obiecteIngrijire.FirstOrDefault(x => x.Denumire == denumire);
                    return obiect != null;
                case Constante.Hrana:
                    var hrana = _hrana.FirstOrDefault(x => x.Denumire == denumire);
                    return hrana != null;
                case Constante.Jucarie:
                    var jucarie = _jucarii.FirstOrDefault(x => x.Denumire == denumire);
                    return jucarie != null;
                default:
                    return false;
            }
        }

        /// <summary>
        /// SetAnimals
        /// </summary>
        /// <param name="animals" >Parametru de tip List<Animal> </param>
        public void SetAnimals(List<Animal> animals)
        {
            _animale = animals;
        }

        /// <summary>
        /// SetAnimals
        /// </summary>
        /// <param name="jucarii" >Parametru de tip List<Jucarie> </param>

        public void SetJucarii(List<Jucarie> jucarii)
        {
            _jucarii = jucarii;
        }

        /// <summary>
        /// SetAnimals
        /// </summary>
        /// <param name="obiectIngrijire" >Parametru de tip List<ObiectIngrijire>> </param>

        public void SetObiecteIngrijire(List<ObiectIngrijire> obiectIngrijire)
        {
            _obiecteIngrijire = obiectIngrijire;
        }

        /// <summary>
        /// SetAnimals
        /// </summary>
        /// <param name="hrana" >Parametru de tip List<Hrana>> </param>

        public void SetHrana(List<Hrana> hrana)
        {
            _hrana = hrana;
        }


        /// <summary>
        /// GetAnimals
        /// </summary>
        /// <returns>Returneaza obiectele de tip animale</returns>
        
        public List<Animal> GetAnimals()
        {
            return _animale;
        }

        /// <summary>
        /// GetJucarii
        /// </summary>
        /// <returns>Returneaza obiectele de tip jucarii</returns>

        public List<Jucarie> GetJucarii()
        {
            return _jucarii;
        }

        /// <summary>
        /// GetObiecteIngrijire
        /// </summary>
        /// <returns>Returneaza obiectele de tip Obiecte de Ingrijire</returns>

        public List<ObiectIngrijire> GetObiecteIngrijire()
        {
            return _obiecteIngrijire;
        }

        /// <summary>
        /// GetHrana
        /// </summary>
        /// <returns>Returneaza obiectele de tip Hrana</returns>

        public List<Hrana> GetHrana()
        {
            return _hrana;
        }

        #region [private methods]
        /// <summary>
        /// Scrierea in fisier (Animale)
        /// </summary>
        private void ScriereInFisierAnimale()
        {
            var stream = new StreamWriter(Constante.FisierAnimale);

            foreach (var item in _animale)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Varsta}");

            }
            stream.Close();
        }
        /// <summary>
        /// Scrierea in fisier (Obiecte de Ingrijire)
        /// </summary>
        private void ScriereInFisierObiecteIngrijire()
        {
            var stream = new StreamWriter(Constante.FisierObiecteDeIngrijire);
            foreach (var item in _obiecteIngrijire)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Denumire}");

            }
            stream.Close();

        }

        /// <summary>
        /// Scrierea in fisier (Jucarii)
        /// </summary>
        private void ScriereInFisierJucarii()
        {
            var stream = new StreamWriter(Constante.FisierJucarii);
            foreach (var item in _jucarii)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Denumire}");

            }
            stream.Close();
        }

        /// <summary>
        /// Scrierea in fisier (Hrana)
        /// </summary>
        private void ScriereInFisierHrana()
        {
            var stream = new StreamWriter(Constante.FisierHrana);
            foreach (var item in _hrana)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Denumire}");

            }
            stream.Close();
        }

        /// <summary>
        /// Conversia listei in string (Animale)
        /// </summary>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        private string ConvertListOfAnimalsToString()
        {
            var result = "";
            foreach (var item in _animale)
            {
                result += $"{item.Id},{item.Pret},{item.Categorie},{item.Varsta}\n";
            }
            return result;
        }

        /// <summary>
        /// Conversia listei in string (Obiecte de ingrijire)
        /// </summary>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        private string ConvertListOfObiecteToString()
        {
            var result = "";
            foreach (var item in _obiecteIngrijire)
            {
                result += $"{ item.Id},{ item.Pret},{ item.Categorie},{ item.Denumire}\n";
            }
            return result;
        }

        /// <summary>
        /// Conversia listei in string (Hrana)
        /// </summary>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        private string ConvertListOfHranaToString()
        {
            var result = "";
            foreach (var item in _hrana)
            {
                result += $"{item.Id},{item.Pret},{item.Categorie},{item.Denumire}\n";
            }
            return result;
        }

        /// <summary>
        /// Conversia listei in string (Jucarii)
        /// </summary>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        private string ConvertListOfJucariiToString()
        {
            var result = "";
            foreach (var item in _hrana)
            {
                result += $"{item.Id},{item.Pret},{item.Denumire}\n";
            }
            return result;
        }

        /// <summary>
        /// Citirea din fisier (Obiecte de ingrijire)
        /// </summary>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        private List<ObiectIngrijire> CitireDinFisierObiectDeIngrijire()
        {
            var result = new List<ObiectIngrijire>();
            IEnumerable<string> lines = File.ReadLines(Constante.FisierObiecteDeIngrijire);

            foreach (var item in lines.ToList())
            {
                var values = item.Split(',');
                var obiect = new ObiectIngrijire()
                {
                    Id = Convert.ToInt32(values[0]),
                    Pret = Convert.ToDouble(values[1]),
                    Categorie = values[2],
                    Denumire = values[3]

                };
                result.Add(obiect);

            }

            return result;
        }


        /// <summary>
        /// Citirea din fisier (Animale)
        /// </summary>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        private List<Animal> CitireDinFisierAnimale()
        {
            var result = new List<Animal>();
            IEnumerable<string> lines = File.ReadLines(Constante.FisierAnimale);

            foreach (var item in lines.ToList())
            {
                var values = item.Split(',');
                var animal = new Animal()
                {
                    Id = Convert.ToInt32(values[0]),
                    Pret = Convert.ToDouble(values[1]),
                    Categorie = values[2],
                    Varsta = Convert.ToInt32(values[3])
                };
                result.Add(animal);

            }

            return result;
        }


        /// <summary>
        /// Citirea din fisier (Hrana)
        /// </summary>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        private List<Hrana> CitireDinFisierHrana()
        {
            var result = new List<Hrana>();
            IEnumerable<string> lines = File.ReadLines(Constante.FisierHrana);

            foreach (var item in lines.ToList())
            {
                var values = item.Split(',');
                var hrana = new Hrana()
                {
                    Id = Convert.ToInt32(values[0]),
                    Pret = Convert.ToDouble(values[1]),
                    Categorie = values[2],
                    Denumire = values[3]
                };
                result.Add(hrana);

            }

            return result;
        }


        /// <summary>
        /// Citirea din fisier (Jucarii)
        /// </summary>
        /// <returns>Returneaza daca s-a realizat cu succes</returns>
        private List<Jucarie> CitireDinFisierJucarii()
        {
            var result = new List<Jucarie>();
            IEnumerable<string> lines = File.ReadLines(Constante.FisierJucarii);

            foreach (var item in lines.ToList())
            {
                var values = item.Split(',');
                var jucarie = new Jucarie()
                {
                    Id = Convert.ToInt32(values[0]),
                    Pret = Convert.ToDouble(values[1]),
                    Denumire = values[2]
                };
                result.Add(jucarie);

            }

            return result;
        }



        #endregion
    }
}
