using System.IO;

namespace Drive
{
    public class DriveInfoChecker
    {
        public static long GetFreeSpace(string driveLetter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);
            
            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long freeSpace = BytesToBinaryUnits.Convert(drive.TotalFreeSpace, new string("MB"));
            return freeSpace;
        }

        public static long GetFreeSpace(string driveLetter, string unitOut)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long freeSpace = BytesToBinaryUnits.Convert(drive.TotalFreeSpace, unitOut);
            return freeSpace;
        }

        public static long GetAvailableSpace(string driveLetter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);
            
            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long availableSpace = BytesToBinaryUnits.Convert(drive.AvailableFreeSpace, new string("MB"));
            return availableSpace;
        }

        public static long GetAvailableSpace(string driveLetter, string unitOut)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long availableSpace = BytesToBinaryUnits.Convert(drive.AvailableFreeSpace, unitOut);
            return availableSpace;
        }
    }
}
