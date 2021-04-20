﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBlog.Lib.Model
{
    class Reference : Entry
    {
        public Language Language { get; set; }
        public string Text { get; set; }
        public List<Image> Images { get; set; }

        public Reference() : base()
        {
        }
    }
}
