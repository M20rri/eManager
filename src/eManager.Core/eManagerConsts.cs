using eManager.Debugging;

namespace eManager
{
    public class eManagerConsts
    {
        public const string LocalizationSourceName = "eManager";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "55683b8c3e70458ba11beb9297f585d6";
    }
}
