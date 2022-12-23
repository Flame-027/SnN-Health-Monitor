using System.IO;

namespace Drive
{
    public class DriveInfoChecker
    {

        public int GetFreeSpace(string Driveletter)
        {
            var drive = new DriveInfo(Driveletter);
            long freeSpace;

            if (!drive.IsReady) 
                throw new InvalidOperationException();

            freeSpace = drive.AvailableFreeSpace / BytesToBinaryUnits._mb;
            return (int)freeSpace;
        }


    }
}
