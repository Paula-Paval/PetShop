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

        public bool DataExits()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public void InitializeData()
        {
            throw new NotImplementedException();
        }

        public string ListAll(string tip)
        {
            throw new NotImplementedException();
        }

        public bool SaveData()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAnimal(int id)
        {
            var animal = _animale.FirstOrDefault(x=>x.Id==id);

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
        #endregion
    }
}
