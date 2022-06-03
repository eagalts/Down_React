using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace DownReact
{
    public partial class Settings : Form
    {
        
        Random rnd = new Random();
        public int VerificationCode;
        public bool PhoneRegist = true;
        public string PhoneNumber = "+79999999999";
        public Settings()
        {
            InitializeComponent();
            var accountSid = "ACaa57c272c79f0d1f51e1a496650ffeaa";
            var authToken = "34217a9ea195ac718972c2cf137b5030";

            TwilioClient.Init(accountSid, authToken);

            if (PhoneRegist)
            {
                phoneBtn.Text = "сменить";
                phone.Text = PhoneNumber;
                phone.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PhoneRegist)
            {
                phoneBtn.Text = "подтвердить";
                phone.Enabled = true;
                phone.Text = "";
                PhoneRegist = false;
                PhoneNumber = "";
                return;
            }
            VerificationCode = rnd.Next(11111, 99999);

            PhoneNumber = phone.Text;

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber($"whatsapp:{PhoneNumber}"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = $"Для подтверждения номера телефона введите код {VerificationCode}.\nDownReact";

            var message = MessageResource.Create(messageOptions);

            verLabel.Visible = true;
            verBox.Visible = true;
            verBtn.Visible = true;

        }

        private void verBtn_Click(object sender, EventArgs e)
        {
            if (VerificationCode.ToString() == verBox.Text)
            {
                verBox.Visible = false;
                verBtn.Visible = false;

                verLabel.Text = "Номер телефона подтверждён.";

                phone.Enabled = false;
                phoneBtn.Text = "сменить";


                var messageOptions = new CreateMessageOptions(
                    new PhoneNumber($"whatsapp:{PhoneNumber}"));
                messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
                messageOptions.Body = $"Телефон успешно подтверждён.\nDownReact";

                var message = MessageResource.Create(messageOptions);

                PhoneRegist = true;
            }

            else
            {
                verLabel.Text = "Указан неверный код.\nПопробуйте ещё раз.";
            }
        }
    }
}
