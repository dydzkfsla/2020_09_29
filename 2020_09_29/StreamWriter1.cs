using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_09_29
{
    class StreamWriter1
    {
        [STAThread]
        static void Main()
        {
            string path = System.Environment.CurrentDirectory;
            SaveFileDialog fileDialog = new SaveFileDialog();
            DialogResult result = fileDialog.ShowDialog();
            string fileName = fileDialog.FileName;

            if(result == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8);  //전부 제한적
                sw.WriteLine("안녕하세요. {0}님", "홍길동");
                sw.WriteLine(123456);
                sw.Flush();
                sw.Close();
            }

            using(StreamWriter sw = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                sw.WriteLine("안녕하세요. {0}님", "홍길동");
                sw.WriteLine(123456);
                sw.Flush();
            }
        }
    }
}
