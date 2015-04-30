using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LollipopChecker
{
    public partial class LollipopCheckerForm : Form
    {

        String IMEI = "";   // Insert your IMEI number here!
        string harviellerinte = "";
        BackgroundWorker m_oWorker;

        public LollipopCheckerForm()
        {
            InitializeComponent();

//            m_oWorker = new BackgroundWorker();

//            m_oWorker.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
////            m_oWorker.ProgressChanged += new ProgressChangedEventHandler(m_oWorker_ProgressChanged);
////            m_oWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oWorker_RunWorkerCompleted);
////            m_oWorker.WorkerReportsProgress = true;
////            m_oWorker.WorkerSupportsCancellation = true;
//            m_oWorker.RunWorkerAsync();

            checkforlollipop();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            checkforlollipop();
        }


        private void checkforlollipop()
        {
            // Polla LGs server

            HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp("http://csmg.lgmobile.com:9002/csmg/b2c/client/auth_model_check2.jsp?esn="+IMEI);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Läs response bodyn
            Stream recieveStream = response.GetResponseStream();

            StreamReader readStream = new StreamReader(recieveStream, Encoding.UTF8);

            XmlSerializer serializer = new XmlSerializer(typeof(response));

            response hepp = new response();

            hepp = (response)serializer.Deserialize(readStream);

            harviellerinte = hepp.auth_model_check.sw_version;

            response.Close();
            readStream.Close();

            // Update status field

            String tiden = DateTime.Now.ToString();

            toolStripStatusLabel1.Text = "Last checked: "+tiden;

            textBox1.Text = harviellerinte;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
//            for (int i = 1; i <= 5; i++)
            {
//                toolStripStatusLabel1.Text = "wow" + i;
                checkforlollipop();
                Thread.Sleep(1000*60*30);
            }



        }

    }

    
}
