using ABP.DY.Debugging;

namespace ABP.DY
{
    public class DYConsts
    {
        public const string LocalizationSourceName = "DY";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "47799a2175c0411fb869c739497505fb";
    }
}
