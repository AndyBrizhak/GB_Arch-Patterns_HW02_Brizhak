using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW02_Brizhak
{
    class ApiOrder : OrderRepository
    {
        public new Order Load(int orderId)
        {
            return null;

        }
        public new void Save(Order order) { }
        public new void Update(Order order) {  }
        public new void Delete(Order order) {  }
    }
}
