using System.Collections.Generic;
using Task1.Extractor.Dtos;

namespace Task1.Extractor.Interfaces
{
    public interface IExtractor
    {
        IEnumerable<PersonDto> Extract(string path);
    }
}
