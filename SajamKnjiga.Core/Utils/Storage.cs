using SajamKnjiga.Core.Interfaces;
using SajamKnjiga.Core.Utils;
using System.IO;
using System.Collections.Generic;

namespace SajamKnjiga.Core.Utils
{
    public class Storage<T> where T : ISerializable, new()
    {
        private readonly string _fileName;
        private readonly Serializer<T> _serializer = new Serializer<T>();

        public Storage(string fileName)
        {
            _fileName = fileName;
        }
        public List<T> Load()
        {
            if (!File.Exists(_fileName))
            {
                return new List<T>();
            }

            string[] lines = File.ReadAllLines(_fileName);

            return _serializer.FromCSV(lines);
        }

        public void Save(List<T> objects)
        {
            string content = _serializer.ToCSV(objects);

            File.WriteAllText(_fileName, content);
        }
    }
}