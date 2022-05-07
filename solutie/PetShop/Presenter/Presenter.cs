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

        public void Init()
        {
            throw new NotImplementedException();
        }

        public bool ProdusExists(string tip, string denumire)
        {
           return  _model.Exists(tip, denumire);
        }

        public bool RemoveProdus(int id, string tip)
        {
           switch(tip)
            {
                case Constante.Animal:
                   return _model.DeleteAnimal(id);
                    
                case Constante.ObiectDeIngrijire:
                    return _model.DeleteObiectIngrijire(id);
                   
                case Constante.Hrana:
                    return _model.DeleteHrana(id);
                   
                case Constante.Jucarie:
                    return _model.DeleteJucarii(id);
                default:return false;
                    
            }
        }

        public string List(string  tip)
        {
            return _model.ListAll(tip);
        }

        public bool Cumpara(string tip, string denumire)
        {
            if (!ProdusExists(tip, denumire))
                return false;

            _model.Cumpara(tip, denumire);

            return true;
        }

     
    }
}
