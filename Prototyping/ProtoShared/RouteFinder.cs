using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteDangerousCore;
using EliteDangerousCore.DB;
using EliteDangerousCore.EDSM;

namespace ProtoShared
{
    public static class RouteFinder
    {
        private static void AppendData(RoutePlotter.ReturnInfo info)   // IN thread context, need to invoke
        {

        }

        public static Dictionary<string, PoiDetails> FindRoute(string startLocation, Dictionary<string,PoiDetails> Destinations, double maxJumprange)
        {
            Dictionary<string, PoiDetails> result = new Dictionary<string, PoiDetails>();
            List<ISystem> route = new List<ISystem>();
            EliteDangerousCore.RoutePlotter routePlotter = new RoutePlotter();
            routePlotter.MaxRange = (float)maxJumprange;
            string from = startLocation;
            // check if can be travelled with current jumpdistance
            foreach (string system in Destinations.Keys)
            {
                routePlotter.FromSystem = from;
                ISystem sysFrom = EliteDangerousCore.DB.SystemCache.FindSystem(from);
                routePlotter.Coordsfrom = new EMK.LightGeometry.Point3D(sysFrom.X, sysFrom.Y, sysFrom.Z);

                string to = system;

                routePlotter.ToSystem = to;
                ISystem sysTo = EliteDangerousCore.DB.SystemCache.FindSystem(to);
                routePlotter.Coordsto = new EMK.LightGeometry.Point3D(sysTo.X, sysTo.Y, sysTo.Z);

                route.AddRange(routePlotter.RouteIterative(AppendData));

                foreach (ISystem sys in route)
                {
                    if (sys.Name.ToUpper().Trim() == "WAYPOINT")
                    {
                        throw new Exception("Route is not jumpable with jumprage: " + routePlotter.MaxRange.ToString());

                    }
                    if (!result.ContainsKey(sys.Name))
                    {
                        PoiDetails poiDetails = new PoiDetails();
                        if (Destinations.ContainsKey(sys.Name))
                        {
                            poiDetails = Destinations[sys.Name];
                           
                        }
                        poiDetails.coords = new Coords(sys.X, sys.Y, sys.Z);
                        result.Add(sys.Name, poiDetails);
                    }

                }
                from = to;
            }
           
            return result;
        }
    }
}
