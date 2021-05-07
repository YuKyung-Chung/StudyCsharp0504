using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace IndexerTestApp
{
    class MyList : IEnumerable, IEnumerator
    {
        
        private int[] array;
        private int position = -1; //배열의 현재 위치값 (0부터 시작하므로 초기값 -1로 시작)

        // 배열화 (배열이 아닌 MyList를 배열처럼 만들어주는 프로퍼티)
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

        // IEnumerator
        public object Current
        {
            get { return array[position]; } // 현재값 foreach에만 필요
        }

        public MyList()
        {
            array = new int[3]; // 0, 1, 2
        }

        // IEnumerable 메소드
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        // IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }
        // IEnumerator
        public void Reset()
        {
            position = -1; // 초기화
        }
    }
}
