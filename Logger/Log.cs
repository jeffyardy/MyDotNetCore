using System;
using System.IO;
using System.Net.Security;
using System.Text;
using Grpc.Core;

namespace Logger
{
    public sealed class Log : ILog
    {
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());
        string myValue = "";
        private Log()
        {
        }

        public static Log GetIntance
        {
            get
            {

                return instance.Value;
            }
        }


        public void Exception(string message, string path)
        {
            string fileName = string.Format("{0}.log", "Exception");

            string logFilePath = string.Format(@"{0}{1}", "D:/JeffSoft/", fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------------------------------------------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);

            if(File.Exists(logFilePath))
            {
                File.Delete(logFilePath);
            }

            using(FileStream fs = File.Create(logFilePath))
            {
                byte[] text = new UTF8Encoding(true).GetBytes(sb.ToString());
                fs.Write(text, 0, text.Length);
                fs.Flush();
            }

            //using (StreamWriter writer = new StreamWriter(logFilePath))
            //{
            //    //writer.WriteLine(sb.ToString());
            //    writer.Write(sb.ToString());
            //    writer.Flush();

            //}
        }
    }
}
