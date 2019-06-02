namespace GB_Arch_Patterns_HW02_Brizhak
{
    /// <summary>
    /// class for connected with API database
    /// </summary>
    class ApiOrderConnect : IOrderConnect
    {
        public Order Load(int orderId)
        {
            return null;
        }
        public  void Save(Order order) { }
        public  void Update(Order order) {  }
        public  void Delete(Order order) {  }
    }
}
