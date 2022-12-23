
namespace Drive
{
    public static class BytesToBinaryUnits
    {
        private static readonly Dictionary<string, long> _unitsHashtable = new()
        {
            { "KB", 1024 },
            { "MB", 1048576 },
            { "GB", 1073741824 },
            { "TB", 1099511627776 }
        };

        public static long Convert(long inputBytes, string unitOut)
        {
            if (!_unitsHashtable.ContainsKey(unitOut))
                throw new InvalidOperationException("The unit parameter is incorrect");

            return inputBytes / _unitsHashtable[unitOut];
        }
    }
}
