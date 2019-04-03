// Grading ID C2937
// Program 1A
// Due 9/25/2017
// Section 200-01
// Description: This class is used to construct a package object that is derived from a parcel object.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Package : Parcel
    {
        private double packageLength; // Variable used to hold the package length
        private double packageWidth; // Variable used to hold the package width
        private double packageHeight; // Variable used to hold the package height
        private double packageWeight; // Variable used to hold the package weight

        //Precondition: all of the values be inputed must be >=0 
        //Postcondition: the package object will be created with the specific characteristics.
        public Package(Address originAddress, Address destinationAddress, double packLength, double packWidth, double packHeight, double packWeight) : base (originAddress, destinationAddress)
        {
            Length = packLength;
            Width = packWidth;
            Height = packHeight;
            Weight = packWeight;
        }
        
        public double Length
        {
            //Precondition: none
            //Postcondition: The package length will be returned.
            get
            {
                return packageLength;
            }
            //Precondition: the value must be >=0
            //Postcondition: the package length will be set.
            set
            {
                if (value >= 0)
                    packageLength = value;
                else
                    throw new ArgumentOutOfRangeException("Length", value,
                    "Length must be >= 0");
            }
        }

        public double Width
        {
            //Precondition: none
            //Postcondition: The package width will be returned.
            get
            {
                return packageWidth;
            }
            //Precondition: the value must be >=0
            //Postcondition: the package width will be set.
            set
            {
                if (value >= 0)
                    packageWidth = value;
                else
                    throw new ArgumentOutOfRangeException("Width", value,
                    "Width must be >= 0");
            }
        }

        public double Height
        {
            //Precondition: none
            //Postcondition: The package height will be returned.
            get
            {
                return packageHeight;
            }
            //Precondition: the value must be >=0
            //Postcondition: the package height will be set.
            set
            {
                if (value >= 0)
                    packageHeight = value;
                else
                    throw new ArgumentOutOfRangeException("Height", value,
                    "Height must be >= 0");
            }
        }

        public double Weight
        {
            //Precondition: none
            //Postcondition: The package weight will be returned.
            get
            {
                return packageWeight;
            }
            //Precondition: the value must be >=0
            //Postcondition: the package weight will be set.
            set
            {
                if (value >= 0)
                    packageWeight = value;
                else
                    throw new ArgumentOutOfRangeException("Weight", value,
                    "Weight must be >= 0");
            }
        }
        //Precondition: all previous conditions must be met. 
        //Postcondition: the data from the package will be formatted into a string.
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"{NL}{base.ToString()}{NL}{NL}Length: {Length:N1}{NL}Width: {Width:N1}{NL}" + $"Height: {Height:N1}{NL}Weight: {Weight:N1}";
        }
    }
}
