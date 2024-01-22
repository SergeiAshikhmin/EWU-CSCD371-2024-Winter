using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        private readonly string _PathName;
        public FileLogger(string filePath)
        {
            _PathName = filePath;
        }
        public override void Log(LogLevel logLevel, string message)
        {
            
            throw new NotImplementedException();
        }

        public string GetPathName()
        {
            return _PathName;
        }

    }
}
