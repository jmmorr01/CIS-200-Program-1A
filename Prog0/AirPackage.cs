// Grading ID C2937
// Program 1A
// Due 9/25/2017
// Section 200-01
// Description: This class is used to construct an Airpackage object which is derived from the package class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class AirPackage : Package
    {
        const int WEIGHT_LIMIT = 75; // constant for weight limit restriction.
        const int SIZE_LIMIT = 100; // constant for size limit restriction.
        //Precondition: all values inputed must be >= 0
        //Postcondition: an airpackage object will be created with the specified characteristics.
        public AirPackage(Address originAddress, Address destinationAddress, double packLength, double packWidth, double packHeight, double packWeight) : base(originAddress, destinationAddress, packLength, packWidth, packHeight, packWeight)
        {

        }
        //Precondition: weight >= 0
        //Postcondition: bool value will be returned depending on weight of package
        public bool IsHeavy()
        {
            return Weight >= WEIGHT_LIMIT;
        }
        //Precondition: size >= 0
        //Postcondition: bool value will be returned depending on size of package
        public bool IsLarge()
        {
            return (Length + Width + Height) >= SIZE_LIMIT;
        }
        //Precondition: all previous conditions must be met. 
        //Postcondition: the data from the airpackage will be formatted into a string.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"AirPackage{base.ToString()}{NL}IsHeavy: {IsHeavy()}{NL}IsLarge: {IsLarge()}";
        }
    }
}
