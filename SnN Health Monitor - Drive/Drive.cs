namespace Drive
{
    public class Drive
    {
        public string DriveLetter { get; private set; }

        private DriveInfo _driveinfo;

        public Drive(string driveLetter)
        {
            this.DriveLetter = driveLetter;
            _driveinfo = new(driveLetter);
        }
    }
}
