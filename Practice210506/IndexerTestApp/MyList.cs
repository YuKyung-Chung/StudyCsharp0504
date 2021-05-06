using System;

namespace IndexerTestApp
{
    class MyList
    {
        
        private int[] array;

        public int this[int index] //== MyList[i] == array[i]
        {
            get 
            {
                return array[index]; 
            }

            set
            {
                if (index >= array.Length) //하나씩 증가
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; } // 3
        }

        public MyList()
        {
            array = new int[3]; // 0, 1, 2
        }
    }
}
