namespace SelfCSharp.Chap08
{
    internal class TwoFreeArray
    {
        private int[] _size;
        private int[,] _list;

        public TwoFreeArray(int size1, int size2)
        {
            this._size = new[] { size1, size2 };
            this._list = new int[size1, size2];
        }

        public int this[int index1, int index2]
        {
            set
            {
                this._list[this.GetIndex(index1, 0),
                    this.GetIndex(index2, 1)] = value;
            }

            get
            {
                return this._list[this.GetIndex(index1, 0),
                    this.GetIndex(index2, 1)];
            }
        }

        private int GetIndex(int index, int dimension)
        {
            if (index < 0)
            {
                return 0;
            }
            return index % this._size[dimension];
        }
    }

    internal class IndexerMulti
    {
        static void Main(string[] args)
        {
            var array = new TwoFreeArray(3, 2);
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[1, 0] = 3;
            array[1, 1] = 4;
            array[2, 0] = 5;
            array[2, 1] = 6;

            Console.WriteLine(array[2, 1]);
            Console.WriteLine(array[-1, 0]);
            Console.WriteLine(array[4, 0]);
        }
    }
}
