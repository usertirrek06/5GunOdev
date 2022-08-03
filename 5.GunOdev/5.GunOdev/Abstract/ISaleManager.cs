using System;
using System.Collections.Generic;
using System.Text;
using _5.GunOdev.Entities;

namespace _5.GunOdev.Abstract
{
    interface ISaleManager
    {
        void Sale(Game game, Offer offer);
        void Sale(Game game);
    }
}
