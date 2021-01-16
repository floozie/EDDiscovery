using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteDangerousCore;
using EliteDangerousCore.DB;
using EliteDangerousCore.EDSM;

namespace SystemSearch
{
    public class Coords
    {
        public double X;
        public double Y;
        public double Z;

        public Coords()
        {

        }
        public Coords(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double this[int key]
        {
            get => getKey(key);
            set => setKey(key, value);
        }

        private double getKey(int key)
        {
            switch (key)
            {
                case 0:return X;
                case 1: return Y;
                case 2: return Z;

            }
            return 0.0;
        }

        private void setKey(int key, double value)
        {
            switch (key)
            {
                case 0: X = value; break;
                case 1: Y = value; break;
                case 2: Z = value; break;

            }
            
        }

    }


    static class Program
    {
        private static Random rand;

        static void Main(string[] args)
        {
            rand = new Random();
            EddiscoverOptions options = new EddiscoverOptions(@"D:\games\elite\EDDiscoveryFork\Prototyping\SystemSearch\bin\Debug\data\EDDSystem.sqlite",
                @"D:\games\elite\EDDiscoveryFork\Prototyping\SystemSearch\bin\Debug\data\EDDUser.sqlite",
                @"D:\games\elite\EDDiscoveryFork\Prototyping\SystemSearch\bin\Debug\data");
            EliteConfigInstance.InstanceOptions = options;
            EliteDangerousCore.EliteConfigInstance.InstanceOptions = options;
            EliteDangerousCore.DB.SystemsDatabase.Instance.SetReadOnly();
            EliteDangerousCore.DB.SystemsDatabase.Instance.Initialize();

            GalacticMapping gal = new GalacticMapping(true);
            gal.ParseData();

            System.IO.StreamWriter sw = new System.IO.StreamWriter("galacticmapobjecttypes.txt");


            foreach (GalMapType gmt in gal.galacticMapTypes)
            {
                sw.WriteLine(gmt.Typeid);
            }
            sw.Close();

            foreach (GalacticMapObject gmo in gal.galacticMapObjects)
            {
                if (gmo.type == "nebula")
                {
                    Console.WriteLine("NebulaName:" + gmo.name);
                    SystemSearch.Classes.Region r = SystemSearch.Classes.RegionMap.FindRegion(gmo.points[0].X, gmo.points[0].Y, gmo.points[0].Z);
                    Console.WriteLine(r.Name);
                    Console.WriteLine("---");
                }
            }



           
            //reference black hole system: Shrogaei UU-X E1-5269 xyz: -1240.5;1144.71875;21046.3125


            List<Coords> coordinatesAroundReferenceSystem = getRandomCoodinateList(new Coords(-1240.5, 1144.71, 21046.31),
                new Coords(25,1, 25), new Coords(1200, 100, 1200.0), 100);

            System.IO.StreamWriter sw1 = new System.IO.StreamWriter("systems.txt");

            Dictionary<string, ISystem> systems = new Dictionary<string, ISystem>();
            foreach (Coords c in coordinatesAroundReferenceSystem)
            {
                sw1.WriteLine(c[0].ToString()+";"+ c[1].ToString()+";"+ c[2].ToString());
                ISystem sys = EliteDangerousCore.DB.SystemCache.FindNearestSystemTo(c[0],c[1],c[2],100.0);
                if (!systems.ContainsKey(sys.Name))
                {
                    systems.Add(sys.Name,sys);
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

        public static Coords getRandomCoordinatesAroundVector3(Coords Coordinates, Coords minDeviations, Coords maxDeviations)
        {
            Coords result = new Coords();
            for (int i = 0; i < 3; i++)
            {
                // randomize if we want positive or negative deviation
               
                bool positive = Convert.ToBoolean( rand.Next()%2);
                if (positive)
                {
                    result[i] = Coordinates[i] + GetRandomNumberInRange(minDeviations[i], maxDeviations[i]);
                }
                else
                {
                    result[i] = Coordinates[i] - GetRandomNumberInRange(minDeviations[i], maxDeviations[i]);
                }
            }
            return result;

        }

        public static double GetRandomNumberInRange(double minNumber, double maxNumber)
        {
            return rand.NextDouble() * (maxNumber - minNumber) + minNumber;
        }

        public static List<Coords> getRandomCoodinateList(Coords Coordinates, Coords minDeviations, Coords maxDeviations, int numResults)
        {
            List<Coords> resultList = new List<Coords>();
            for (int i = 0; i < numResults; i++)
            {
                resultList.Add(getRandomCoordinatesAroundVector3(Coordinates, minDeviations, maxDeviations));
            }
            return resultList;
        }
    }

   

    public class EddiscoverOptions : EliteDangerousCore.IEliteOptions
    {
        public EddiscoverOptions(string systemDatabasePath, string userDatabasePath, string appDataDirectory)
        {
            SystemDatabasePath = systemDatabasePath;
            UserDatabasePath = userDatabasePath;
            AppDataDirectory = appDataDirectory;
            ForceBetaOnCommander = false;
            DisableMerge = true;
            DisableBetaCommanderCheck = true;

        }
        public string AppDataDirectory { get; set; }

        public string SystemDatabasePath { get; set; }

        public string UserDatabasePath { get; set; }

        public bool ForceBetaOnCommander { get; set; }

        public bool DisableMerge { get; set; }

        public bool DisableBetaCommanderCheck { get; set; }
    }

}