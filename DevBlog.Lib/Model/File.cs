using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBlog.Lib.Model
{
    class File
    {
        public string Name { get; set; }
        public Language Language { get; set; }
        public string MD5 { get; set; }
        public string Path { get; set; }
    }
}
