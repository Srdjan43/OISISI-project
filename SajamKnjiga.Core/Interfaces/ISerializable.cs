using System;
using System.Collections.Generic;
using System.Text;

namespace SajamKnjiga.Core.Interfaces
{
    public interface ISerializable
    {
        string[] ToCSV();

        void FromCSV(string[] values);
    }
}