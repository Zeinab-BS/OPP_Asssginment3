using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Asssginment3
{
    internal class InternationalShipment:Shipment
    {
        private string destinationCountry;
        private decimal customsFee;


        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("DestinationCountry Can Not Be Null Or Empty Or WhiteSpace");
                }

                destinationCountry = value;





            }
        }



        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException("CustomsFee Must Be Greater Than or Equal to 0 ");
                }
                customsFee = value;


            }
        }



        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }

        public InternationalShipment(string tc, string descrip, decimal wg, decimal df, string _city, string _street, int bulidingNo, string desct, decimal cfee) : base(tc, descrip, wg, df, _city, _street, bulidingNo)
        {
            DestinationCountry = desct;
            CustomsFee = cfee;
        }

        public virtual void GenerateCustomeReport()
        {
            Console.WriteLine($"Standard Customs Report for {TrackingCode} bound to {DestinationCountry}. Fee: {CustomsFee}");
        }

        public override void PrintShipment()

        {
            Console.WriteLine("===InternationalShipment===");
            base.PrintShipment();
            Console.WriteLine($"DestinationCountry:{DestinationCountry}");
            Console.WriteLine($"CustomsFee:{CustomsFee}");
        }

    }
}
