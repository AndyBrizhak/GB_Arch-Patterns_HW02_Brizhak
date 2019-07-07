using System;

namespace GB_Arch_Patterns_HW02_Brizhak
{
    /// <summary>
    /// class for connected with MySQL database
    /// </summary>
    class MySQLOrderConnect : IOrderConnect
    {
        public MySQLOrderConnect()
        {
        }

        public void Delete(Order order)
        {
            // throw new NotImplementedException();
        }

        public Order Load(int orderId)
        {
          //  throw new NotImplementedException();
            return null;
        }

        public void Save(Order order)
        {
          //  throw new NotImplementedException();
        }

        public void Update(Order order)
        {
           // throw new NotImplementedException();
        }
    }
}
