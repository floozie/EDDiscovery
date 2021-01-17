using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoShared
{
    public class PoiDetails
    {
        public PoiDetails()
        {
            coords = new Coords();
        }
        public PoiDetails(string PoiName, string PoiType, Coords coords)
        {
            this.PoiName = PoiName;
            this.PoiType = PoiType;
            this.coords = coords;
        }
        public string PoiName = "";
        public string PoiType = "";
        public Coords coords;
    }
}
