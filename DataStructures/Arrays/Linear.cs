
namespace CS.DataStructures.Arrays
{
    /// <summary>
    /// One dimensional array
    /// 
    /// Array brackets [x] is called the rank
    /// rank - "number of dimensions"; thus, a two-dimensional array has rank two, a three-dimensional array 
    /// has rank three and so on
    /// </summary>
    internal class Linear
    {
        public Linear()
        {
            Hydrate();
        }

        public int[] OneDim { get; set; }

        private void Hydrate()
        {
            // 3 element zero index 1 dimensional array
            OneDim = new int[]
            {
                1,
                2,
                3
            };
        }
    }
}
