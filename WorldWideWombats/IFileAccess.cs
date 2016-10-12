using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldWideWombats
{
    public interface IFileAccess
    {
        void WriteFileDB(SortedDictionary<uint, Employee> employeeDb);
        SortedDictionary<uint, Employee> ReadFileDB();
        void OpenFileDB();
        void CloseFileDB();
        
    }
}
