using _5.GunOdev.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev.Managers
{
    class OfferManager : IOfferManager
    {
        public List<Offer> offers = new List<Offer>();
        public void Add(Offer offer)
        {
            offers.Add(offer);
            Console.WriteLine(offer.Name+" Added.");
        }

        public void Delete(Offer offer)
        {
            offers.Remove(offer);
            Console.WriteLine(offer.Name + " Deleted.");
        }

        public void Update(Offer offer,int discount)
        {
            offer.Discount = discount;
            Console.WriteLine(offer.Name+"'s discount updated. Discount: "+discount);
        }
    }
}
