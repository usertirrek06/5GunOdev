using _5.GunOdev.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GunOdev.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string NationalatyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
