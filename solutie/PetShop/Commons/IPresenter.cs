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
        bool ProdusExists(string denumire);     
        void Exit();
        Produs GetProdus(string denumire);
        void Init();
        void RemoveProdus(int id);
    }
}
