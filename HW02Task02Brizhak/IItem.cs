﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
