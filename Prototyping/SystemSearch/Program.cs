using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteDangerousCore;
using EliteDangerousCore.DB;
using EliteDangerousCore.EDSM;
using ProtoShared;
using ProtoShared.TravellingSalesman;

namespace SystemSearch
{


    static class Program
    {

        

            static void Main(string[] args)
        {
            CoordinatesGenerator cg = new CoordinatesGenerator();
            EddiscoveryOptions options = new EddiscoveryOptions(@"D:\games\elite\EDDiscoveryFork\Prototyping\SystemSearch\bin\Debug\data\EDDSystem.sqlite",
                @"D:\games\elite\EDDiscoveryFork\Prototyping\SystemSearch\bin\Debug\data\EDDUser.sqlite",
                @"D:\games\elite\EDDiscoveryFork\Prototyping\SystemSearch\bin\Debug\data");
            EliteConfigInstance.InstanceOptions = options;
            EliteDangerousCore.EliteConfigInstance.InstanceOptions = options;
            EliteDangerousCore.DB.SystemsDatabase.Instance.SetReadOnly();
            EliteDangerousCore.DB.SystemsDatabase.Instance.Initialize();
            EliteDangerousCore.DB.UserDatabase.Instance.SetReadOnly();
            EliteDangerousCore.DB.UserDatabase.Instance.Initialize();


            // read all codex entrys for commander
            /*
            List<string> Commanders = (from EDCommander c in EDCommander.GetListInclHidden() select c.Name).ToList();
            var itm = (from EDCommander c in EDCommander.GetListInclHidden() where c.Name.Equals("mosix") select c).ToList();
            int CommanderID = (itm[0].Nr);


            EliteDangerousCore.DB.GlobalCaptainsLogList.LoadLog();
            //List<CaptainsLogClass> journal = EliteDangerousCore.DB.GlobalCaptainsLogList.Instance.LogEntriesCmdr(CommanderID);
            List<JournalEntry> journal = EliteDangerousCore.JournalEntry.GetByEventType(JournalTypeEnum.CodexEntry,itm[0].Nr,System.DateTime.MinValue,System.DateTime.MaxValue);
            foreach (JournalEntry codexEntry in journal)
            {
                string jsonstring  = codexEntry.GetJsonString();
                Console.WriteLine(jsonstring);
            }
            Console.WriteLine("All codex entrys listed");
           // Console.ReadLine();
            */

            GalacticMapping gal = new GalacticMapping();
            gal.ParseData();


            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("galacticmapobjecttypes.txt");
                foreach (GalMapType gmt in gal.galacticMapTypes)
                {
                    sw.WriteLine(gmt.Typeid);
                }
                sw.Close();
            }

            /*
                historicalLocation
                nebula
                planetaryNebula
                stellarRemnant
                blackHole
                starCluster
                pulsar
                minorPOI
                beacon
                surfacePOI
                cometaryBody
                jumponiumRichSystem
                planetFeatures
                deepSpaceOutpost
                mysteryPOI
                restrictedSectors
                travelRoute
                historicalRoute
                minorRoute
                neutronRoute
                region
                regionQuadrants
                regional
                geyserPOI
                organicPOI
                EDSMUnknown
             */

            List<Location> locationList = new List<Location>();
            string interesingRegion = "Temple";
            string startSystem = "Sol";
            List<string> interestingMapObjects = new List<string>() { "deepSpaceOutpost", "nebula", "planetaryNebula", "starCluster", "blackHole", "pulsar" };
            Dictionary<string,string> PoiTypesWhereJumpilotHasToStop = new Dictionary<string, string>() { { "deepSpaceOutpost", "Sell Exploration Data at the deepSpaceOutpost" } };
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("interesingObjectsInRegion.txt");
                sw.WriteLine(interesingRegion);
                foreach (GalacticMapObject gmo in gal.galacticMapObjects)
                {
                    if (interestingMapObjects.Contains(gmo.type))
                    {


                        Region r = ProtoShared.RegionMap.FindRegion(gmo.points[0].X, gmo.points[0].Y, gmo.points[0].Z);
                        if (r.Name.ToUpper().Trim() == interesingRegion.ToUpper().Trim())
                        {
                            Location l = new Location(gmo.points[0].X, gmo.points[0].Y, gmo.points[0].Z, gmo.galMapSearch,gmo.type,gmo.name);
                            locationList.Add(l);
                         
                        }
                    }
                }
                sw.Close();
            }
            Console.WriteLine("intersting POIs in "+ interesingRegion + " selected");
            

            DataProvider.SetDestinations(locationList);
            
            ISystem iStartSystem = EliteDangerousCore.DB.SystemCache.FindSystem(startSystem);
            Location _startLocation = new Location(iStartSystem.X, iStartSystem.Y, iStartSystem.Z, iStartSystem.Name,"","");
            TravellingSalesmanAlgorithm _algorithm;
            _algorithm = new TravellingSalesmanAlgorithm(_startLocation, DataProvider.GetDestinations(0), 114);

            Dictionary<string,PoiDetails> Destinations = new Dictionary<string, PoiDetails>();
            List<Location> _bestSolutionSoFar = _algorithm.GetBestSolutionSoFar().ToList();
            int nMutations = 100;
            for (int nMutation = 0; nMutation < nMutations; nMutation++)
            {
                _algorithm.Reproduce();
                _bestSolutionSoFar = _algorithm.GetBestSolutionSoFar().ToList();
            }
            {
                //System.IO.StreamWriter sw = new System.IO.StreamWriter("TravellingSalesmanResult.txt");
                foreach (Location l in _bestSolutionSoFar)
                {
                    Coords randomSphereLocB4POI = cg.getRandomSphereCoordinatesAroundPosition(new Coords(l.X, l.Y, l.Z),50,100);
                    ISystem sysSphereLocB4POI = EliteDangerousCore.DB.SystemCache.FindNearestSystemTo(randomSphereLocB4POI[0], randomSphereLocB4POI[1], randomSphereLocB4POI[2], 100.0);
                    // sw.WriteLine(sysSphereLocB4POI.Name);
                    //sw.WriteLine(l.name);
                    Coords randomSphereLocAfterPOI = cg.getRandomSphereCoordinatesAroundPosition(new Coords(l.X, l.Y, l.Z), 50, 100);
                    ISystem sysSphereLocAfterPOI = EliteDangerousCore.DB.SystemCache.FindNearestSystemTo(randomSphereLocAfterPOI[0], randomSphereLocAfterPOI[1], randomSphereLocAfterPOI[2], 100.0);
                    //sw.WriteLine(sysSphereLocAfterPOI.Name);
                    if (!Destinations.ContainsKey(sysSphereLocB4POI.Name))
                    {
                        Destinations.Add(sysSphereLocB4POI.Name,new PoiDetails());
                    }
                    if (!Destinations.ContainsKey(l.name))
                    {
                        Destinations.Add(l.name, new PoiDetails(l.PoiName, l.PoiType, new Coords(l.X,l.Y,l.Z)));
                    }
                    if (!Destinations.ContainsKey(sysSphereLocAfterPOI.Name))
                    {
                        Destinations.Add(sysSphereLocAfterPOI.Name,new PoiDetails());
                    }
                }
               // sw.Close();
            }
            //reference black hole system: Shrogaei UU-X E1-5269 xyz: -1240.5;1144.71875;21046.3125
            //Console.WriteLine("TravellingSalesmanResult written");
            //Console.ReadLine();
            double maxShipJumprage = 38.0;
            double RoutePlannungLegDistance = 1000.0;
            RouteFinder.FindRoute(_startLocation.name, Destinations, maxShipJumprage);

            Console.WriteLine("route is jumpable with jumprage: "+ maxShipJumprage.ToString());

            Dictionary<string,PoiDetails> ResultRoute = RouteFinder.FindRoute(_startLocation.name, Destinations, RoutePlannungLegDistance);


            {
                System.IO.StreamWriter swEddDiscovery = new System.IO.StreamWriter("ResultRouteForEDDiscovery.txt");
                System.IO.StreamWriter swJumpilot = new System.IO.StreamWriter("ResultRouteForJumpilot.txt");
                swJumpilot.WriteLine("JUMPILOT_ROUTEFILE_V1");
                swJumpilot.WriteLine("TARGETSYSTEM\tPOI\tPOITYPE\tACTION\tDESCRIPTION\tCONFIRMEDARRIVAL\tX\tY\tZ");
                foreach (string sys in ResultRoute.Keys)
                {
                    swEddDiscovery.WriteLine(sys);
                    string JumpilotLine = "";
                    string JumpilotAction = "";
                    string JumpilotDescription = "";
                    if (PoiTypesWhereJumpilotHasToStop.ContainsKey(ResultRoute[sys].PoiType))
                    {
                        JumpilotAction = "STOPJUMPILOT";
                        JumpilotDescription = PoiTypesWhereJumpilotHasToStop[ResultRoute[sys].PoiType];
                    }

                    JumpilotLine = sys + "\t" + ResultRoute[sys].PoiName + "\t" + ResultRoute[sys].PoiType + "\t" + JumpilotAction + "\t" + JumpilotDescription + "\t " + "\t " + ResultRoute[sys].coords.X.ToStringInvariant()+"\t" + ResultRoute[sys].coords.Y.ToStringInvariant() + "\t" + ResultRoute[sys].coords.Z.ToStringInvariant();
                    swJumpilot.WriteLine(JumpilotLine);
                }
                swEddDiscovery.Close();
                swJumpilot.Close();
            }

            Console.WriteLine("Resultroute with Legdistance of: " + RoutePlannungLegDistance.ToString() +" has been written");
            Console.ReadLine();
            //
            //

            /*List<Coords> coordinatesAroundReferenceSystem = cg.getRandomSphereCoordinatesAroundPosition(new Coords(-1240.5, 1144.71, 21046.31),
               900.0, 1000.0, 100);

            System.IO.StreamWriter sw1 = new System.IO.StreamWriter("systems.txt");

            Dictionary<string, ISystem> systems = new Dictionary<string, ISystem>();
            foreach (Coords c in coordinatesAroundReferenceSystem)
            {
                //sw1.WriteLine(c[0].ToString() + ";" + c[1].ToString() + ";" + c[2].ToString());
                ISystem sys = EliteDangerousCore.DB.SystemCache.FindNearestSystemTo(c[0], c[1], c[2], 100.0);
                if (!systems.ContainsKey(sys.Name))
                {
                    systems.Add(sys.Name, sys);
                }
            }




            foreach (ISystem sys in systems.Values)
            {
                if (sys != null)
                {
                    sw1.WriteLine(sys.Name);
                }
            }
            sw1.Close();
            Console.WriteLine("systems written");
            /*EliteDangerousCore.ISystem system = new SystemClass();
            ISystem foundSystem = EliteDangerousCore.DB.SystemCache.FindSystem("Shrogaei UU-X E1-5269");
            Console.WriteLine(foundSystem.X.ToString() + ";" + foundSystem.Y.ToString() + ";" + foundSystem.Z.ToString());*/
            Console.ReadLine();
            //EliteDangerousCore.DB.SystemsDatabase.Instance.


        }

    }

   

   

}