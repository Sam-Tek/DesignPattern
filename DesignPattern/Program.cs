using System;
using System.Collections.Generic;
using System.Linq;
using Controllers;
using Business;
using Repository;
using Unity;
using Repository.Contracts;
using Business.Contracts;

namespace Views
{
    class Program
    {
        public static EmployeController EmployeController;
        static void Main(string[] args)
        {
            //Créer le container Unity
            IUnityContainer unitycontainer = new UnityContainer();
            //Lie les implémentations aux interfaces correspondantes
            unitycontainer.RegisterType<EmployeController, EmployeController>();
            unitycontainer.RegisterType<IBusinessService, BusinessService>();
            unitycontainer.RegisterType<IEmployeRepository, EmployeRepository>();

            EmployeController = unitycontainer.Resolve<EmployeController>();

            string choix;
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("1 - Ajouter un employé en rentrant ses informations");
                Console.WriteLine("2 - Afficher la liste des employés");
                Console.WriteLine("3 - Afficher un employé en rentrant son Id");
                Console.WriteLine("q - Quitter");

                choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        AddEmploye();
                        break;
                    case "2":
                        GetAllEmployes();
                        break;
                    case "3":
                        GetOneEmploye();
                        break;
                    case "q":
                        Console.WriteLine("A+");
                        break;
                    default:
                        Console.WriteLine("Erreur");
                        break;
                }
            } while (choix != "q");
        }

        static void AddEmploye()
        {
            int id;
            string nom, prenom;
            double salaire;

            do
            {
                Console.WriteLine("Entrez id");
            } while (int.TryParse(Console.ReadLine(), out id) == false);

            Console.WriteLine("Entrez nom");
            nom = Console.ReadLine();

            Console.WriteLine("Entrez prenom");
            prenom = Console.ReadLine();

            do
            {
                Console.WriteLine("Entrez salaire");
            } while (double.TryParse(Console.ReadLine(), out salaire) == false);

            try
            {
                EmployeController.AddOneEmploye(id, nom, prenom, salaire);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void GetAllEmployes()
        {
            Console.WriteLine(string.Join("\n",EmployeController.GetAllEmploye()));
        }

        static void GetOneEmploye()
        {
            int id;

            Console.WriteLine(string.Join("\n", EmployeController.GetAllEmploye()));

            Console.WriteLine("Entrez id");
            do { } while (int.TryParse(Console.ReadLine(), out id) == false);

            Console.WriteLine(EmployeController.GetOneEmploye(id));

        }
    }
}
