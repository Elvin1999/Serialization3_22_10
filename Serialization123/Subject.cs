using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization123
{
    public class Subject
    {
        [XmlAttribute]
        public string? Name { get; set; }
        [XmlAttribute]
        public int Degree { get; set; }
        [XmlAttribute]
        public int Lessons { get; set; }
        public Subject()
        {

        }
        public override string ToString()
        {
            return $"{Name} - {Degree} - {Lessons}";
        }
    }
}
