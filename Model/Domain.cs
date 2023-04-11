using System;
using System.Reflection.Metadata;

namespace Model
{
    [Serializable]
    public class Domain
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}