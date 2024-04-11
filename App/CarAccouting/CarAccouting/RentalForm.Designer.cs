
namespace CarAccouting
{
    partial class RentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchImg = new System.Windows.Forms.PictureBox();
            this.ClearImg = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NewTrainerButton = new System.Windows.Forms.Button();
            this.ChangeTrainerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteTrainerButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AnotherStick = new System.Windows.Forms.PictureBox();
            this.Addresstb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnotherStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Controls.Add(this.SearchImg);
            this.panel1.Controls.Add(this.ClearImg);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 108);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Финансы:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(708, 44);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(150, 22);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchImg
            // 
            this.SearchImg.Image = global::CarAccouting.Properties.Resources.Лупа;
            this.SearchImg.Location = new System.Drawing.Point(636, 23);
            this.SearchImg.Margin = new System.Windows.Forms.Padding(2);
            this.SearchImg.Name = "SearchImg";
            this.SearchImg.Size = new System.Drawing.Size(61, 61);
            this.SearchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchImg.TabIndex = 2;
            this.SearchImg.TabStop = false;
            // 
            // ClearImg
            // 
            this.ClearImg.Image = global::CarAccouting.Properties.Resources.Ластик;
            this.ClearImg.Location = new System.Drawing.Point(560, 23);
            this.ClearImg.Margin = new System.Windows.Forms.Padding(2);
            this.ClearImg.Name = "ClearImg";
            this.ClearImg.Size = new System.Drawing.Size(61, 61);
            this.ClearImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClearImg.TabIndex = 0;
            this.ClearImg.TabStop = false;
            this.ClearImg.Click += new System.EventHandler(this.ClearImg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 130);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(638, 214);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NewTrainerButton);
            this.panel2.Controls.Add(this.ChangeTrainerButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DeleteTrainerButton);
            this.panel2.Location = new System.Drawing.Point(6, 358);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 219);
            this.panel2.TabIndex = 9;
            // 
            // NewTrainerButton
            // 
            this.NewTrainerButton.Location = new System.Drawing.Point(29, 37);
            this.NewTrainerButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewTrainerButton.Name = "NewTrainerButton";
            this.NewTrainerButton.Size = new System.Drawing.Size(156, 51);
            this.NewTrainerButton.TabIndex = 1;
            this.NewTrainerButton.Text = "Добавить запись";
            this.NewTrainerButton.UseVisualStyleBackColor = true;
            this.NewTrainerButton.Click += new System.EventHandler(this.NewTrainerButton_Click_1);
            // 
            // ChangeTrainerButton
            // 
            this.ChangeTrainerButton.Location = new System.Drawing.Point(29, 98);
            this.ChangeTrainerButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeTrainerButton.Name = "ChangeTrainerButton";
            this.ChangeTrainerButton.Size = new System.Drawing.Size(156, 51);
            this.ChangeTrainerButton.TabIndex = 3;
            this.ChangeTrainerButton.Text = "Изменить";
            this.ChangeTrainerButton.UseVisualStyleBackColor = true;
            this.ChangeTrainerButton.Click += new System.EventHandler(this.ChangeTrainerButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Управление записями:";
            // 
            // DeleteTrainerButton
            // 
            this.DeleteTrainerButton.Location = new System.Drawing.Point(29, 157);
            this.DeleteTrainerButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteTrainerButton.Name = "DeleteTrainerButton";
            this.DeleteTrainerButton.Size = new System.Drawing.Size(156, 51);
            this.DeleteTrainerButton.TabIndex = 2;
            this.DeleteTrainerButton.Text = "Удалить";
            this.DeleteTrainerButton.UseVisualStyleBackColor = true;
            this.DeleteTrainerButton.Click += new System.EventHandler(this.DeleteTrainerButton_Click_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.AnotherStick);
            this.panel3.Controls.Add(this.Addresstb);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(232, 358);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 219);
            this.panel3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 10;
            // 
            // AnotherStick
            // 
            this.AnotherStick.Image = global::CarAccouting.Properties.Resources.Ластик;
            this.AnotherStick.Location = new System.Drawing.Point(7, 107);
            this.AnotherStick.Margin = new System.Windows.Forms.Padding(2);
            this.AnotherStick.Name = "AnotherStick";
            this.AnotherStick.Size = new System.Drawing.Size(61, 61);
            this.AnotherStick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnotherStick.TabIndex = 5;
            this.AnotherStick.TabStop = false;
            this.AnotherStick.Click += new System.EventHandler(this.AnotherStick_Click);
            // 
            // Addresstb
            // 
            this.Addresstb.Location = new System.Drawing.Point(100, 69);
            this.Addresstb.Margin = new System.Windows.Forms.Padding(2);
            this.Addresstb.Name = "Addresstb";
            this.Addresstb.Size = new System.Drawing.Size(97, 22);
            this.Addresstb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Дата:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarAccouting.Properties.Resources.плюс;
            this.pictureBox2.Location = new System.Drawing.Point(6, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Данные:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::CarAccouting.Properties.Resources._6DBHRAD_1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 130);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID собственника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID услуги";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(392, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 22);
            this.textBox2.TabIndex = 13;
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Финансы";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnotherStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.PictureBox SearchImg;
        private System.Windows.Forms.PictureBox ClearImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NewTrainerButton;
        private System.Windows.Forms.Button ChangeTrainerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteTrainerButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox AnotherStick;
        private System.Windows.Forms.TextBox Addresstb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}