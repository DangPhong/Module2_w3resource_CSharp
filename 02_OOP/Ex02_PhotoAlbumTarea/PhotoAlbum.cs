using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02_PhotoAlbumTarea
{
    class PhotoAlbum
    {
        protected int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }


        public int NumberOfPages { get => numberOfPages; set => numberOfPages = value; }
    }
}
