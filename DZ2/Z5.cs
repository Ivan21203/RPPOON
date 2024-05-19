﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class Z5
    {
        public class Location
        {
            public DateTime Creation { get; private set; } 
            public double Latitude { get; private set; } 
            public double Longitude { get; private set; } 

            public Location(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
                Creation = DateTime.Now;
            }
        }

        public class PathManager
        {
            private List<Location> locations; 

            public PathManager()
            {
                locations = new List<Location>();
            }

            public void AddLocation(Location location)
            {
                locations.Add(location);
            }

            public void RemoveLocation(Location location)
            {
                locations.Remove(location);
            }
        }

    }
}
