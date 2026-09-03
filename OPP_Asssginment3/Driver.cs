using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Asssginment3
{
    internal class Driver
    {
        public int DeriverId { get; set; }
        public string FullName { get; set; }
        public int PhoneNumber { get; set; }

        public Driver(int id, string name, int phone)
        {
            DeriverId = id;
            FullName = name;
            PhoneNumber = phone;
        }

    }
}
