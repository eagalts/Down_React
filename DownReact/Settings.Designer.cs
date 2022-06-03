
namespace DownReact
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Applogo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.phoneBtn = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.verLabel = new System.Windows.Forms.Label();
            this.verBtn = new System.Windows.Forms.Button();
            this.verBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Applogo
            // 
            this.Applogo.AutoSize = true;
            this.Applogo.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applogo.Location = new System.Drawing.Point(12, 9);
            this.Applogo.Name = "Applogo";
            this.Applogo.Size = new System.Drawing.Size(127, 30);
            this.Applogo.TabIndex = 3;
            this.Applogo.Text = "DownReact";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(462, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "УВЕДОМЛЕНИЯ БУДУТ ПРИХОДИТЬ НА WHATSAPP:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(20, 80);
            this.phone.MaxLength = 12;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(206, 20);
            this.phone.TabIndex = 7;
            // 
            // phoneBtn
            // 
            this.phoneBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.phoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneBtn.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneBtn.Location = new System.Drawing.Point(229, 76);
            this.phoneBtn.Margin = new System.Windows.Forms.Padding(0);
            this.phoneBtn.Name = "phoneBtn";
            this.phoneBtn.Size = new System.Drawing.Size(101, 25);
            this.phoneBtn.TabIndex = 8;
            this.phoneBtn.Text = "подтвердить";
            this.phoneBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.phoneBtn.UseVisualStyleBackColor = true;
            this.phoneBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Montserrat", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(20, 102);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(127, 24);
            this.info.TabIndex = 9;
            this.info.Text = "Укажите номер телефона \r\nв формате +7XXXXXXXXXX";
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verLabel.Location = new System.Drawing.Point(12, 387);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(250, 45);
            this.verLabel.TabIndex = 10;
            this.verLabel.Text = "Мы отправили сообщение на WhatsApp\r\nпо указанному номеру. Введите код \r\nиз сообще" +
    "ния:\r\n";
            this.verLabel.Visible = false;
            // 
            // verBtn
            // 
            this.verBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.verBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verBtn.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verBtn.Location = new System.Drawing.Point(447, 396);
            this.verBtn.Margin = new System.Windows.Forms.Padding(0);
            this.verBtn.Name = "verBtn";
            this.verBtn.Size = new System.Drawing.Size(101, 25);
            this.verBtn.TabIndex = 12;
            this.verBtn.Text = "подтвердить";
            this.verBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.verBtn.UseVisualStyleBackColor = true;
            this.verBtn.Visible = false;
            this.verBtn.Click += new System.EventHandler(this.verBtn_Click);
            // 
            // verBox
            // 
            this.verBox.Location = new System.Drawing.Point(349, 400);
            this.verBox.MaxLength = 5;
            this.verBox.Name = "verBox";
            this.verBox.Size = new System.Drawing.Size(95, 20);
            this.verBox.TabIndex = 11;
            this.verBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "ТИПЫ УВЕДОМЛЕНИЙ:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(20, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Сервис недоступен\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(20, 199);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(205, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Сервис недоступен более 15 минут\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(20, 222);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(145, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Сервис снова доступен";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "ПЕРИОДИЧНОСТЬ ПРОВЕРКИ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 44);
            this.label4.TabIndex = 18;
            this.label4.Text = "Проверять доступность сервера \r\nкаждые               минут";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(90, 311);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 451);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verBtn);
            this.Controls.Add(this.verBox);
            this.Controls.Add(this.verLabel);
            this.Controls.Add(this.info);
            this.Controls.Add(this.phoneBtn);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Applogo);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Applogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button phoneBtn;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.Button verBtn;
        private System.Windows.Forms.TextBox verBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}