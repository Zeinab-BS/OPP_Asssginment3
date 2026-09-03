using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Asssginment3
{
    internal  static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
            }
        }

    }
}
