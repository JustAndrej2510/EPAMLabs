using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int PassengerCapacity { get; private set; }

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengerCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            PassengerCapacity = passengerCapacity;
        }

        public override bool Equals(object obj)
        {
            PassengerPlane plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   PassengerCapacity == plane.PassengerCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + PassengerCapacity.GetHashCode();
            return hashCode;
        }

       
        public override string ToString()
        {
            return base.ToString().Replace(")", $", PassengerCapacity = {PassengerCapacity} )");
        }

    }
}
