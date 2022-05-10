using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public interface IModel
    {
        




        void AddAnimal(Animal produs);
        void AddObiecteIngrijire(ObiectIngrijire produs);
        void AddJucarii(Jucarie produs);
        void AddHrana(Hrana produs);

        bool  DeleteAnimal(int id);
        bool DeleteObiectIngrijire(int id);
        bool DeleteJucarii(int id);
        bool DeleteHrana(int id);

        string ListAll(string tip);
        void  Cumpara(string tip, string denumire);
     
        bool Exists(string  tip, string denumire);
        void InitializeData();     
       
      
    }
}
