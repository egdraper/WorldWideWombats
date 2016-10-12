using System.Collections.Generic;

namespace WorldWideWombats
{
    /// <summary>
    /// Interface for File Access stream.
    /// </summary>
    public interface IFileAccess
    {
        SortedDictionary<uint, Employee> EmployeeDB { get; set; }

        void WriteFileDB();
        void ReadFileDB();
        void OpenFileDB();
        void CloseFileDB();
    }
}
