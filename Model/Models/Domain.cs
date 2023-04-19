using System;

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