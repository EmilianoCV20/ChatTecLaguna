using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatTecLaguna
{
    public partial class Form1 : Form
    {
        private MQTTConnections connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (connection != null)
                return;

            connection = new MQTTConnections();
            Broker broker = new Broker();
            broker.Server = serverTextBOX.Text;
            broker.Port = int.Parse(portTextBox.Text);
            connection.Connect(broker);
            connection.MessageReceived += Connection_MessageReceived;
            connection.Subscribe(groupchatTextBox.Text);
        }

        private void Connection_MessageReceived(object sender, MessageInfo e)
        {
            this.Invoke(new Action(() =>
            {
                string[] data = e.Message.Split('|');
                if (data[0].Equals(userTextBox.Text))
                {
                    messagesTextBox.Text += "You said: " + data[1]+ "\r\n";
                }
                else
                {
                    messagesTextBox.Text += data[0] + " says: " + data[1] + "\r\n";
                }
            }));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string finalMessage = userTextBox.Text+"|"+dataToSentTextBox.Text;

            connection.Send(finalMessage, groupchatTextBox.Text);
            dataToSentTextBox.Text = string.Empty;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Disconnect();
        }
    }
}
