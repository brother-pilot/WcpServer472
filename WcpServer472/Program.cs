
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
using System.Text;
    using System.Threading.Tasks;
    using WcpServer472.Controller;

    namespace WcpServer472
    {
        class Program
        {
            static void Main(string[] args)
            {
                var wcf = new WCFController();

                Console.ReadKey();
            }
        }
    }
