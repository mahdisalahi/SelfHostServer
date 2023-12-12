using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostServer.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = HostConfig.SetConfiguration();

            HostConfig.RunServer(config);

            Console.ReadKey();
        }
    }
}
