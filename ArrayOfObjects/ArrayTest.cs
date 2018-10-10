using System;

namespace ArrayOfObjects
{
    class ArrayTest
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Table[] arrayTable = new Table[10];

            for (int i = 0; i < arrayTable.Length; i++)
            {
                arrayTable[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                arrayTable[i].ShowData();
            }

            Console.Read();
        }
    }
    class Table
    {
        private int _width, _height;

        public Table(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void ShowData()
        {
            Console.WriteLine("The width is: {0} and the height is: {1}", _width, _height);
        }
    }
}