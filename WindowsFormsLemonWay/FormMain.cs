using log4net;
using log4net.Config;
using System;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsLemonWay.ServiceReference;

namespace WindowsFormsLemonWay
{
    public partial class FormMain : Form
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public FormMain()
        {
            InitializeComponent();
            XmlConfigurator.Configure();
        }

        void Wait()
        {
            Thread.Sleep(5000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long res = -1;
            try 
            {
                using (FormWait frm = new FormWait(Wait))
                {
                    buttonFibonacci.DialogResult = frm.ShowDialog(this);
                }
                using (var client = new WebServiceSoapClient())
                {
                    try
                    {
                        Log.Info("Request Fibonacci : " + 10);
                        res = client.FibonacciAsync(10).Result;
                        Log.Info("Response Fibonacci : " + res);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Error Request Fibonacci : " + ex.Message);
                    }
                    Thread.Sleep(2000);
                }
            } 
            catch (Exception ex)
            {
                Log.Error("Error : " + ex.Message);
            }
            MessageBox.Show(res.ToString());
            //this.Close();
        }

        private void buttonXmlToJson_Click(object sender, EventArgs e)
        {
            string res = string.Empty;
            try 
            {
                using (var client = new WebServiceSoapClient())
                {
                    try
                    {
                        Log.Info("Request XmlToJson : " + this.textBox1.Text);
                        res = client.XmlToJson(this.textBox1.Text);
                        Log.Info("Response XmlToJson : " + res);
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Error Request XmlToJson : " + ex.Message);
                    }
                }
            } 
            catch (Exception ex) 
            {
                Log.Error("Error : " + ex.Message);
            }
            MessageBox.Show(res.ToString());
        }
    }
}
