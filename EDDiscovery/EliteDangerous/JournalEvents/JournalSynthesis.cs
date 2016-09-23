﻿using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    //When written: when synthesis is used to repair or rearm
    //Parameters:
    //•	Name: synthesis blueprint
    //•	Materials: JSON object listing materials used and quantities
    public class JournalSynthesis : JournalEntry
    {
        public JournalSynthesis(JObject evt ) : base(evt, JournalTypeEnum.Synthesis)
        {
            Name = Tools.GetStringDef(evt["Name"]);
            Materials = evt["Materials"]?.ToObject<Dictionary<string, int>>();
        }
        public string Name { get; set; }
        public Dictionary<string, int> Materials { get; set; }

    }
}
