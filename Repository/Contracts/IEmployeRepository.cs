using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IEmployeRepository
    {
        public void AddEmploye(Employe employe);
        public Employe GetOneEmploye(int id);
        public List<Employe> Employes();

    }
}
