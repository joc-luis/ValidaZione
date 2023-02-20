using System.Collections.Generic;

namespace ValidaZione.Objects
{
    public class Field
    {
        public string Name { get; set; }
        public List<string> Errors { get; set; } = new List<string>();

        public Field(string name)
        {
            this.Name = name;
        }
    }
}