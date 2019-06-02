//Брижак Андрей ДЗ к занятию 2 по курсу Паттерны 
//1. Применить принцип открытости / закрытости.
//Класс OrderRepository изначально был реализован для работы с заказами, хранящимися в
//MySQL.Но однажды нам потребовалось реализовать работу с данными о заказах, например,
//через API стороннего веб-сервиса.Какие изменения нам надо будет внести?

namespace GB_Arch_Patterns_HW02_Brizhak
{
    class Program
    {
        static void Main(string[] args)
        {
            
            OrderRepository orderRepository = new OrderRepository(new ApiOrderConnect());
        }
    }
}
