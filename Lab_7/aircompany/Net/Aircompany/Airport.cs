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

        public IEnumerable<T> GetPlanes<T>() where T : class
        {
            List<T> desiredPlanes = new List<T>();
            foreach (var plane in Planes)
            {
                if (plane.GetType() == typeof(T))
                {
                    desiredPlanes.Add(plane as T);
                }
            }
            return desiredPlanes;
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return (PassengerPlane)GetPlanes<PassengerPlane>().OrderByDescending(plane => plane.PassengersCapacity).First();
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return GetPlanes<MilitaryPlane>().Where(plane => plane.MilitaryPlaneType == MilitaryType.Transport).ToList();
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
