using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Asssginment3
{
    internal class StandardShipment:Shipment
    {
        public StandardShipment(string tc, string descrip, decimal wg, decimal df, string _city, string _street, int _bNum) : base(tc, descrip, wg, df, _city, _street, _bNum)
        {

        }
        public override void PrintShipment()

        {
            Console.WriteLine("===StandardShipment===");
            base.PrintShipment();
        }

    }
}
