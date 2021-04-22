using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBlog.Lib.Model;

namespace DevBlog.Lib.Data
{
    class ReferenceRepository : EntryRepository, IMaintainable<Reference>
    {
        public void CreateEntry(Reference entry)
        {
            // Should references be added to the relevant Language class like this?
            // Language lang = entry.Language;
            // lang.References.Add(entry);

            entries.Add(entry);
        }

        public void DeleteEntry(ref Reference entry)
        {
            entry.Active = false;
        }

        public List<Reference> GetAllEntries()
        {
            throw new NotImplementedException();
        }

        public Reference GetEntryByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntry(Reference entry)
        {
            throw new NotImplementedException();
        }
    }
}
