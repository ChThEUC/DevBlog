using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBlog.Lib.Model
{
    public class Entry
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
        public string Headline { get; set; }

        public Entry()
        {
            Active = true;
        }
    }
}
