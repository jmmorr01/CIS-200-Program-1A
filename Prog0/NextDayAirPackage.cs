// Grading ID C2937
// Program 1A
// Due 9/25/2017
// Section 200-01
// Description: This class is used to construct a NextDayAirPackage object which is derived from the AirPackage class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class NextDayAirPackage : AirPackage
    {
        private decimal expressFee; // variable used to hold the expressFee

        //Precondition: all values inputed must be >=0 
        //Postcondition: a nextdayairpackage object will be created with the specified characteristics.
        public NextDayAirPackage(Address originAddress, Address destinationAddress, double packLength, double packWidth, double packHeight, double packWeight, decimal expressFee) : base(originAddress, destinationAddress, packLength, packWidth, packHeight, packWeight)
        {
            ExpressFee = expressFee;
        }
        
        public decimal ExpressFee
        {
            //Precondition: none.
            //Postcondition: expressfee will be returned.
            get
            {
                return expressFee;
            }
            //Precondition: value must be >=0
            //Postcondition: expressfee will be set.
            private set
            {
                if (value >= 0)
                    expressFee = value;
                else
                    throw new ArgumentOutOfRangeException("ExpressFee", value,
                    "ExpressFee must be >= 0");
            }
        }
        //Precondition: the value must be >=0
        //Postcondition: the cost to ship the nextdayairpackage will be calculated.
        public override decimal CalcCost()
        {
            const decimal MULTI_FACTOR_1 = .25m; // constant used when calculating cost.
            const decimal MULTI_FACTOR_2 = .30m; // constant used when calculating cost.
            const decimal MULTI_FACTOR_3 = .40m; // constant used when calculating cost.
            decimal totalCost; // variable to hold the running total cost of package.

            totalCost = (MULTI_FACTOR_3 * ((decimal)Length + (decimal)Width + (decimal)Weight)) + (MULTI_FACTOR_2 * ((decimal)Weight)) + ExpressFee;

            if (IsHeavy())
                totalCost += (MULTI_FACTOR_1 * ((decimal)Weight));
            if (IsLarge())
                totalCost += (MULTI_FACTOR_1 * ((decimal)Length + (decimal)Width + (decimal)Height));

            return totalCost;
        }
        //Precondition: all previous conditions must be met. 
        //Postcondition: the data from the nextdayairpackage will be formatted into a string.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"NextDay{base.ToString()}{NL}Express Fee: {ExpressFee:C}";
        }
    }
}
