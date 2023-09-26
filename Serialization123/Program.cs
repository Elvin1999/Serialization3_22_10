using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace Serialization123
{
    #region XML
    //class Car
    //{
    //    public string? Model { get; set; }
    //    public string? Vendor { get; set; }
    //    public int Year { get; set; }
    //    public override string ToString()
    //    {
    //        return $"{Model?.PadRight(15)} {Vendor} {Year}";
    //    }
    //}
    //public class Program
    //{
    //    static void Write()
    //    {
    //        List<Car> cars = new List<Car>
    //        {
    //            new Car
    //            {
    //                Model="Mustang",
    //                Vendor="Ford",
    //                Year=1964
    //            },
    //            new Car
    //            {
    //                Model="Charger",
    //                Vendor="Dodge",
    //                Year=1961
    //            },
    //            new Car
    //            {
    //                Model="Veyron",
    //                Vendor="Bugatti",
    //                Year=2020
    //            }
    //        };

    //        using (var writer = new XmlTextWriter("cars.xml", Encoding.UTF8))
    //        {
    //            writer.Formatting = Formatting.Indented;
    //            writer.WriteStartDocument();
    //            writer.WriteStartElement("Cars");

    //            foreach (var car in cars)
    //            {
    //                writer.WriteStartElement("Car");
    //                writer.WriteAttributeString(nameof(Car.Model), car.Model);
    //                writer.WriteAttributeString(nameof(Car.Vendor), car.Vendor);
    //                writer.WriteAttributeString(nameof(Car.Year), car.Year.ToString());

    //                writer.WriteEndElement();
    //            }
    //            writer.WriteEndElement();
    //            writer.WriteEndDocument();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        //Write();
    //       // Read();
    //    }

    //    private static void Read()
    //    {
    //        XmlDocument doc = new XmlDocument();
    //        doc.Load("cars.xml");
    //        var root = doc.DocumentElement;

    //        if (root.HasChildNodes)
    //        {
    //            foreach (XmlNode car_node  in root.ChildNodes)
    //            {
    //                var c = new Car
    //                {
    //                    Model = car_node.Attributes[0].Value,
    //                    Vendor = car_node.Attributes[1].Value,
    //                    Year = int.Parse(car_node.Attributes[2].Value)
    //                };
    //                Console.WriteLine(c);
    //            }
    //        }
    //    }
    //}
    #endregion

    #region XML Serialization

    class Program
    {
        static void XmlSerialize()
        {
            var army = new TranslatorArmy
            {
                Name="Step IT Academy",
                Location="Koroglu Rehimov 71",
                Translators=new List<Translator>
                {
                    new Translator(1, "Tural", "Eliyev")
                    {
                        Subjects=new List<Subject>
                        {
                            new Subject
                            {
                                Name="C++",
                                Degree=42,
                                Lessons=68
                            },
                            new Subject
                            {
                                Name="C#",
                                Degree=46,
                                Lessons=64
                            }
                        }
                    },
                    new Translator(2, "Eli", "Mammadov")
                    {
                        Subjects=new List<Subject>
                        {
                            new Subject
                            {
                                Name="Adobe Photoshop",
                                Degree=42,
                                Lessons=30
                            },
                            new Subject
                            {
                                Name="PHP",
                                Degree=42,
                                Lessons=35
                            }
                        }
                    },
                    new Translator(3, "Leyla", "Eliyeva")
                    {
                        Subjects=new List<Subject>
                        {
                            new Subject
                            {
                                Name="HTML/CSS",
                                Degree=42,
                                Lessons=30
                            },
                            new Subject
                            {
                                Name="Angular 16",
                                Degree=42,
                                Lessons=35
                            }
                        }
                    }
                }
            };


            var xml = new XmlSerializer(typeof(TranslatorArmy));
            using (var fs = new FileStream("TranslatorArmy.xml", FileMode.OpenOrCreate)) 
            {
                xml.Serialize(fs, army);
            }
        }

        static void XmlDeserialize()
        {
            TranslatorArmy army = null;
            var xml = new XmlSerializer(typeof(TranslatorArmy));
            using (var fs=new FileStream("TranslatorArmy.xml",FileMode.OpenOrCreate))
            {
                army = xml.Deserialize(fs) as TranslatorArmy;
            }
           // Console.WriteLine(army);
        }
        static void Main(string[] args)
        {
            //XmlSerialize();
            XmlDeserialize();
        }
    }

    #endregion
}