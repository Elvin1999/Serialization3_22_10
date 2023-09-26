﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization123
{
    [Serializable]
    public class Translator
    {
        public List<Subject>? Subjects { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Fullname => $"{Name} {Surname}";
        public Translator() {}

        public Translator(int id, string? name, string? surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            if (Subjects != null)
            {
                foreach (var item in Subjects)
                {
                    Console.WriteLine(item);
                }
            }
            return $"{Id} - {Fullname}";
        }
    }
}
