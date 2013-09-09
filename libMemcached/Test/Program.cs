using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memcached.ClientLibrary;
using System.Collections;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList services = new ArrayList();
            services.Add("127.0.0.1:11211");
            SockIOPool sock = SockIOPool.GetInstance();
            sock.SetServers(services);
            sock.Initialize();

            MemcachedClient client = new MemcachedClient();
            client.Set("F", "xxx");

            Console.WriteLine("F:" + client.Get("F"));

            Console.ReadKey();
        }
    }
}
