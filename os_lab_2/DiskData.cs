using System;
using System.Collections.Generic;
using System.IO;

namespace os_lab_2
{
    class DiskData
    {
        public string[] get_disk_names() // get all disk names
        {
            List<string> disk_names = new List<string>(); // list for variable length
            DriveInfo[] drives = DriveInfo.GetDrives(); // get drive info
            foreach (DriveInfo drive in drives)
            {
                disk_names.Add(drive.Name);
            }
            return disk_names.ToArray(); // convert list to array
        }

        public DriveInfo get_disk_data(string drive_name) // get data about 'drive_name'
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                if (drive.Name == drive_name)
                {
                    return drive;
                }
            }
            return null; // return whatewer. Also an error
        }
    }
}
