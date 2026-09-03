using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Asssginment3
{
    internal sealed class CompletedShipment : Shipment
    {

        public CompletedShipment(string Tcode, string description, decimal w, decimal Dfee, string _city, string _street, int _bNum) : base(Tcode, description, w, Dfee, _city, _street, _bNum)
        {

        }


    }
}
