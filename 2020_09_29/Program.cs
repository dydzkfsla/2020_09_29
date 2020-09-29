using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
    class Program
    {
        public class Random2 : Random
        {
            public Random2() : base()
            { }

            public Random2(int seed) : base(seed)
            { }

            public void NextBytes(byte[] bytes, byte minValue, byte maxValue)
            {
                for (int ctr = bytes.GetLowerBound(0); ctr <= bytes.GetUpperBound(0); ctr++)
                {
                    bytes[ctr] = (byte)Next(minValue, maxValue);
                    if (bytes[ctr] >= 58 &&  bytes[ctr] <= 64)
                    {
                        ctr--;
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            string a = "abcdefghijklmnopqrstuvwsyz123456789";
            //string s = " Hello, World! ";
            //string t;

            //Console.WriteLine(s.Length);//14
            //Console.WriteLine(s[8]);    //" "

            //Console.WriteLine(s.Insert(8, "C# "));//" Hello, C#World! "
            //Console.WriteLine(s.PadLeft(20, '.'));".... //"
            //Console.WriteLine(s.PadRight(20, '.'));"// ..."
            //Console.WriteLine(s.Remove(6));" Hell"
            //Console.WriteLine(s.Remove(6, 7));" Hellld! "
            //Console.WriteLine(s.Replace('l', 'm'));
            //Console.WriteLine(s.ToLower());
            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine('/' + s.Trim() + '/');
            //Console.WriteLine('/' + s.TrimStart() + '/');
            //Console.WriteLine('/' + s.TrimEnd() + '/');

            //string[] a = s.Split(',');
            //foreach (var i in a)
            //    Console.WriteLine('/' + i + '/');

            //char[] destination = new char[10];
            //s.CopyTo(8, destination, 0, 6);
            //Console.WriteLine(destination);

            //Console.WriteLine('/' + s.Substring(8) + '/');
            //Console.WriteLine('/' + s.Substring(8, 5) + '/');

            //Console.WriteLine(s.Contains("ll"));
            //Console.WriteLine(s.IndexOf('o'));
            //Console.WriteLine(s.LastIndexOf('o'));
            //Console.WriteLine(s.CompareTo("abc"));

            //Console.WriteLine(String.Concat("Hi~", s));
            //Console.WriteLine(String.Compare("abc", s));
            //Console.WriteLine(t = String.Copy(s));

            //String[] val = { "apple", "orange", "grape", "pear" };
            //String result = String.Join(", ", val);
            //Console.WriteLine(result);

            DateTime date = DateTime.Now;

            Console.WriteLine(date.ToString("yyyyMMdd00005"));
            //문제1  주문번호 : yyyyMMdd일련번호5자리 (2020092900005) 를 출력하시오.

            //문제2  입력받은 아이디가 6자리 이상인지 체크하시오.
            FileInfo fileInfo = new FileInfo(date.ToString("yyyyMMddHHmmss"));
            Console.WriteLine(date.ToString("yyyyMMddHHmmss"));
            Console.WriteLine(fileInfo.Directory);
            Random2 random = new Random2(DateTime.Now.Millisecond);
            byte[] result1 = new byte[3];
            random.NextBytes(result1, 48, 90);
            string result2 = Encoding.UTF8.GetString(result1);
            Console.WriteLine(result2);
            //fileInfo.Create();
            //문제3  파일명 : yyyyMMddHHmmss + 랜덤3자리(영문대문자 + 숫자)
        }
    }
}
