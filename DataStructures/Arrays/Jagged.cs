
namespace CS.DataStructures.Arrays
{
    /// <summary>
    /// A jagged array is an array whose elements are arrays. The elements of a jagged array can be of different dimensions and sizes.
    /// Because a jagged array can have arrays of different dimensions and sizes it is called "jagged"
    /// 
    /// array[1,3]
    /// 
    /// array[0,0] = new array[2]
    /// array[0,1] = new array[5]
    /// array[0,2] = new array[3]
    /// 
    /// visual representation:
    /// ======================
    /// xx
    /// xxxxx (arrays are jagged in shape)
    /// xxx
    /// </summary>
    internal class Jagged
    {
        public Jagged()
        {
            Hydrate();
        }

        /// <summary>
        /// 1 dimensional array of 1 dimensional arrays of varying sizes (hence the word "jagged")
        /// </summary>
        /// <value>The arr.</value>
        public int[][] Arr { get; set; }

        /// <summary>
        /// 1 dimensional array of multi dimensional array (2 dimensions) of varrying sizes (hence the word "jagged")
        /// </summary>
        /// <value>The arr multi dim.</value>
        public int[][,] ArrMultiDim { get; set; } 

        public void Hydrate()
        {
            // 1 dimensional array of 1 dimensional arrays of varying sizes (hence the word "jagged")
            Arr = new int[3][];

            Arr[0] = new int[] 
            {
                1, // <-- [0][0]
                3, // <-- [0][1]
                5, // <-- [0][2]
                7, // <-- [0][3]
                9  // <-- [0][4]
            };

            Arr[1] = new int[] 
            {
                0, // <-- [1][0]
                2, // <-- [1][1]
                4, // <-- [1][2]
                6  // <-- [1][3]
            };

            Arr[2] = new int[] 
            {
                11, // <-- [2][0]
                22  // <-- [2][1]
            };

            // 1 dimensional array of multi dimensional array (2 dimensions) of varrying sizes (hence the word "jagged")
            ArrMultiDim = new int[3][,];

            ArrMultiDim[0] = new int[,]
            {           // 1st dimension [0] (outer array)
                {       // 1st dimension [0][0]
                        // 2nd dimension [0][0,x]
                    1,  // <-- [0][0,0]
                    3   // <-- [0][0,1]
                },
                {       // 1st dimension [0][1]
                        // 2nd dimension [0][1,x]
                    5,  // <-- [0][1,0]
                    7   // <-- [0][1,2]
                }
            };

            ArrMultiDim[1] = new int[,]
            {           // 1st dimension [1] (outer array)
                {       // 1st dimension [1][0]
                        // 2nd dimension [1][0,x]
                    0,  // <-- [1][0,0]
                    2   // <-- [1][0,1]
                },
                {       // 1st dimension [1][1]
                        // 2nd dimension [1][1,x]
                    4,  // <-- [0][1,0]
                    6   // <-- [0][1,2]
                },
                {       // 1st dimension [1][2]
                        // 2nd dimension [1][2,x]
                    8,  // <-- [1][2,0]
                    10  // <-- [1][2,1]
                }
            };

            ArrMultiDim[2] = new int[,]
            {           // 1st dimension [2] (outer array)
                 {      // 1st dimension [2][0]
                        // 2nd dimension [2][0,x]
                    11, // <-- [2][0,0]
                    22  // <-- [2][0,1]
                },
                {       // 1st dimension [2][1]
                        // 2nd dimension [2][1,x]
                    99, // <-- [2][1,0]
                    88  // <-- [2][1,2]
                },
                {       // 1st dimension [2][2]
                        // 2nd dimension [2][2,x]
                    0,  // <-- [2][2,0]
                    9   // <-- [2][2,1]
                }
            };
        }
    }
}
