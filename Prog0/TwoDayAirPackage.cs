// Grading ID C2937
// Program 1A
// Due 9/25/2017
// Section 200-01
// Description: This class is used to construct a TwoDayAirPackage object which is derived from the AirPackage class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class TwoDayAirPackage : AirPackage
    {
        public enum Delivery {Early, Saver}; // enum that is used for the delivery type for the package.

        //Precondition: all values inputed must be >=0 
        //Postcondition: a nextdayairpackage object will be created with the specified characteristics.
        public TwoDayAirPackage(Address originAddress, Address destinationAddress, double packLength, double packWidth, double packHeight, double packWeight, Delivery deliveryType) : base(originAddress, destinationAddress, packLength, packWidth, packHeight, packWeight)
        {
            DeliveryType = deliveryType;
        }

        public Delivery DeliveryType
        {
            //Precondition: none.
            //Postcondition: deliverytype will be returned.
            get;
            //Precondition: none.
            //Postcondition: deliverytype will be set.
            set;
        }
        //Precondition: the value must be >=0
        //Postcondition: the cost to ship the twodayairpackage will be calculated.
        public override decimal CalcCost()
        {
            const decimal MULTI_FACTOR_1 = .25m; // constant used when calculating cost of package.
            const decimal SAVINGS_FACTOR = .90M; // constant used when calculating cost of package.
            decimal totalCost; // variable to hold the running total cost of package. 

            totalCost = (MULTI_FACTOR_1 * ((decimal)Length + (decimal)Width + (decimal)Height)) + (MULTI_FACTOR_1 * ((decimal)Weight));

            if (DeliveryType == Delivery.Saver)
                totalCost = totalCost * SAVINGS_FACTOR;

            return totalCost;
        }
        //Precondition: all previous conditions must be met. 
        //Postcondition: the data from the twodayairpackage will be formatted into a string.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"TwoDay{base.ToString()}{NL}Delivery Type: {DeliveryType}";
        }
    }
}
