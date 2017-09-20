using CS.Algorithms;

namespace CS
{
    internal static class CS
    {
        public static AlgorithmsSrv Algorithms { get; set; }

        static CS()
        {
            Algorithms = new AlgorithmsSrv();
        }
    }
}
