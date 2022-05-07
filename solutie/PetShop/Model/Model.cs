using Commons;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Model
{
    public class Model : IModel
    {
        private List<Animal> _animale = new List<Animal>();
        private List<ObiectIngrijire> _obiecteIngrijire = new List<ObiectIngrijire>();
        private List<Jucarie> _jucarii = new List<Jucarie>();
        private List<Hrana> _hrana = new List<Hrana>();

        public void AddAnimal(Animal produs)
        {
            _animale.Add(produs);
            ScriereInFisierAnimale();
        }

        public void AddObiecteIngrijire(ObiectIngrijire produs)
        {
            _obiecteIngrijire.Add(produs);
            ScriereInFisierObiecteIngrijire();

        }

        public void AddJucarii(Jucarie produs)
        {
            _jucarii.Add(produs);
            ScriereInFisierJucarii();

        }

        public void AddHrana(Hrana produs)
        {
            _hrana.Add(produs);
            ScriereInFisierHrana();
        }

      
        public void InitializeData()
        {
            throw new NotImplementedException();
        }

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

      
        public bool DeleteAnimal(int id)
        {
            var animal = _animale.FirstOrDefault(x => x.Id == id);

            if (animal == null)
                return false;

            _animale.Remove(animal);

            ScriereInFisierAnimale();

            return true;
        }

        public bool DeleteObiectIngrijire(int id)
        {
            var obiect = _obiecteIngrijire.FirstOrDefault(x => x.Id == id);

            if (obiect == null)
                return false;

            _obiecteIngrijire.Remove(obiect);

            ScriereInFisierObiecteIngrijire();

            return true;
        }

        public bool DeleteJucarii(int id)
        {
            var jucarie = _jucarii.FirstOrDefault(x => x.Id == id);

            if (jucarie == null)
                return false;

            _jucarii.Remove(jucarie);

            ScriereInFisierJucarii();

            return true;
        }

        public bool DeleteHrana(int id)
        {
            var hrana = _hrana.FirstOrDefault(x => x.Id == id);

            if (hrana == null)
                return false;

            _hrana.Remove(hrana);

            ScriereInFisierHrana();

            return true;
        }

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

        #region [private methods]
        private void ScriereInFisierAnimale()
        {
            var stream = new StreamWriter("animale.txt");
            foreach (var item in _animale)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Varsta}");

            }
            stream.Close();
        }
        private void ScriereInFisierObiecteIngrijire()
        {
            var stream = new StreamWriter("obiecteIngrijire.txt");
            foreach (var item in _obiecteIngrijire)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Denumire}");

            }
            stream.Close();

        }
        private void ScriereInFisierJucarii()
        {
            var stream = new StreamWriter("jucarii.txt");
            foreach (var item in _jucarii)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Denumire}");

            }
            stream.Close();
        }

        private void ScriereInFisierHrana()
        {
            var stream = new StreamWriter("hrana.txt");
            foreach (var item in _hrana)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Denumire}");

            }
            stream.Close();
        }

        private string ConvertListOfAnimalsToString()
        {
            var result = "";
            foreach (var item in _animale)
            {
                result += $"{item.Id},{item.Pret},{item.Categorie},{item.Varsta}\n";
            }
            return result;
        }

        private string ConvertListOfObiecteToString()
        {
            var result = "";
            foreach (var item in _obiecteIngrijire)
            {
                result += $"{ item.Id},{ item.Pret},{ item.Categorie},{ item.Denumire}\n";
            }
            return result;
        }
        private string ConvertListOfHranaToString()
        {
            var result = "";
            foreach (var item in _hrana)
            {
                result += $"{item.Id},{item.Pret},{item.Categorie},{item.Denumire}\n";
            }
            return result;
        }

        private string ConvertListOfJucariiToString()
        {
            var result = "";
            foreach (var item in _hrana)
            {
                result += $"{item.Id},{item.Pret},{item.Denumire}\n";
            }
            return result;
        }

       

        #endregion
    }
}
