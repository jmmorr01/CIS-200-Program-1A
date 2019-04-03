// Grading ID C2937
// Program 1A
// Due 9/25/2017
// Section 200-01
// Description: This class is used to construct a Groundpackage object which is derived from the Package class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class GroundPackage : Package
    {
        //Precondition: the values inputted must be >=0.
        //Postcondition: a groundpackage object will be created with the specified characteristics.
        public GroundPackage(Address originAddress, Address destinationAddress, double packLength, double packWidth, double packHeight, double packWeight) : base (originAddress, destinationAddress, packLength, packWidth, packHeight, packWeight)
        {

        }

        public int ZoneDistance
        {
            //Precondition: none
            //Postcondition: the zonedistance will be returned.
            get
            {
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
                int diff;                             // Calculated zone difference

                diff = (OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR);

                return Math.Abs(diff); // Absolute value in case negative
            }
        }
        //Precondition: the value must be >=0
        //Postcondition: the cost to ship the groundpackage will be calculated.
        public override decimal CalcCost()
        {
            const decimal MULTI_FACTOR_1 = .20m;
            const decimal MULTI_FACTOR_2 = .50m;

            return (MULTI_FACTOR_1 * ((decimal)Length + (decimal)Width + (decimal)Height)) + MULTI_FACTOR_2 * (ZoneDistance + 1) * ((decimal)Weight);         
        }
        //Precondition: all previous conditions must be met. 
        //Postcondition: the data from the groundpackage will be formatted into a string.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"GroundPackage{base.ToString()}{NL}Zone Distance: {ZoneDistance}";
        }
    }
}
