using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoShared
{
    public class EddiscoveryOptions : EliteDangerousCore.IEliteOptions
    {
        public EddiscoveryOptions(string systemDatabasePath, string userDatabasePath, string appDataDirectory)
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
