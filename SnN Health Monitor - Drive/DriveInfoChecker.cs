using System.IO;

namespace Drive
{
    public class DriveInfoChecker
    {
        private readonly DriveInfo _drive;

        public DriveInfoChecker(DriveInfo drive)
        {
            _drive = drive;
        }

        public long GetFreeSpace()
        {
            // Add validation for drive letter later
            
            if (!_drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            return _drive.TotalFreeSpace;
        }
        public long GetFreeSpace(BinaryUnitsCode unitOut)
        {
            // Add validation for drive letter later

            if (!_drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long freeSpace = BytesToBinaryUnits.Convert(_drive.TotalFreeSpace, unitOut);
            return freeSpace;
        }
        public static long GetFreeSpace(string driveLetter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);
            
            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            return drive.TotalFreeSpace;
        }
        public static long GetFreeSpace(string driveLetter, BinaryUnitsCode unitOut)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long freeSpace = BytesToBinaryUnits.Convert(drive.TotalFreeSpace, unitOut);
            return freeSpace;
        }

        public static byte GetFreeSpacePercentage (string driveLetter)
        {
            // Add validation for drive letter later
            
            long freeSpace = GetFreeSpace(driveLetter);
            long totalSpace = GetTotalSpace(driveLetter);

            double totalPercentage = (freeSpace / totalSpace) * 100;
            totalPercentage = Math.Round(totalPercentage, 0, MidpointRounding.AwayFromZero);

            return (byte)totalPercentage;
        }

        public  long GetAvailableSpace()
        {
            // Add validation for drive letter later
            
            if (!_drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            return _drive.AvailableFreeSpace;
        }
        public long GetAvailableSpace(BinaryUnitsCode unitOut)
        {
            // Add validation for drive letter later

            if (!_drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long availableSpace = BytesToBinaryUnits.Convert(_drive.AvailableFreeSpace, unitOut);
            return availableSpace;
        }
        public static long GetAvailableSpace(string driveLetter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);
            
            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            return drive.AvailableFreeSpace;
        }
        public static long GetAvailableSpace(string driveLetter, BinaryUnitsCode unitOut)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long availableSpace = BytesToBinaryUnits.Convert(drive.AvailableFreeSpace, unitOut);
            return availableSpace;
        }
       
        public long GetTotalSpace()
        {
            // Add validation for drive letter later
            
            if (!_drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            return _drive.TotalSize;
        }
        public long GetTotalSpace(BinaryUnitsCode unitOut)
        {
            // Add validation for drive letter later

            if (!_drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long totalSize = BytesToBinaryUnits.Convert(_drive.TotalSize, unitOut);
            return totalSize;
        }
        public static long GetTotalSpace(string driveLetter)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);
            
            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            return drive.TotalSize;
        }
        public static long GetTotalSpace(string driveLetter, BinaryUnitsCode unitOut)
        {
            // Add validation for drive letter later

            var drive = new DriveInfo(driveLetter);

            if (!drive.IsReady) 
                throw new InvalidOperationException("The Drive is not ready or available");

            long totalSize = BytesToBinaryUnits.Convert(drive.TotalSize, unitOut);
            return totalSize;
        }
       
    }
}
