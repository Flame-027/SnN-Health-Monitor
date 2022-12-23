using System.IO;

namespace Drive
{
    public class DriveInfoChecker
    {

        public int GetFreeSpace(string Driveletter)
        {
            var drive = new DriveInfo(Driveletter);
            long rawFreeSpace = 0;
            int freeSpace;

            if (drive.IsReady)
                rawFreeSpace = drive.AvailableFreeSpace;

            freeSpace = (int)rawFreeSpace / BytesToBinaryUnits._mb;
            return freeSpace;
        }


    }
}
