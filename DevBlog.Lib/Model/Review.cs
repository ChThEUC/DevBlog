using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBlog.Lib.Model
{
    class Review : Entry
    {
        public string Text { get; set; }
        public List<Image> Images { get; set; }
        public int NumberOfStars { get; set; }
        public string Link { get; set; }

        public Review() : base()
        {
        }
    }
}
