
namespace CS.DataStructures.Arrays
{
    /// <summary>
    /// multi dimensional arrays
    /// 
    /// Array brackets [x] is called the rank
    /// rank - "number of dimensions"; thus, a two-dimensional array has rank two, a three-dimensional array 
    /// has rank three and so on
    /// 
    /// The Rank property of a jagged array is always 1, but a multidimensional array can have any rank. 
    /// 
    /// A multidimensional array is laid out linearly in memory, the actual value is found by multiplying together the indexes
    /// and are (n-1)-dimension matrices
    /// </summary>
    internal class MultiDim
    {
        public MultiDim()
        {
            hydrate();
        }

        public int[,] TwoDim { get; set; }
        public int[,,] ThreeDim { get; set; }
        public int[,,,] FourDim { get; set; }

        private void hydrate()
        {
            // 2 dimension zero index array
            TwoDim = new int[2, 3]
            {
                {       // <-- 1st dimension [0] 
                        // <-- 2nd dimension [0,x] (x is 1 dimensional 3 element array)
                    1,  // <-- [0,0]
                    2,  // <-- [0,1]
                    3   // <-- [0,2] 
                },
                {       // <-- 1st dimension [1] 
                        // <-- 2nd dimension [1,x] (x is 1 dimensional 3 element array)
                    4,  // <-- [1,0]
                    5,  // <-- [1,1]
                    6   // <-- [1,2]
                }
            };

            // 3 dimension zero index array
            ThreeDim = new int[2, 2, 3] 
            {
                {           // <-- 1st dimension [0]
                    {       // <-- 2nd dimension [0,0]
                            // <-- 3rd dimension [0,0,x] (x is 1 dimensional 3 element array)
                        1,  // <-- [0,0,0]
                        2,  // <-- [0,0,1]
                        3   // <-- [0,0,2]
                    },
                    {       // <-- 2nd dimension [0,1] 
                            // <-- 3rd dimension [0,1,x] (x is 1 dimensional 3 element array)
                        4,  // <-- [0,1,0]
                        5,  // <-- [0,1,1]
                        6   // <-- [0,1,2]
                    } 
                },
                {           // <-- 1st dimension [1]
                    {       // <-- 2nd dimension [1,0] 
                            // <-- 3rd dimension [1,0,x] (x is 1 dimensional 3 element array)
                        7,  // <-- [1,0,0]
                        8,  // <-- [1,0,1]
                        9   // <-- [1,0,2]
                    },
                    {       // <-- 2nd dimension [1,1] 
                            // <-- 3rd dimension [1,1,x] (x is 1 dimensional 3 element array)
                        10, // <-- [1,1,0]
                        11, // <-- [1,1,1]
                        12  // <-- [1,1,2]
                    }
                }
            };

            // 4 dimension zero index array
            FourDim = new int[2, 2, 2, 3]
            {
                {               // <-- 1st dimension [0]
                    {           // <-- 2nd dimension [0,0]
                        {       // <-- 3rd dimension [0,0,0] 
                                // <-- 4th dimension [0,0,0,x] (x is 1 dimensional 3 element array)
                            1,  // <-- [0,0,0,0]
                            2,  // <-- [0,0,0,1]
                            3   // <-- [0,0,0,2] 
                        },
                        {       // <-- 3rd dimension [0,0,1] 
                                // <-- 4th dimension [0,0,1,x] (x is 1 dimensional 3 element array)
                            4,  // <-- [0,0,1,0]
                            5,  // <-- [0,0,1,1]
                            6   // <-- [0,0,1,2]
                        }
                    },
                    {           // <-- 2nd dimension [0,1]             
                        {       // <-- 3rd dimension [0,1,0]
                                // <-- 4th dimension [0,1,0,x] (x is 1 dimensional 3 element array)
                            7,  // <-- [0,1,0,0]
                            8,  // <-- [0,1,0,1]
                            9   // <-- [0,1,0,2]
                        },
                        {       // <-- 3rd dimension [0,1,1]
                                // <-- 4th dimension [0,1,1,x] (x is 1 dimensional 3 element array)
                            10, // <-- [0,1,1,0]
                            11, // <-- [0,1,1,1]
                            12  // <-- [0,1,1,2]
                        }
                    }
                },
                {               // <-- 1st dimension [1]
                    {           // <-- 2nd dimension [1,0]
                        {       // <-- 3rd dimension [1,0,0]
                                // <-- 4th dimension [1,0,0,x] (x is 1 dimensional 3 element array)
                            13, // <-- [1,0,0,0]
                            14, // <-- [1,0,0,1]
                            15  // <-- [1,0,0,2]
                        },
                        {       // <-- 3rd dimension [1,0,1]
                                // <-- 4th dimension [1,0,1,x] (x is 1 dimensional 3 element array)
                            16, // <-- [1,0,1,0]
                            17, // <-- [1,0,1,1]
                            18  // <-- [1,0,1,2]

                        }  
                    },
                    {           // <-- 2nd dimension [1,1]
                        {       // <-- 3rd dimension [1,1,0]
                                // <-- 4th dimension [1,1,0,x] (x is 1 dimensional 3 element array)
                            19, // <-- [1,1,0,0]
                            20, // <-- [1,1,0,1]    
                            21  // <-- [1,1,0,2]
                        },
                        {       // <-- 3rd dimension [1,1,1]
                                // <-- 4th dimension [1,1,1,x] (x is 1 dimensional 3 element array)
                            22, // <-- [1,1,1,0]
                            23, // <-- [1,1,1,1]
                            24  // <-- [1,1,1,2]
                        }
                    }
                }
            };
        }
    }
}