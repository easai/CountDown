using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown
{
    class CountDownFile
    {
        const int bufSize = 1900;

        public static string getRandom(string fileName)
        {
            System.IO.FileStream stream=System.IO.File.OpenRead(fileName);
            System.IO.StreamReader reader=new System.IO.StreamReader(stream);
            Random rand = new Random(Environment.TickCount);
            long pos=(long)(rand.NextDouble()*(stream.Length - bufSize));
            stream.Seek(pos, System.IO.SeekOrigin.Begin);
            char[] buf=new char[3];
            reader.Read(buf, 0, 3);
            long i = 0;            
            while ((buf[i] >> 14)==10 &&  ++i < buf.Length) ;
            stream.Seek(pos + i, System.IO.SeekOrigin.Begin);
            string str = "";
            for (int k = 0; k < 5; k++)
            {
                str += reader.ReadLine()+"\n";
            }
            return str;
        }
    }
}
