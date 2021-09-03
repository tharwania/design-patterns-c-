using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class LogFactory
    {
        public static ILog CreateLog(string type)
        {
            return type switch
            {
                "File" or "1" or "FileLogger" => new FileLogger(),
                "2" or "Console" or "ConsoleLogger" => new ConsoleLogger(),
                _ => new ConsoleLogger(),
            };
        }
    }
}
