using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MqqtBrokerClientHome
{
    public partial class Form1 : Form
    {
        MqttClient mqttClient;

        TimeSpan MN01T, MN02T,CMA03T, CMA04T, CMA05T, CMA06T, CMA07T, CMA08T;
        double MN01S, MN02S, CMA03S, CMA04S, CMA05S, CMA06S, CMA07S, CMA08S = 0;

        Stopwatch MN01K = new Stopwatch();
        Stopwatch MN02K = new Stopwatch();
        Stopwatch CMA03K = new Stopwatch();
        Stopwatch CMA04K = new Stopwatch();
        Stopwatch CMA05K = new Stopwatch();
        Stopwatch CMA06K = new Stopwatch();
        Stopwatch CMA07K = new Stopwatch();
        Stopwatch CMA08K = new Stopwatch();


        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                mqttClient = new MqttClient("127.0.0.1");
                //mqttClient = new MqttClient("193.100.100.105");

                mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;

                //string[] topics = { "MN01", "MN02", "CMA03", "CMA04", "CMA05", "CMA06", "CMA07", "CMA08" };
                //byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,
                //MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE,MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE};

                string[] topics = { "test-veris" };
                byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE };
                mqttClient.Subscribe(topics, qosLevels);
                mqttClient.Connect(Guid.NewGuid().ToString());

            });

            timer_MN01.Start();
            timer1_MN02.Start();
            timer_CMA03.Start();

        }

        private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            if (e.Topic == "test-veris")
            {
                txtAlıcı.Items.Add(message);

                if (message == "On")
                {
                    MN01K.Start();
                }

                if (message == "Off")
                {
                    MN01K.Stop();
                }
            }

            if (e.Topic == "MN02")
            {
                if (message == "On")
                {
                    MN02K.Start();
                }

                if (message == "Off")
                {
                    MN02K.Stop();
                }
            }

            if (e.Topic == "CMA03")
            {
                if (message == "On")
                {
                    CMA03K.Start();
                }

                if (message == "Off")
                {
                    CMA03K.Stop();
                }
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() =>
            {
                if (mqttClient != null && mqttClient.IsConnected)
                {
                    mqttClient.Publish("test-alis", Encoding.UTF8.GetBytes(textBox1.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                }
            });
        }

        private void timer_MN01_Tick(object sender, EventArgs e)
        {
            MN01T = MN01K.Elapsed;
            MN01S = MN01T.TotalMilliseconds;

            MN01S = Math.Floor(MN01S);
            lblMN01.Text = MN01S.ToString();
        }

        private void timer1_MN02_Tick(object sender, EventArgs e)
        {
            MN02T = MN02K.Elapsed;
            MN02S = MN02T.TotalMilliseconds;

            MN02S = Math.Floor(MN02S);
            lblMN02.Text = MN02S.ToString();
        }

        private void timer_CMA03_Tick(object sender, EventArgs e)
        {
            CMA03T = CMA03K.Elapsed;
            CMA03S = CMA03T.TotalMilliseconds;

            CMA03S = Math.Floor(CMA03S);
            lblCMA03.Text = CMA03S.ToString();
        }


    }
}




