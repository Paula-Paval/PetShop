using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public interface IPresenter
    {
        void AddAnimal(Animal p);
        void AddObiecteIngrijire(ObiectIngrijire p);
        void AddJucarii(Jucarie p);
        void AddHrana(Hrana p);
        bool RemoveProdus(int id, string tip);
        bool Cumpara(string tip, string denumire);
        string List(string tip);
        void Init();  
    }
}
