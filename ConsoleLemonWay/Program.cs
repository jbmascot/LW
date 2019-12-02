using ConsoleLemonWay.ServiceReference;
using log4net;
using log4net.Config;
using System;

namespace ConsoleLemonWay
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            try
            {
                using (var client = new WebServiceSoapClient())
                {
                    long res = -1;
                    try
                    {
                        Log.Info("Request Fibonacci : " + 10);
                        res = client.Fibonacci(10);
                        Log.Info("Response Fibonacci : " + res);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Error Request Fibonacci : " + ex.Message);
                    }

                    Console.WriteLine("Result Fibonacci (10) : " + res);
                    Console.WriteLine();
                    Console.WriteLine("Enter your Xml characters: ");
                    Console.WriteLine();
                    string val = Console.ReadLine();
                    Console.WriteLine();

                    string result = string.Empty;
                    try
                    {
                        Log.Info("Request XmlToJson : " + val);
                        result = client.XmlToJson(val);
                        Log.Info("Response XmlToJson : " + result);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Error Request XmlToJson : " + ex.Message);
                    }

                    Console.WriteLine("Result XmlToJson : " + Environment.NewLine + result);
                }
            } 
            catch (Exception ex) 
            {
                Log.Error("Error : " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
