
namespace Drive
{
    public static class BytesToBinaryUnits
    {
        private static readonly long[] _unitsArray = 
        {
            1024,
            1048576,                            
            1073741824,
            1099511627776
        };

        // this list gets indexed by an enum as some values are too large for it to hold.

        public static long Convert(long inputBytes, BinaryUnitsCode unitOut)
        {
            if (inputBytes <= 0)
                throw new InvalidOperationException("The inputedBytes paramter is not valid");

            return inputBytes / _unitsArray[(byte)unitOut];
        }

        public static float GetUnitInBytes(BinaryUnitsCode unit)
        {
            return _unitsArray[(byte)unit];
        }
    }
}
