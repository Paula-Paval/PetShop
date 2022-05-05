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
        private List<Animal> _produse = new List<Animal>();

        public void AddAnimal(Animal produs)
        {
            _produse.Add(produs);
            var stream = new StreamWriter("animale.txt");
            foreach (var item in _produse)
            {
                stream.WriteLine($"{item.Id},{item.Pret},{item.Categorie},{item.Varsta}");

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
