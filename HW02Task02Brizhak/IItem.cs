namespace HW02Task02Brizhak
{
    interface IItem
    {
        void SetDiscount(double discount);
        void SetPromocode(string promocode);
        void SetPrice(double price);
        void SetState(State state);
    }
}
