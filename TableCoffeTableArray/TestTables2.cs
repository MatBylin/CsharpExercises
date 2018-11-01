using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables2
{
    class TestTables
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            Table[] arrayTable = new Table[5];
            for (int i = 0; i < arrayTable.Length; i++)
            {
                arrayTable[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                Console.WriteLine(arrayTable[i].ShowData());
            }

            CoffeTable[] arrayCoffeTable = new CoffeTable[5];
            for (int i = 0; i < arrayCoffeTable.Length; i++)
            {
                arrayCoffeTable[i] = new CoffeTable(rnd.Next(40, 121), rnd.Next(40, 121));
                Console.WriteLine(arrayCoffeTable[i].ShowData());
            }

            Console.Read();
        }
    }

    class Table
    {
        protected int width, height;

        public Table()
        {

        }

        public Table(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public virtual string ShowData()
        {
            return "The width is: " + width + " and the height is: " + height ;
        }
    }

    class CoffeTable : Table
    {
        public CoffeTable(int width, int height) : base(width, height)
        {

        }

        public override string ShowData()
        {
            return "CoffeTable " + base.ShowData();
        }
    }
}
