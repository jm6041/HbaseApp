using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thrift.Protocols;
using Thrift.Transports;
using Thrift.Transports.Client;

namespace HbaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RunClient().GetAwaiter().GetResult();
            Console.ReadLine();
        }

        static async Task RunClient()
        {
            TClientTransport clientTransport = null;
            try
            {
                CancellationToken token = new CancellationToken();
                clientTransport = new TSocketClientTransport(IPAddress.Loopback, 9090);
                TProtocol protocol = new TBinaryProtocol(clientTransport);
                var client = new THBaseService.Client(protocol);
                await client.OpenTransportAsync(token);
                byte[] table = Encoding.UTF8.GetBytes("test");
                TGet get = new TGet();
                get.Row = Encoding.UTF8.GetBytes("row1");
                TResult reslut = await client.getAsync(table, get, new CancellationToken());
                //print results
                Console.WriteLine("RowKey:\n{0}", Encoding.UTF8.GetString(reslut.Row));
                foreach (var k in reslut.ColumnValues)
                {
                    Console.WriteLine("Family:Qualifier:" + "\n" + Encoding.UTF8.GetString(k.Family) + ":" + Encoding.UTF8.GetString(k.Qualifier));
                    Console.WriteLine("Value:" + Encoding.UTF8.GetString(k.Value));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                clientTransport?.Close();
            }
        }
    }
}
