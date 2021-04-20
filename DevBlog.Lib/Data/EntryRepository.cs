using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewBlogDemo.Model;

namespace ReviewBlogDemo.Data
{
    public class EntryRepository : IEntryRepository
    {
        List<Entry> entries;

        public List<Entry> GetAllEntries()
        {
            return entries;
        }

        public Entry GetEntryByName(string name)
        {
            return entries.Find(e => e.Name == name);
        }

        public void CreateEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public void UpdateEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntry(Entry entry)
        {
            entries.Remove(entry);
        }
    }
}
