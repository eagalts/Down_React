
namespace DownReact
{
    partial class Resources
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
            this.components = new System.ComponentModel.Container();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.downReactDataSet1 = new DownReact.DownReactDataSet();
            this.resourcesTableAdapter = new DownReact.DownReactDataSetTableAdapters.ResourcesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Applogo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resourcesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.названиеРесурсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресРесурсаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downReactDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.downReactDataSet1;
            // 
            // downReactDataSet1
            // 
            this.downReactDataSet1.DataSetName = "DownReactDataSet";
            this.downReactDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(267, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 36);
            this.button3.TabIndex = 24;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(462, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 23;
            this.button2.Text = "Настройки";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Applogo
            // 
            this.Applogo.AutoSize = true;
            this.Applogo.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Applogo.Location = new System.Drawing.Point(12, 9);
            this.Applogo.Name = "Applogo";
            this.Applogo.Size = new System.Drawing.Size(127, 30);
            this.Applogo.TabIndex = 22;
            this.Applogo.Text = "DownReact";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеРесурсаDataGridViewTextBoxColumn,
            this.адресРесурсаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resourcesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 356);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // resourcesBindingSource1
            // 
            this.resourcesBindingSource1.DataMember = "Resources";
            this.resourcesBindingSource1.DataSource = this.downReactDataSet1;
            // 
            // названиеРесурсаDataGridViewTextBoxColumn
            // 
            this.названиеРесурсаDataGridViewTextBoxColumn.DataPropertyName = "Название ресурса";
            this.названиеРесурсаDataGridViewTextBoxColumn.HeaderText = "Название ресурса";
            this.названиеРесурсаDataGridViewTextBoxColumn.Name = "названиеРесурсаDataGridViewTextBoxColumn";
            // 
            // адресРесурсаDataGridViewTextBoxColumn
            // 
            this.адресРесурсаDataGridViewTextBoxColumn.DataPropertyName = "Адрес ресурса";
            this.адресРесурсаDataGridViewTextBoxColumn.HeaderText = "Адрес ресурса";
            this.адресРесурсаDataGridViewTextBoxColumn.Name = "адресРесурсаDataGridViewTextBoxColumn";
            // 
            // Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Applogo);
            this.Name = "Resources";
            this.Text = "Resources";
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downReactDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private DownReactDataSet downReactDataSet1;
        private DownReactDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Applogo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеРесурсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресРесурсаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource resourcesBindingSource1;
    }
}