
namespace CS
{
    internal static class Main
    {
        internal static class Services
        {
            public static CS.Services.Algorithm Algorithm { get; set; }
            public static CS.Services.Architecture Architecture { get; set; }
            public static CS.Services.DataStructures DataStructure { get; set; }
            public static CS.Services.Concepts Concept { get; set; }
            public static CS.Services.Patterns Pattern { get; set; }

            static Services()
            {
                Algorithm = new CS.Services.Algorithm();
                Architecture = new CS.Services.Architecture();
                Concept = new CS.Services.Concepts();
                Pattern = new CS.Services.Patterns();
            }
        }
    }
}
