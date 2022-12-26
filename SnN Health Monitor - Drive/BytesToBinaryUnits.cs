
namespace Drive
{
    public static class BytesToBinaryUnits
    {
        private static readonly Dictionary<string, long> _unitsHashTable = new()
        {
            { "KB", 1024 },
            { "MB", 1048576 },
            { "GB", 1073741824 },
            { "TB", 1099511627776 }
        };

        public static long Convert(long inputBytes, string unitOut)
        {
            if (!_unitsHashTable.ContainsKey(unitOut))
                throw new InvalidOperationException("The unit parameter is incorrect");

            return inputBytes / _unitsHashTable[unitOut];
        }

        public static float GetUnitInBytes(string unit)
        {
            if (!_unitsHashTable.ContainsKey(unit))
               throw new InvalidOperationException("The unit parameter is incorrect");

            return _unitsHashTable[unit];
        }
    }
}
