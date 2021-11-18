using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> pks19 = new List<Student>();
            pks19.Add(new Student("Vasya", 13, "М"));
            pks19.Add(new Student("Sveta", 14, "Ж"));
            pks19.Add(new Student("Petya", 15, "М"));
            pks19.Add(new Student("Pasha", 16, "М"));

            Group Pks19grp = new Group("PKS-19", pks19, "PKS", "Gladkova E. M");
            Pks19grp.GroupInfo();

            List<Student> isp18 = new List<Student>();
            isp18.Add(new Student("Vera", 17, "Ж"));
            isp18.Add(new Student("Lera", 18, "Ж"));
            isp18.Add(new Student("Dima", 19, "М"));
            isp18.Add(new Student("Katya", 20, "Ж"));
            isp18.Add(new Student("Vova", 21, "М"));

            Group Isp18grp = new Group("ISP-18", isp18, "ISP", "Umnova T. V");
            Isp18grp.GroupInfo();

            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("group.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, pks19);
            }

            var soapFormatter = new SoapFormatter();
            using (var file = new FileStream("group.bin", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(file, Pks19grp.GroupList.ToArray());
            }

            var xmlFormatter = new XmlSerializer(typeof(List<Student>));
            using (var file = new FileStream("group.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(file, pks19);
            }

            var jsonFormatter = new DataContractJsonSerializer(typeof(Student[]));
            using (var file = new FileStream("group.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, pks19.ToArray());
            }

                Console.ReadKey();
        }
    }
}
