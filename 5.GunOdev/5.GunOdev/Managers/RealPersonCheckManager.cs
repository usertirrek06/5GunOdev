using _5.GunOdev.Abstract;
using _5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev.Managers
{
    class RealPersonCheckManager : IPersonCheckService
    {
        public bool CheckRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
