using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType MilitaryPlaneType { get; private set; }

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType militaryPlaneType)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            MilitaryPlaneType = militaryPlaneType;
        }
        public override string ToString()
        {
            return base.ToString().Replace( ")" , $", MilitaryPlaneType = {MilitaryPlaneType} )");
        }
        public override bool Equals(object obj)
        {
            MilitaryPlane plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   MilitaryPlaneType == plane.MilitaryPlaneType;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + MilitaryPlaneType.GetHashCode();
            return hashCode;
        }

          
    }
}
