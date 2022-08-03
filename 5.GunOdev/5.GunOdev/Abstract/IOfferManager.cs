using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev.Abstract
{
    public interface IOfferManager
    {
        void Add(Offer offer);
        void Delete(Offer offer);
        void Update(Offer offer,int discount);
    }
}
