using SQLite;

namespace Ohis.DataContext
{
    public static class Constants
    {
        public const string DatabaseFilename = "ohis.db3";

        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public const string PostServer = "smtp.gmail.com";

        public static string DatabasePath()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);

            return Path.Join(path, DatabaseFilename);
        }
    }
}
