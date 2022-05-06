using Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class Presenter : IPresenter
    {
        private IModel _model;

        public Presenter()
        {
            _model = new Model.Model();
        }
        public void AddAnimal(Animal p)
        {
            _model.AddAnimal(p);
        }

        public void AddObiecteIngrijire(ObiectIngrijire p)
        {
            _model.AddObiecteIngrijire(p);
        }

        public void AddJucarii(Jucarie p)
        {
            _model.AddJucarii(p);
        }

        public void AddHrana(Hrana p)
        {
            _model.AddHrana(p);
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public Produs GetProdus(string denumire)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public bool ProdusExists(string denumire)
        {
            throw new NotImplementedException();
        }

        public void RemoveProdus(int id)
        {
            throw new NotImplementedException();
        }
    }
}
