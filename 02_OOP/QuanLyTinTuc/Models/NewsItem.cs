using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTinTuc.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AverageRate { get; set; }
    }
}
