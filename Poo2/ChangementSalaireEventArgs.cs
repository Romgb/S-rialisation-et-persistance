using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo3
{
    public class ChangementSalaireEventArgs : EventArgs
    {
        //Champs
        private decimal _ancienSalaire;
        private decimal _nouveauSalaire;


        public ChangementSalaireEventArgs(decimal ancienSalaire, decimal nouveauSalaire)
        {
            _ancienSalaire = ancienSalaire;
            _nouveauSalaire = nouveauSalaire;
        }

        public decimal AncienSalaire 
        { 
          get => _ancienSalaire; 
          set => _ancienSalaire = value; 
        }
        public decimal NouveauSalaire 
        { 
          get => _nouveauSalaire; 
          set => _nouveauSalaire = value; 
        }
    }
}
