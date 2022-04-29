using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public interface IPresenter
    {
        void AddProdus(Produs p);
        bool ProdusExists(string denumire);     
        void Exit();
        Produs GetCity(string denumire);
        void Init();
        void RemoveProdus(int id);
    }
}
