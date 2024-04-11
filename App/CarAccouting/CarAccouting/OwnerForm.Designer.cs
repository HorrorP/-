
namespace CarAccouting
{
    partial class OwnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NewTrainerButton = new System.Windows.Forms.Button();
            this.ChangeTrainerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteTrainerButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fiotb = new System.Windows.Forms.TextBox();
            this.Passporttb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnotherStick = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchImg = new System.Windows.Forms.PictureBox();
            this.ClearImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnotherStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Controls.Add(this.SearchImg);
            this.panel1.Controls.Add(this.ClearImg);
            this.panel1.Location = new System.Drawing.Point(6, 14);
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
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Услуги:";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(638, 214);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NewTrainerButton);
            this.panel2.Controls.Add(this.ChangeTrainerButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DeleteTrainerButton);
            this.panel2.Location = new System.Drawing.Point(6, 360);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 219);
            this.panel2.TabIndex = 8;
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
            this.NewTrainerButton.Click += new System.EventHandler(this.NewTrainerButton_Click);
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
            this.ChangeTrainerButton.Click += new System.EventHandler(this.ChangeTrainerButton_Click);
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
            this.DeleteTrainerButton.Click += new System.EventHandler(this.DeleteTrainerButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AnotherStick);
            this.panel3.Controls.Add(this.fiotb);
            this.panel3.Controls.Add(this.Passporttb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(232, 360);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 219);
            this.panel3.TabIndex = 9;
            // 
            // fiotb
            // 
            this.fiotb.Location = new System.Drawing.Point(100, 69);
            this.fiotb.Margin = new System.Windows.Forms.Padding(2);
            this.fiotb.Name = "fiotb";
            this.fiotb.Size = new System.Drawing.Size(233, 22);
            this.fiotb.TabIndex = 9;
            // 
            // Passporttb
            // 
            this.Passporttb.Location = new System.Drawing.Point(100, 149);
            this.Passporttb.Margin = new System.Windows.Forms.Padding(2);
            this.Passporttb.Name = "Passporttb";
            this.Passporttb.Size = new System.Drawing.Size(233, 22);
            this.Passporttb.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Стоимость:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Название:";
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarAccouting.Properties.Resources.ДобавлениеКлиента;
            this.pictureBox2.Location = new System.Drawing.Point(6, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::CarAccouting.Properties.Resources.ЖК1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(876, 545);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "OwnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnotherStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearImg)).EndInit();
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
        private System.Windows.Forms.TextBox fiotb;
        private System.Windows.Forms.TextBox Passporttb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}