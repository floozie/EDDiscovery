using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoShared
{
    public class CoordinatesGenerator
    {
        private Random rand;

        public CoordinatesGenerator()
        {
            rand = new Random();
        }

        public Coords getRandomBoxedCoordinatesAroundPosition(Coords Coordinates, Coords minDeviations, Coords maxDeviations)
        {
            Coords result = new Coords();
            for (int i = 0; i < 3; i++)
            {
                // randomize if we want positive or negative deviation

                bool positive = Convert.ToBoolean(rand.Next() % 2);
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

        private double GetRandomNumberInRange(double minNumber, double maxNumber)
        {
            return rand.NextDouble() * (maxNumber - minNumber) + minNumber;
        }

        public List<Coords> getRandomBoxedCoordinatesAroundPosition(Coords Coordinates, Coords minDeviations, Coords maxDeviations, int numResults)
        {
            List<Coords> resultList = new List<Coords>();
            for (int i = 0; i < numResults; i++)
            {
                resultList.Add(getRandomBoxedCoordinatesAroundPosition(Coordinates, minDeviations, maxDeviations));
            }
            return resultList;
        }

        public Coords getRandomSphereCoordinatesAroundPosition(Coords Coordinates, double minDeviation, double maxDeviation)
        {
            while (true)
            {
                Coords result = new Coords();
                for (int i = 0; i < 3; i++)
                {
                    result[i] = GetRandomNumberInRange(-maxDeviation, maxDeviation);
                }
                double sqrtOfSquares = Math.Sqrt((result[0] * result[0]) + (result[1] * result[1]) + (result[2] * result[2]));
                if (sqrtOfSquares < maxDeviation && sqrtOfSquares > minDeviation)
                {
                    result[0] += Coordinates[0];
                    result[1] += Coordinates[1];
                    result[2] += Coordinates[2];
                    return result;
                }
            }

        }

        public List<Coords> getRandomSphereCoordinatesAroundPosition(Coords Coordinates, double minDeviation, double maxDeviation, int numResults)
        {
            List<Coords> resultList = new List<Coords>();
            for (int i = 0; i < numResults; i++)
            {
                resultList.Add(getRandomSphereCoordinatesAroundPosition(Coordinates, minDeviation, maxDeviation));
            }
            return resultList;
        }


    }
}
