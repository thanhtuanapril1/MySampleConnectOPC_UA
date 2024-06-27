using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using Opc.UaFx;
using Opc.UaFx.Client;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*******************************
Docs for library Opc.UaFx.Advance
https://www.youtube.com/watch?v=KCW23eq4auw
https://docs.traeger.de/en/software/sdk/opc-ua/net/client.development.guide
********************************/

namespace ConnectKepwareOPC_UA
{
    public partial class Form1 : Form
    {

        OpcClient myClient = new OpcClient();
        public Form1()
        {
            InitializeComponent();

            //Add event to check Connection status
            myClient.Connected += (sender, e) => { lblConnectStatus.Text = "Connected"; };
            myClient.Disconnected += (sender, e) => { lblConnectStatus.Text = "Disconnected"; };
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                myClient.ServerAddress = new Uri(tbxServerAddress.Text);

                myClient.Connect();

                btnConnect.Enabled = false;
                btnDisonnect.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnDisonnect_Click(object sender, EventArgs e)
        {
            try
            {
                myClient.Disconnect();

                btnConnect.Enabled = true;
                btnDisonnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpcValue tag = myClient.ReadNode(tbxTag.Text);
                if (tag.Status.IsGood)
                {
                    tbxValueDataType.Text = tag.DataType.ToString();
                    tbxValue.Text = tag.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                OpcValue tag = myClient.ReadNode(tbxTag.Text);
                if (tag.Status.IsGood)
                {
                    string tagType = tag.DataType.ToString();   //Try to get the data type of node

                    OpcStatus result = new OpcStatus();
                    if (tagType == "Boolean") result = myClient.WriteNode(tbxTag.Text, bool.Parse(tbxWriteValue.Text));
                    else if (tagType == "String") result = myClient.WriteNode(tbxTag.Text, tbxWriteValue.Text);
                    else if (tagType == "UInt16") result = myClient.WriteNode(tbxTag.Text, UInt16.Parse(tbxWriteValue.Text));
                    else if (tagType == "UInt32") result = myClient.WriteNode(tbxTag.Text, UInt32.Parse(tbxWriteValue.Text));
                    else if (tagType == "Int16") result = myClient.WriteNode(tbxTag.Text, Int16.Parse(tbxWriteValue.Text));
                    else if (tagType == "Int32") result = myClient.WriteNode(tbxTag.Text, Int32.Parse(tbxWriteValue.Text));
                    else if (tagType == "Float") result = myClient.WriteNode(tbxTag.Text, float.Parse(tbxWriteValue.Text));
                    else if (tagType == "Double") result = myClient.WriteNode(tbxTag.Text, double.Parse(tbxWriteValue.Text));
                    else if (tagType == "DateTime") result = myClient.WriteNode(tbxTag.Text, DateTime.Parse(tbxWriteValue.Text));
                    //Add more if need

                    if (result.IsBad) MessageBox.Show("Status is Bad: " + result.Description);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnReadMulti_Click(object sender, EventArgs e)
        {
            try
            {
                List<OpcReadNode> nodes = new List<OpcReadNode>();
                if (tbxTag1.Text != "") nodes.Add(new OpcReadNode(tbxTag1.Text));
                if (tbxTag2.Text != "") nodes.Add(new OpcReadNode(tbxTag2.Text));
                if (tbxTag3.Text != "") nodes.Add(new OpcReadNode(tbxTag3.Text));
                if (tbxTag4.Text != "") nodes.Add(new OpcReadNode(tbxTag4.Text));

                IEnumerable<OpcValue> tags = myClient.ReadNodes(nodes);
                if (tags.Any())
                {
                    int k = 0;
                    for (int i = 1; i <= 4; i++) //4 Textbox for multi tag group
                    {
                        OpcValue tag = tags.ElementAt(k);
                        switch (i)
                        {
                            case 1:
                                if (tbxTag1.Text != "")
                                {
                                    tbxValue1.Text = tag.Value.ToString();
                                    tbxDataType1.Text = tag.DataType.ToString();
                                    k++;
                                }
                                break;
                            case 2:
                                if (tbxTag2.Text != "")
                                {
                                    tbxValue2.Text = tag.Value.ToString();
                                    tbxDataType2.Text = tag.DataType.ToString();
                                    k++;
                                }
                                break;
                            case 3:
                                if (tbxTag3.Text != "")
                                {
                                    tbxValue3.Text = tag.Value.ToString();
                                    tbxDataType3.Text = tag.DataType.ToString();
                                    k++;
                                }
                                break;
                            case 4:
                                if (tbxTag4.Text != "")
                                {
                                    tbxValue4.Text = tag.Value.ToString();
                                    tbxDataType4.Text = tag.DataType.ToString();
                                    k++;
                                }
                                break;

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private List<OpcSubscription> subscriptions = new List<OpcSubscription>();
        private void btnSubcribe_Click(object sender, EventArgs e)
        {
            var subscription = myClient.SubscribeDataChange(tbxTag.Text, HandleDataChanged);

            // Always call apply changes after modifying the subscription; otherwise
            // the server will not know the new subscription configuration.

            subscription.PublishingInterval = 1000;
            subscription.ApplyChanges();

            subscriptions.Add(subscription);
        }

        private void btnUnsubcribe_Click(object sender, EventArgs e)
        {
            if (subscriptions.Count > 0)
            {
                // Unsubscribe from all subscriptions (modify for specific needs)
                foreach (OpcSubscription subscription in subscriptions.ToList()) // Create copy to avoid modification issues
                {

                    string tag = subscription.MonitoredItems[0].NodeId.OriginalString;
                    if (tag == tbxTag.Text)
                    {
                        subscription.Unsubscribe();
                        subscriptions.Remove(subscription);
                    }
                }
            }
        }


        List<OpcSubscription> subscriptionMulti_List = new List<OpcSubscription>();
        private void btnSubscribeMulti_Click(object sender, EventArgs e)
        {
            List<OpcSubscribeDataChange> list = new List<OpcSubscribeDataChange>();

            if (tbxTag1.Text != "") list.Add(new OpcSubscribeDataChange(tbxTag1.Text, HandleDataChanged));
            if (tbxTag2.Text != "") list.Add(new OpcSubscribeDataChange(tbxTag2.Text, HandleDataChanged));
            if (tbxTag3.Text != "") list.Add(new OpcSubscribeDataChange(tbxTag3.Text, HandleDataChanged));
            if (tbxTag4.Text != "") list.Add(new OpcSubscribeDataChange(tbxTag4.Text, HandleDataChanged));


            OpcSubscription subscriptionMulti = myClient.SubscribeNodes(list);

            subscriptionMulti_List.Add(subscriptionMulti);
        }

        private void btnUnsubscribeMulti_Click(object sender, EventArgs e)
        {
            if (subscriptionMulti_List.Count > 0)
            {
                foreach (OpcSubscription subscription in subscriptionMulti_List)
                {
                    subscription.Unsubscribe();
                }
                subscriptionMulti_List.Clear();
            }
        }

        private void HandleDataChanged(object sender, OpcDataChangeReceivedEventArgs e)
        {
            // Your code to execute on each data change.
            // The 'sender' variable contains the OpcMonitoredItem with the NodeId.
            OpcMonitoredItem item = (OpcMonitoredItem)sender;

            if (item.NodeId.OriginalString == tbxTag.Text) tbxValue.Text = e.Item.Value.Value.ToString();
            if (item.NodeId.OriginalString == tbxTag1.Text) tbxValue1.Text = e.Item.Value.Value.ToString();
            if (item.NodeId.OriginalString == tbxTag2.Text) tbxValue2.Text = e.Item.Value.Value.ToString();
            if (item.NodeId.OriginalString == tbxTag3.Text) tbxValue3.Text = e.Item.Value.Value.ToString();
            if (item.NodeId.OriginalString == tbxTag4.Text) tbxValue4.Text = e.Item.Value.Value.ToString();

        }
    }
}
