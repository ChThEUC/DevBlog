using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewBlogDemo.Model;

namespace ReviewBlogDemo.Data
{
    public interface IEntryRepository
    {
        List<Entry> GetAllEntries();
        Entry GetEntryByName(string name);
        void CreateEntry(Entry entry);
        void UpdateEntry(Entry entry);
        void DeleteEntry(Entry entry);
    }
}
