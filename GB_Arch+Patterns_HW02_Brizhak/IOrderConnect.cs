namespace GB_Arch_Patterns_HW02_Brizhak
{
    /// <summary>
    /// Connect Interface
    /// </summary>
    interface IOrderConnect
    {
        Order Load(int orderId);
        void Save(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
