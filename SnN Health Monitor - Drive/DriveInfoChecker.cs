using System.IO;

namespace Drive
{
    public class DriveInfoChecker
    {

        public long GetFreeSpace(string Driveletter)
        {
            var drive = new DriveInfo(Driveletter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long freeSpace = BytesToBinaryUnits.Convert(drive.AvailableFreeSpace, new string("MB"));
            return freeSpace;
        }

        public long GetFreeSpace(string Driveletter, string unitOut)
        {
            var drive = new DriveInfo(Driveletter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long freeSpace = BytesToBinaryUnits.Convert(drive.AvailableFreeSpace, unitOut);
            return freeSpace;
        }
    }
}
