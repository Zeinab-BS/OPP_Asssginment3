using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Asssginment3
{
    internal class PriorityInternationalShipment: InternationalShipment

    {
        public PriorityInternationalShipment(string tc, string descrip, decimal wg, decimal df, string city, string street, int buildingNo, string desct, decimal cfee) : base(tc, descrip, wg, df, city, street, buildingNo, desct, cfee)
        {

        }
        public sealed override void GenerateCustomeReport()
        {
            Console.WriteLine($"[PRIORITY CLEARANCE] Official Customs Report for {TrackingCode} to {DestinationCountry}. Total Customs: {CustomsFee}");
        }
    }
}
