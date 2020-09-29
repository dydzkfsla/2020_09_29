using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_09_29
{
    class SystemReader1
    {
        static void Main() {
            using (StreamReader reader = new StreamReader("test.txt", Encoding.UTF8))
            {
                //한줄씩 읽어서 string 바환
                // 끝인경우 null
                //string content;
                //do
                //{
                //    content = reader.ReadLine();
                //    Console.WriteLine(content);
                //} while (content != );
                string content;int i = 8;
                while((content = reader.ReadLine()) != null)
                {
                    i++;
                    Console.WriteLine($"Line {i, 2}: "+content);
                }
            }
         }
   }
}
