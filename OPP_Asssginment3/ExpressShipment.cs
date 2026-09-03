using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Asssginment3
{
    internal class ExpressShipment:Shipment
    {
        private decimal extrafee;

        public decimal ExtraFee
        {
            get { return extrafee; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("ExtraFee must be greater than or equal 0");
                }
                extrafee = value;

            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }
        public ExpressShipment(string tc, string descrip, decimal wg, decimal df, string _city, string _street, int bulidingNo, decimal ex) : base(tc, descrip, wg, df, _city, _street, bulidingNo)
        {
            ExtraFee = ex;

        }

        public override void PrintShipment()

        {
            Console.WriteLine("===ExpressShipment===");
            base.PrintShipment();
            Console.WriteLine($"ExtraFee:{ExtraFee}");
        }

    }
}
