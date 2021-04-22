using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBlog.Lib.Data;

namespace DevBlog.Lib.Model
{
    class Language
    {
        public string Name { get; set; }
        public List<Reference> References { get; set; } // = ReferenceRepository.GetAllEntries();
    }
}
