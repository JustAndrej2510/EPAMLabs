using Aircompany.Models;
using Aircompany.Planes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        public List<Plane> Planes { get; private set; }

        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }

        public List<T> GetPlanes<T>() where T : Plane
        {
            return (List<T>)Planes.Where(plane => plane.GetType() == typeof(T));
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return (PassengerPlane)GetPlanes<PassengerPlane>().OrderByDescending(plane => plane.PassengersCapacity).Take(1);
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return (List<MilitaryPlane>)GetPlanes<MilitaryPlane>().Where(plane => plane.MilitaryPlaneType == MilitaryType.Transport);
        }

        public Airport SortByMaxDistance()
        {
            return new Airport(Planes.OrderBy(plane => plane.MaxFlightDistance));
        }

        public Airport SortByMaxSpeed()
        {
            return new Airport(Planes.OrderBy(plane => plane.MaxSpeed));
        }

        public Airport SortByMaxLoadCapacity()
        {
            return new Airport(Planes.OrderBy(plane => plane.MaxLoadCapacity));
        }

        public override string ToString()
        {
            return $"Airport planes: {string.Join(", ", Planes.Select(plane => plane.Model))}";
        }
    }
}
