using Company.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Infra
{
    public interface IUnitWork
    {
        ICustomer customers { get; set; }
        IEmp emps { get; set; }
        void Complete();
    }
}
