using _5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckRealPerson(Gamer gamer);
    }
}
