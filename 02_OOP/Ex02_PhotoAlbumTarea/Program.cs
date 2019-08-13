using System;

namespace Ex02_PhotoAlbumTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum album1 = new PhotoAlbum();
            Console.WriteLine(album1.NumberOfPages);

            PhotoAlbum album2 = new PhotoAlbum(20);
            Console.WriteLine(album2.NumberOfPages);

            BigPhotoAlbum bigPhotoAlbum1 = new BigPhotoAlbum();
            Console.WriteLine(bigPhotoAlbum1.NumberOfPages);
        }
    }
}
