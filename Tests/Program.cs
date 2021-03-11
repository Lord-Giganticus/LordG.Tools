using System;
using System.IO;
using LordG.Tools.Drive;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Drive.GetDrives getDrives = new Drive.GetDrives();
            Drive drive = new Drive();
            DriveInfo[] drives = getDrives.AsDriveInfo();
            foreach (DriveInfo d in drives)
            {
                if (drive.IsType(d, DriveType.Fixed))
                {
                    Console.WriteLine(d.Name);
                }
            }
        }
    }
}
