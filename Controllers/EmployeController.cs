using System.Collections.Generic;
using Entities;
using Business.Contracts;

namespace Controllers
{
    public class EmployeController
    {
        public IBusinessService BusinessService { get; }

        public EmployeController(IBusinessService businessService)
        {
            BusinessService = businessService;
        }

        public void AddOneEmploye(int id, string nom, string prenom, double salaire)
        {
            Employe employe = new Employe
            {
                Id = id,
                Nom = nom,
                Prenom = prenom,
                Salaire = salaire
            };

            BusinessService.AddEmploye(employe);
        }

        public List<Employe> GetAllEmploye()
        {
            return BusinessService.GetEmployes();
        }

        public Employe GetOneEmploye(int id)
        {
            return BusinessService.GetEmploye(id);
        }
    }
}
