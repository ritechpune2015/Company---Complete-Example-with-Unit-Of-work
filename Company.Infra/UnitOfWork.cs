using Company.Infra.Interfaces;
using Company.Infra.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infra
{
    public class UnitOfWork : IUnitWork
    {
        private CompanyContext cc;
        public UnitOfWork()
        {
            cc = new CompanyContext();
        }
        private CustomerRepo custrepoobj;
        private EmpRepo emprepoobj;
        public ICustomer customers {

            get
            {
                if (custrepoobj == null)
                    custrepoobj = new CustomerRepo(cc);
                return custrepoobj;
            }
            set { 
            }
        }
        public IEmp emps {
            get {
                if (emprepoobj == null)
                    emprepoobj = new EmpRepo(cc);
                return emprepoobj;
            }
            set { }
        }

        public void Complete()
        {
            cc.SaveChanges();
        }
     
    }
}
