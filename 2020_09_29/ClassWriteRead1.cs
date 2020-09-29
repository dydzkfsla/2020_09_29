using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_29
{
    class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

        public Person(string name, string phone, int age)
        {
            Name = name; Phone = phone; Age = age;
        }

        public override string ToString()
        {
            //return $"Name:{Name} Phone:{Phone} Age:{Age}";
            return $"{Name}|{Phone}|{Age}";
        }
    }

    class ClassWriteRead1
    {
        static void Main()
        {
            Person p1 = new Person("김연아", "010-1111", 30);
            Person p2 = new Person("류현진", "010-2222", 35);

            Console.WriteLine(p1);
            Console.WriteLine(p2.ToString());

            using (StreamWriter sw = new StreamWriter("PersonInfo.txt", false, Encoding.Default))
            {
                sw.WriteLine(p1.ToString());
                sw.WriteLine(p2.ToString());
                sw.Flush();
            }

            Console.WriteLine("저장이 완료되었습니다.");
            using (StreamReader sr = new StreamReader("PersonInfo.txt", Encoding.Default))
            {
                string person ;
                while((person = sr.ReadLine()) != null)
                {
                    string[] per = person.Split('|');
                    Console.WriteLine(person);
                    if (per.Length == 3)
                    {
                        Person per1 = new Person(per[0], per[1], int.Parse(per[2]));
                        Console.WriteLine(per1.Name);
                    }
                }
            }

            Console.WriteLine("읽기 완료 되었습니다.");
        }
    }
}
