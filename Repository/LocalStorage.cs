using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository.Contracts;

namespace Repository
{
    public sealed class LocalStorage
    {
        private static LocalStorage _instance = null;
        private List<Employe> _employes;

        private LocalStorage()
        {
            Employes = new List<Employe>();
        }

        public List<Employe> Employes
        {
            get { return _employes; }
            set { _employes = value; }
        }

        public static LocalStorage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LocalStorage();
                return _instance;
            }
        }
    }
}
