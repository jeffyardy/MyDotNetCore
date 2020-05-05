using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public interface ILog
    {
        void Exception(string message, string path);
    }
}
