using Company.Infra;
using Company.Infra.Interfaces;
using Company.Infra.Repo;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Company.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            // container.RegisterType<ICustomer, CustomerRepo>();
            // container.RegisterType<IEmp, EmpRepo>();
            container.RegisterType<IUnitWork, UnitOfWork>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}