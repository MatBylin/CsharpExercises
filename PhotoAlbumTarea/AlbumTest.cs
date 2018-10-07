using System;

namespace PhotoAlbumTarea
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            //first album
            var album1 = new PhotoAlbum();
            Console.WriteLine(album1.GetNumberOfPages());

            //second album
            var album2 = new PhotoAlbum(24);
            Console.WriteLine(album2.GetNumberOfPages());

            //third album
            var bigAlbum = new BigPhotoAlbum();
            Console.WriteLine(bigAlbum.GetNumberOfPages());

            Console.Read();
        }
    }

    class PhotoAlbum
    {
        protected int numberOfPages;

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }
    }

    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
    }
}
