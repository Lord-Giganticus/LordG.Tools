using System.IO;
using System.Collections.Generic;


namespace LordG.Tools.Drive
{
    public class Drive
    {
        public class GetDrives
        {
            /// <summary>
            /// Gets all drives that have a valid path.
            /// </summary>
            /// <returns>A string array of all drives that have a valid path.</returns>
            public string[] AsString()
            {
                List<string> Drives = new List<string>();
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo d in drives)
                {
                    if (Directory.Exists(d.Name))
                    {
                        Drives.Add(d.Name);
                    }
                }
                return Drives.ToArray();
            }
            /// <summary>
            /// Gets all drives that have a valid path.
            /// </summary>
            /// <returns>A DriveInfo array of all drives that have a valid path.</returns>
            public DriveInfo[] AsDriveInfo()
            {
                List<DriveInfo> Drives = new List<DriveInfo>();
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo d in drives)
                {
                    if (Directory.Exists(d.Name)) {
                        Drives.Add(d);
                    }
                }
                return Drives.ToArray();
            }
        }
    }
}
