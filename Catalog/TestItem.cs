using System;


namespace Catalog
{
    class TestItem
    {
        static void Main(string[] args)
        {
            Film[] films = new Film[5];
            Music[] music = new Music[5];
            ComputerProgram[] myComputerProgram = new ComputerProgram[5];

            //films[0] = new Film("Quentin Tarantino", "John Travolta", "Uma Thurman");
            Console.Read();
        }
    }

    class Item
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }

        public Item()
        {

        }

        public Item(string name, string code, string category, string size)
        {
            Name = name;
            Code = code;
            Category = category;
            Size = size;
        }
    }

    class Film : Item
    {
        public string Director { get; set; }
        public string MainActor { get; set; }
        public string MainActress { get; set; }

        public Film()
        {

        }

        public Film(string director, string mainActor, string mainActress)
        {
            Director = director;
            MainActor = mainActor;
            MainActress = mainActress;
        }

        public Film(string director, string mainActor, string mainActress, string name, string code, string category, string size)
        : base(name, code, category, size)
        {
            Director = director;
            MainActor = mainActor;
            MainActress = mainActress;
        }

        public void Play()
        {

        }

        public void RetriveInfo()
        {

        }
    }

    class Music : Item
    {
        public int Lenght { get; set; }
        public string Singer { get; set; }

        public Music()
        {

        }

        public Music(int lenght, string singer)
        {
            Singer = singer;
            Lenght = lenght;
        }

        public Music(int lenght, string singer, string name, string code, string category, string size)
        :base(name, code, category, size)
        {
            Singer = singer;
            Lenght = lenght;
        }

        public void Play()
        {

        }

        public void RetriveInfo()
        {

        }
    }

    class ComputerProgram : Item
    {

    }
}
