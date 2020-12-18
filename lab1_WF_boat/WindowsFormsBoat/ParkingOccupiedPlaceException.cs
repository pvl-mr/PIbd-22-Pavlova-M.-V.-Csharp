using System;
using System.Runtime.Serialization;

namespace WindowsFormsBoat
{
    internal class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException(int i) : base("Место " + i + " занято")
        { }
    }
}