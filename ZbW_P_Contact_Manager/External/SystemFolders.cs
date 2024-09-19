using System.Runtime.InteropServices;

namespace External
{
    /// <summary>
    /// Class to manage the system folders
    /// </summary>
    public static class SystemFolders
    {
        /// <summary>
        /// Enum to represent the known folders
        /// </summary>
        public enum Folder
        {
            Contacts,
            Downloads,
            Favorites,
            Links,
            SavedGames,
            SavedSearches

        }

        /// <summary>
        /// Dictionary to map the known folders to their GUIDs
        /// </summary>
        private static readonly Dictionary<Folder, Guid> _guids = new()
        {
            [Folder.Contacts] = new("56784854-C6CB-462B-8169-88E350ACB882"),
            [Folder.Downloads] = new("374DE290-123F-4565-9164-39C4925E467B"),
            [Folder.Favorites] = new("1777F761-68AD-4D8A-87BD-30B759FA33DD"),
            [Folder.Links] = new("BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968"),
            [Folder.SavedGames] = new("4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4"),
            [Folder.SavedSearches] = new("7D1D3A04-DEBB-4115-95CF-2F29DA2920DA")
        };

        /// <summary>
        /// Gets the path of a known folder
        /// </summary>
        /// <param name="knownFolder"></param>
        /// <returns>KnownFolderPath</returns>
        public static string GetPath(Folder knownFolder)
        {
            return SHGetKnownFolderPath(_guids[knownFolder], 0);
        }

        /// <summary>
        /// Gets the path of a known folder
        /// </summary>
        /// <param name="rfid"></param>
        /// <param name="dwFlags"></param>
        /// <param name="hToken"></param>
        /// <returns>KnownFolderPath</returns>
        [DllImport("shell32", CharSet = CharSet.Unicode, ExactSpelling = true, PreserveSig = false)]
        private static extern string SHGetKnownFolderPath(
            [MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags,
            nint hToken = 0);
    }
}
