using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld.CustomControls.Class
{
    class FileLog : AProperties,ILogger
    {
        public virtual void Log()
        {
            throw new NotImplementedException();
        }
    }
    class DatabaseLog : ILogger
    {
        public void Log()
        {
            throw new NotImplementedException();
        }
    }
    class FTPLog : ILogger
    {
        public void Log()
        {
            throw new NotImplementedException();
        }
    }
    class SmsLog : ILogger
    {
        public void Log()
        {
            throw new NotImplementedException();
        }
    }

    interface ILogger
    {
        void Log();
    }
    abstract class AProperties
    {
        string LogMessage { get; set; }
    }
}
