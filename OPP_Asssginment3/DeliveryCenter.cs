using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Asssginment3
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;
        public string CenterName { get; set; }
        public Driver Driver { get; set; }

        public DeliveryCenter(string Name, Driver driver)
        {
            shipments = new Shipment[20];
            CenterName = Name;
            Driver = driver;


        }




        #region indexres
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];

                }

                return null;

            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;

                }


            }

        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }

                }
                return null;

            }

        }
        #endregion



        #region AddShipment


        public bool AddShipment(Shipment s)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = s;
                    return true;
                }

            }

            return false;
        }


        #endregion


        #region RemoveShipment


        public bool RemoveShipment(string tracking)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == tracking)
                {
                    shipments[i] = null;
                    return true;
                }

            }

            return false;
        }





        #endregion


        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {

                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine();

                }


            }

        }
    }
}
