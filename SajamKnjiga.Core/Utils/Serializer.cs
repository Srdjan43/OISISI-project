using SajamKnjiga.Core.Interfaces;
using System.Text;
using System.Collections.Generic;

namespace SajamKnjiga.Core.Utils
{
    public class Serializer<T> where T : ISerializable, new()
    {
        private const char Delimiter = '|';

        public List<T> FromCSV(IEnumerable<string> lines)
        {
            List<T> objects = new List<T>();

            foreach (string line in lines)
            {
                string[] values = line.Split(Delimiter);

                T obj = new T();
                obj.FromCSV(values);

                objects.Add(obj);
            }

            return objects;
        }

        public string ToCSV(List<T> objects)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ISerializable obj in objects)
            {
                string line = string.Join(Delimiter.ToString(), obj.ToCSV());
                sb.AppendLine(line);
            }

            return sb.ToString();
        }
    }
}