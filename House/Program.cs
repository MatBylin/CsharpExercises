using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallApartment = new SmallApartment();
            var person = new Person();

            person.Name = "Matt";
            person.House = smallApartment;
            person.ShowData();

            Console.Read();
        }
    }
    
    class House
    {
        protected int area;
        protected Door door;

        public House(int area)
        {
            this.area = area;
            door = new Door();
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public Door Door
        {
            get { return door; }
            set { door = value; }
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Iam a house, my area is: {0}", area);
        }
    }

    class Door
    {
        protected string color;

        public Door()
        {
            color = "Brown";
        }

        public Door(string color)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is: {0}", color);
        }
    }

    class SmallApartment : House
    {
        public SmallApartment() : base(50)
        {

        }

        public override void ShowData()
        {
            Console.WriteLine("Iam an apartment, my area is {0} m2", area);
        }
    }

    class Person
    {
        protected string name;
        protected House house;

        public Person()
        {
            name = "mateusz";
            house = new House(666);
        }

        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public House House
        {
            get { return house; }
            set { house = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("Name:{0} ", name);
            house.ShowData();
            house.Door.ShowData();
        }
    }
}
