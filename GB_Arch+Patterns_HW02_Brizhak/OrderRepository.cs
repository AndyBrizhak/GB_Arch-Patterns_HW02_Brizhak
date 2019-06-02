namespace GB_Arch_Patterns_HW02_Brizhak
{
    class OrderRepository
    {
        private IOrderConnect connect;

        public OrderRepository(IOrderConnect connect) => this.connect = connect;

        public Order Load(int orderId)
        {
            return connect.Load(orderId);
        }

        public void Save(Order order)
        {  }

        public void Update(Order order)
        { }

        public void Delete(Order order)
        { }
    }
}
