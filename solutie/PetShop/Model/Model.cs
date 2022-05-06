using Commons;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var stream = new StreamWriter("animale.txt");
            foreach (var item in _animale)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Varsta}");

            }
            stream.Close();

        }

        public void AddObiecteIngrijire(ObiectIngrijire produs)
        {
            _obiecteIngrijire.Add(produs);
            var stream = new StreamWriter("obiecteIngrijire.txt");
            foreach (var item in _obiecteIngrijire)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Denumire}");

            }
            stream.Close();

        }

        public void AddJucarii(Jucarie produs)
        {
            _jucarii.Add(produs);
            var stream = new StreamWriter("jucarii.txt");
            foreach (var item in _jucarii)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Denumire}");

            }
            stream.Close();

        }

        public void AddHrana(Hrana produs)
        {
            _hrana.Add(produs);
            var stream = new StreamWriter("hrana.txt");
            foreach (var item in _hrana)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Denumire}");

            }
            stream.Close();

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

    }
}
