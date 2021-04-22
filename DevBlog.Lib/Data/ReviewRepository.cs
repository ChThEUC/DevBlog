using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBlog.Lib.Model;

namespace DevBlog.Lib.Data
{
    class ReviewRepository : IMaintainable<Review>
    {
        public void CreateEntry(Review entry)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntry(ref Review entry)
        {
            entry.Active = false;
        }

        public List<Review> GetAllEntries()
        {
            throw new NotImplementedException();
        }

        public Review GetEntryByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntry(Review entry)
        {
            throw new NotImplementedException();
        }
    }
}
