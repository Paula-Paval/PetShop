﻿using System;
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
        bool DataExits();
        bool Delete(int  id);
        bool Exists(int  id);
        void InitializeData();
        string ListAll(string tip);
        bool SaveData();
      
    }
}
