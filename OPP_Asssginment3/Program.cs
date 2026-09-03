namespace OPP_Asssginment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            // What is the difference between Method Overloading and Method Overriding?
            /*
            
             Method Overloading 
             one or more method in the same class struct with the same name but with the different 
             signature(parameters) [num or datatypes or order]


            Method Overriding

            one or more method in different classes(occours in inheritance) with the same name
            but with different implementation 

           * occour through [new or override keyword]



            /************************************************************************************/

            //  What is the difference between Static Binding and Dynamic Binding?

            /* 
             

             
                  Static Binding (early binding)           Dynamic Binding (late binding)
              
when               At compile time                           At run time 

who perform        compiler                                  CLR
              
decided by         refrence type                             actual object

keyword            new                                     override-virtual

used with           method overloading                       method overriding
                    method hiding                            method interfaces 
                    static methods                           abstract methods 


performance         faster                                      slower


flexability        less flexible                              more flexible



             */



            /************************************************************************************/


            //a) What is the purpose of the sealed keyword when applied to a class?

            /*
             purpose of the sealed keyword when applied to a class is to prevent inheritance from 
             this class to protect logic.

             
             */


            //b) What is the difference between a sealed class and a sealed method?

            /*
             
             sealed class ->class that cannot be inherited 

             sealed method-> method that cannot be overriden but can be hidden .

            */


            //Can a sealed method be overridden? Why?

            /*
             no , becuase sealed keyword prevent derived class to overrride methods 

                            *********************************
            */

            #endregion

            #region Part02

            // create a driver 
            Driver driver = new Driver(1234, "Ahmed", 0483300439);

            // create  delivery center
            DeliveryCenter center = new DeliveryCenter("cairo delivery center", driver);

            // Assign driver to delivery center 
            center.Driver = driver;

            // create one standaradShipment

            StandardShipment Standard = new StandardShipment("ST001", "Books", 5, 50, "cairo", "Tharir Street", 10);

            // create one ExpressShipment

            ExpressShipment express = new ExpressShipment("EX001", "Laptop", 3, 100, "Giza", "Dokki", 20, 50);

            //create one InternationalShipment

            InternationalShipment International = new InternationalShipment("IN001", "Clothes", 7, 150, "Alexandria", "Smouha", 30, "USA", 75);

            //Add all shipments to the DeliveryCenter
            center.AddShipment(Standard);
            center.AddShipment(express);
            center.AddShipment(International);

            //Print all shipments using PrintAllShipments().

            center.PrintAllShipments();
            Console.WriteLine("========== DELIVERY HELPER ==========");
            //Call DeliveryHelper.PrintShipmentDetails() for each shipment.
            Console.WriteLine();
            DeliveryHelper.PrintShipmentDetails(Standard);
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(express);
            Console.WriteLine();


            DeliveryHelper.PrintShipmentDetails(International);
            Console.WriteLine();


            //Demonstrate both versions of UpdateWeight()
            Console.WriteLine("========== UPDATE WEIGHT ==========");
            //Frist Version
            Standard.UpdateWeight(10);
            Console.WriteLine($"After Update Weight ,Standard Weigth={Standard.Weight}");
            //Seconde Version
            express.UpdateWeight(8, 2);
            Console.WriteLine($"After Update Weight ,Express Weigth={express.Weight}");

            //Build a Shipment[] holding mixed types and print all of them in a loop.
            Console.WriteLine("========== MIXED SHIPMENTS ==========");
            Shipment[] shipments =
            {
                Standard,
                express,
                International

            };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
                Console.WriteLine();
            }

            //Demonstrate the sealed class and sealed method(comments or code).

            // l. Demonstrate the sealed class 
            // CompletedShipment is a sealed class,
            // so it cannot be inherited from.

            Console.WriteLine("========== COMPLETED SHIPMENT ==========");
            CompletedShipment completed = new CompletedShipment("CO001", "Documents", 2, 40, "Cairo", "Heliopolis", 15);
            completed.PrintShipment();

            Console.WriteLine("========== PRIORITY INTERNATIONAL SHIPMENT ==========");
            // Demonstrate the sealed method
            PriorityInternationalShipment PriorityInternational = new PriorityInternationalShipment("PR001", "Important Package", 4, 200, "Cairo", "Maadi", 25, "UK", 100);
            PriorityInternational.GenerateCustomeReport();
            #endregion













        }
    }
    }

