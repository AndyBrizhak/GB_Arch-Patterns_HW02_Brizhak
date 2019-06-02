using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW02_Brizhak
{
    interface IOrderConnect
    {
        Order Load(int orderId);
        void Save(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
