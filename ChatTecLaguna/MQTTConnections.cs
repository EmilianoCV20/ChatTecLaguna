using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace ChatTecLaguna
{
    internal class MQTTConnections
    {
        private MqttClient _client = null;

        public event EventHandler<MessageInfo> MessageReceived;

        private void CreateClient(Broker broker)
        {
            if (_client != null)
                return;

            _client = new MqttClient(broker.Server, broker.Port, false, MqttSslProtocols.None, 
                (sender, certificate, chain, errors) => true,
                (sender, host, certificates, certificate, issuers) => null);

            _client.MqttMsgPublishReceived += _client_MqttMsgPublishReceived;
        }

        public void Connect(Broker broker)
        {
            CreateClient(broker);
            string clientId = Guid.NewGuid().ToString();
            _client.Connect(clientId, null, null, true, 10000);
        }

        public void Send(string message, string destinationName)
        {
            _client.Publish(destinationName, Encoding.UTF8.GetBytes(message));
        }

        public void Subscribe(string sourceName)
        {
            _client.Subscribe(new[] { sourceName }, new[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE});
        }

        private void _client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            MessageInfo info = new MessageInfo();
            info.Topic = e.Topic;
            info.Message = Encoding.UTF8.GetString(e.Message);

            if (e.Message != null)
                MessageReceived(this, info);

        }

        public void Disconnect()
        {
            if(_client!=null && _client.IsConnected)
            {
                _client.MqttMsgPublishReceived -= _client_MqttMsgPublishReceived;
                _client.Disconnect();
            }
        }
    }
}
