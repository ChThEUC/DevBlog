﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBlog.Lib.Model;

namespace DevBlog.Lib.Data
{
    class BlogPostRepository : EntryRepository, IMaintainable<BlogPost>
    {
        // Identical to method in base class; inheritable? Add BlogPost-specifics to method?
        public void CreateEntry(BlogPost entry)
        {
            entries.Add(entry);
        }

        // Identical to method in base class; inheritable?
        public void DeleteEntry(ref BlogPost entry)
        {
            entry.Active = false;
        }

        public List<BlogPost> GetAllEntries()
        {
            throw new NotImplementedException();
        }

        public BlogPost GetEntryByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntry(BlogPost entry)
        {
            throw new NotImplementedException();
        }
    }
}
