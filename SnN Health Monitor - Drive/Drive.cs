namespace Drive
{
    public class Drive
    {
        public string DriveLetter { get; private set; }

        public Drive(string driveLetter)
        {
            this.DriveLetter = driveLetter;
        }
    }
}
