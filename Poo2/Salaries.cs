using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo3
{
    public class Salaries : List<Salarie>
    {
        /// <summary>
        /// Ajout d'un salarié sans doublon
        /// </summary>
        /// <param name="salarie"></param>
        public new void Add(Salarie salarie)
        {
            bool trouve = false;
            foreach (Salarie item in this)
            {
                if (item.Equals(salarie))
                {
                    trouve = true;
                    break;
                }
            }
            if (!trouve)
            {
                base.Add(salarie);
            }
        }
        /// <summary>
        /// Autre forme d'ajout sans doublon
        /// </summary>
        /// <param name="salarie"></param>
        public void AddV2(Salarie salarie)
        {
            if (!this.Contains(salarie))
            {
                base.Add(salarie);
            }
        }
        public Salarie Extraire(string matricule)
        {
            foreach (Salarie item in this)
            {
                if (item.Matricule ==matricule)
                {
                    return item;
                   
                }
            }
            return null;
        }
        
        /// <summary>
        /// Suppression d'un salarié en fonction du matricule
        /// </summary>
        /// <param name="matricule"></param>
        public bool Remove(string matricule)
        {
            Salarie salTrouve = Extraire(matricule);
            if (salTrouve != null)
            {
                base.Remove(salTrouve);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        
    }
}
