using Client.ServiceReference1;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        Service1Client sessionClient = new Service1Client("NetTcpBinding_IService1");
        static Uri address = new Uri("net.tcp://localhost:8733/Design_Time_Addresses/Server/Service1/");
        NetTcpBinding binding = new NetTcpBinding();
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = sessionClient.GetComboValue();
            Table();
            comboBox1.DisplayMember = "ServiceName";
            comboBox1.ValueMember = "ServiceName";
        }

        public void Table()
        {
            dataGridView1.DataSource = sessionClient.GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sessionClient.NewRec(textBox1.Text, comboBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString());
            Table();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
