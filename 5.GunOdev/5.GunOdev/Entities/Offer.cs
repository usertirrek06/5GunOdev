using _5.GunOdev.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev
{
    public class Offer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
    }
}
