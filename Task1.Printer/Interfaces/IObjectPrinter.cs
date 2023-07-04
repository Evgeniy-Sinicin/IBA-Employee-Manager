using System.Collections.Generic;

namespace Task1.Printer.Interfaces
{
    public interface IObjectPrinter
    {
        void PrintObjects<T>(string path, IEnumerable<T> objects);
    }
}
