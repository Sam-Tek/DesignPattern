using System;
using Repository.Contracts;
using Entities;
using System.Collections.Generic;
using Business.Contracts;

namespace Business
{
    public class BusinessService : IBusinessService
    {
        public IEmployeRepository EmployeRepository { get; }

        public BusinessService(IEmployeRepository employeRepository)
        {
            EmployeRepository = employeRepository;
        }

        public void checkSalaire(Employe employe)
        {
            if (employe.Salaire <= 0)
                throw new Exception("Le salaire doit être toujours supérieur à 0");
        }

        public void AddEmploye(Employe employe)
        {
            checkSalaire(employe);
            EmployeRepository.AddEmploye(employe);
        }

        public List<Employe> GetEmployes()
        {
            return EmployeRepository.Employes();
        }

        public Employe GetEmploye(int id)
        {
            return EmployeRepository.GetOneEmploye(id);
        }
    }
}
