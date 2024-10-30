using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfContract;

namespace WcpServer472.Controller
{
    public class WCFController
    {
        public WCFController()
        { 
        //здесь ожидаем клиентов
        var serviceAddress = "192.168.3.3:10000";
        var serviceName = "MyService";

        var host = new ServiceHost(typeof(ModelController), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
        var serverBinding = new NetTcpBinding();
        serverBinding.Security.Mode = SecurityMode.None;
                host.AddServiceEndpoint(typeof(ITransferObject), serverBinding, "");
                host.Open();
                Console.WriteLine("Server WCF is working!");
        }
    }
}
