using Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTests
{
    class MockStorage : IEmployeRepository
    {
        public void AddEmploye(Employe employe)
        {
            throw new NotImplementedException();
        }

        public List<Employe> Employes()
        {
            return new List<Employe> 
            { 
                new Employe(){ Id = 1, Nom = "Samy", Prenom =  "Ruben"},
                new Employe(){ Id = 1, Nom = "Louis", Prenom =  "Louis"},
            };
        }

        public Employe GetOneEmploye(int id)
        {
            throw new NotImplementedException();
        }
    }
}
