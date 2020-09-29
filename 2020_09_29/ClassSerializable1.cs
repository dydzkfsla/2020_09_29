using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_29
{
    [Serializable]
    class PersonS
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public PersonS(string name, string phone, int age)
        {
            Name = name; Phone = phone; Age = age;
        }

        public override string ToString()
        {
            //return $"Name:{Name} Phone:{Phone} Age:{Age}";
            return $"{Name}|{Phone}|{Age}";
        }
    }

    class ClassSerializable1
    {
        static void Main()
        {
            PersonS p1 = new PersonS("김연아", "010-1111", 30);

            BinaryFormatter serializer = new BinaryFormatter();
            FileStream fs = new FileStream("a.dat",FileMode.OpenOrCreate);
            serializer.Serialize(fs, p1);

            Console.WriteLine("객체 직렬화 성공");
            fs.Close();

            FileStream rs = new FileStream("a.dat", FileMode.Open);
            PersonS p2 = (PersonS)serializer.Deserialize(rs);
            rs.Close();
            Console.WriteLine("객체 역 직렬화 성공");

            Console.WriteLine(p2.ToString());


        }
    }
}
