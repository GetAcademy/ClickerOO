using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerOO
{
    class Logger
    {
        private static Logger _instance;

        private Logger()
        {
            
        }

        public static Logger GetLogger()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(string message, DateTime dateTime, string userName)
        {
            // ....
        }

        public void Log(string message)
        {
            Log(message, DateTime.Now, "admin");
        }
    }
}
