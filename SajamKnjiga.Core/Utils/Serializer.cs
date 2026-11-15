using SajamKnjiga.Core.Interfaces;

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

        public List<string> ToCSV(List<T> objects)
        {
            List<string> lines = new List<string>();

            foreach (T obj in objects)
            {
                string[] values = obj.ToCSV();
                string line = string.Join(Delimiter, values);

                lines.Add(line);
            }

            return lines;
        }
    }
}