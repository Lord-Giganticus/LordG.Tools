using System.IO;
using System.Collections.Generic;
using System;

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
            public IEnumerator<string> AsString()
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo d in drives)
                {
                    if (Directory.Exists(d.Name))
                    {
                        yield return d.Name;
                    }
                }
            }
            /// <summary>
            /// Gets all drives that have a valid path.
            /// </summary>
            /// <returns>A DriveInfo array of all drives that have a valid path.</returns>
            public static IEnumerator<DriveInfo> AsDriveInfo()
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo d in drives)
                {
                    if (Directory.Exists(d.Name)) {
                        yield return d;
                    }
                }
            }

            public static DirectoryInfo[] AsDirectoryInfo()
            {
                var list = new List<DirectoryInfo>();
                foreach (var d in DriveInfo.GetDrives())
                    list.Add(d.RootDirectory);
                return list.ToArray();
            }

            public static Tuple<DriveInfo, DriveType>[] AsTuples()
            {
                var l = new List<Tuple<DriveInfo, DriveType>>();
                foreach (var d in DriveInfo.GetDrives())
                    l.Add(Tuple.Create(d, d.DriveType));
                return l.ToArray();
            }

            public static DriveType[] AsDriveType()
            {
                var l = new List<DriveType>();
                foreach (var d in DriveInfo.GetDrives())
                    l.Add(d.DriveType);
                return l.ToArray();
            }
        }
        /// <summary>
        /// Waits for a certian <see cref="DriveType"/> to be present in <see cref="GetDrives.AsDriveType"/>
        /// </summary>
        /// <param name="type">The type to check for</param>
        /// <returns>The <see cref="DirectoryInfo"/> of the drive that has the <see cref="DriveType"/> specified.</returns>
        public static DirectoryInfo WaitForCertianDriveType(DriveType type)
        {
            int index = -1;
            while (!GetDrives.AsDriveType().ToList().Contains(type))
                if (!GetDrives.AsDriveType().ToList().Contains(type))
                    continue;
                else
                {
                    index = GetDrives.AsDriveType().ToList().IndexOf(type);
                    break;
                }
            return GetDrives.AsDirectoryInfo()[index];
        }
    }

    public static class DriveExt
    {
        /// <summary>
        /// Checks if a drive is a certain type. 
        /// </summary>
        /// <param name="drive">The drive you want to check.</param>
        /// <param name="type">The type you want to check. EX: <see cref="DriveType.Fixed"/></param>
        /// <returns></returns>
        public static bool IsType(this DriveInfo drive, DriveType type)
        {
            return drive.DriveType == type;
        }

        /// <summary>
        /// Converts a <typeparamref name="T"/>[] object to a List.
        /// </summary>
        /// <typeparam name="T">The object type.</typeparam>
        /// <param name="ts">The object to use.</param>
        /// <returns>A new <see cref="List{T}"/> object.</returns>
        public static List<T> ToList<T>(this T[] ts)
        {
            var l = new List<T>();
            foreach (var t in ts)
                l.Add(t);
            return l;
        }
    }
}
