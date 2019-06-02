using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW02_Brizhak
{
     class MySQLOrderConnect : IOrderConnect
    {
        public MySQLOrderConnect()
        {
        }

        public void Delete(Order order)
        {
            throw new NotImplementedException();
        }

        public Order Load(int orderId)
        {
            throw new NotImplementedException();
        }

        public void Save(Order order)
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
