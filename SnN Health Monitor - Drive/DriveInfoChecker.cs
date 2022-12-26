using System.IO;

namespace Drive
{
    public class DriveInfoChecker
    {
        public static long GetFreeSpace(string Driveletter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(Driveletter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long freeSpace = BytesToBinaryUnits.Convert(drive.AvailableFreeSpace, new string("MB"));
            return freeSpace;
        }

        public static long GetFreeSpace(string Driveletter, string unitOut)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(Driveletter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long freeSpace = BytesToBinaryUnits.Convert(drive.AvailableFreeSpace, unitOut);
            return freeSpace;
        }
    }
}
