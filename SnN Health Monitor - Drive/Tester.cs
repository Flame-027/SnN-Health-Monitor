namespace Drive
{
    class Tester
    {
        static void Main()
        {
          var driveChecker = new DriveInfoChecker(new DriveInfo("C"));
          Console.WriteLine(driveChecker.GetAvailableSpace(BinaryUnitsCode.GB));
          Console.WriteLine(driveChecker.GetFreeSpacePercentage());
        }

    }
}
