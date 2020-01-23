using System;
using System.Collections.Generic;
using System.Text;

namespace accessmodifiers
{
    class Goldcustomer : Customer
    {
            public void OfferVoucher()
        {
           var rating = this.CalculateRating(true);
        }
    }
}
