using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employe
    {
        private double _salaire;

        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public double Salaire
        {
            get { return _salaire; }
            set 
            { 
                if (value > 0)
                    _salaire = value;
            }
        }

        public override string ToString()
        {
            return $"Id {Id} Nom {Nom} Prenom {Prenom} Salaire {Salaire}";
        }
    }
}
