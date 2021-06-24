using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository.Contracts;

namespace Repository
{
    public class EmployeRepository : IEmployeRepository
    {
        public void AddEmploye(Employe employe)
        {
            LocalStorage.Instance.Employes.Add(employe);
        }

        public Employe GetOneEmploye(int id)
        {
            return LocalStorage.Instance.Employes.FirstOrDefault(e => e.Id == id);
        }

        public List<Employe> Employes()
        {
            return LocalStorage.Instance.Employes;
        }
    }
}
