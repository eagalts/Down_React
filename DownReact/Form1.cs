using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace DownReact
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        static async Task Main()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\v11.0;InitialCatalog=Library;Integrated Security=SSPI");
            String selectSQL = "SELECT * FROM Authors";
            SqlDataAdapter da = new SqlDataAdapter(selectSQL, conn);
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Main();
            label1.Text = "Ожидание...";
            var accountSid = "ACaa57c272c79f0d1f51e1a496650ffeaa";
            var authToken = "34217a9ea195ac718972c2cf137b5030";

            label1.Text = "Отправка...";
            //TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("whatsapp:+79520164545"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = "GOOGLE.COM - Недоступно более 5 мин.";

           // var message = MessageResource.Create(messageOptions);

            //label1.Text = message.Sid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "downReactDataSet1.Resources". При необходимости она может быть перемещена или удалена.
            this.resourcesTableAdapter.Fill(this.downReactDataSet1.Resources);
            string connectionString = @"Data Source=.\Y;Initial Catalog=usersdb;Integrated Security=True";

            // Создание подключения
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }

            Console.Read();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings fS = new Settings();
            fS.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resources fR = new Resources();
            fR.ShowDialog();
        }
    }
}


/*
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure
        
    }
}
*/