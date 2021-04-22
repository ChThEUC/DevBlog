using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBlog.Lib.Model;

namespace DevBlog.Lib.Data
{
    public interface IMaintainable<T>
    {
        List<T> GetAllEntries();
        T GetEntryByName(string name);
        void CreateEntry(T entry);
        void UpdateEntry(T entry);
        void DeleteEntry(ref T entry);
    }
}
