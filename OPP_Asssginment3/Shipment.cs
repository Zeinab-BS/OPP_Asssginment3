using System;
using System.Collections.Generic;
using System.Text;

namespace OPP_Asssginment3
{
    internal class Shipment
    {
        #region Attributes
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;

        #endregion
        #region Properties


        public string TrackingCode
        {
            get
            {

                return trackingCode;

            }
        } //Read only property 

        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Description Can not Be Null or Empty or WhiteSpace");
                }

                description = value;



            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }


            }
        }



        public Decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                {

                    deliveryFee = value;


                }
            }
        }



        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }

        }


        public virtual decimal EstimatedCost
        {
            get
            {
                return deliveryFee + (weight * 5);
            }
        }

        #endregion

        #region CTOR

        public Shipment(string Tcode)
        {

            if (string.IsNullOrWhiteSpace(Tcode))
            {
                throw new ArgumentException("TrackingCode Can not Be Null or Empty or WhiteSpace");
            }
            trackingCode = Tcode;

            Description = "Unknown";
            Weight = 1;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        public Shipment(string Tcode, string description, decimal w, decimal Dfee, string _city, string _street, int _bNum)
        {
            if (string.IsNullOrWhiteSpace(Tcode))
            {
                throw new ArgumentException("TrackingCode Can not Be Null or Empty or WhiteSpace");
            }

            if (Dfee <= 0)
            {
                throw new ArgumentException("DeliveryFee must be greater than 0.");
            }

            if (w <= 0)
            {
                throw new ArgumentException("Weight must be greater than 0.");
            }




            trackingCode = Tcode;
            Description = description;
            Weight = w;
            Destination = new DeliveryAddress(_city, _street, _bNum);
            deliveryFee = Dfee;

        }


        #endregion

        #region Methods

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }


        public void UpdateWeight(decimal newWeigth)
        {
            if (newWeigth <= 0)
            {
                throw new ArgumentException("Weigth Must be greater than 0");

            }
            Weight = newWeigth;


        }


        public void UpdateWeight(decimal newWeigth, decimal extraPacking)
        {
            if (newWeigth <= 0 || extraPacking < 0)
            {
                throw new ArgumentException("Weigth Must be greater than 0");

            }
            Weight = newWeigth + extraPacking;

        }




        public virtual void PrintShipment()

        {
            Console.WriteLine($"TrackingCode: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"DeliveryFee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Cost: {EstimatedCost}");

        }

        #endregion
    }
}
