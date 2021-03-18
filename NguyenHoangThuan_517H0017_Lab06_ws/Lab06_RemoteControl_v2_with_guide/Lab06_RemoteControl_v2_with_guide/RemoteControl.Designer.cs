
namespace Lab06_RemoteControl
{
    partial class RemoteControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSlot1 = new System.Windows.Forms.ComboBox();
            this.txtStatus1 = new System.Windows.Forms.TextBox();
            this.btnOn1 = new System.Windows.Forms.Button();
            this.btnOFF1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSlot2 = new System.Windows.Forms.ComboBox();
            this.btnON2 = new System.Windows.Forms.Button();
            this.btnOFF2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOFF3 = new System.Windows.Forms.Button();
            this.btnON3 = new System.Windows.Forms.Button();
            this.cboSlot3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOFF4 = new System.Windows.Forms.Button();
            this.btnON4 = new System.Windows.Forms.Button();
            this.cboSlot4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slot 01";
            // 
            // cboSlot1
            // 
            this.cboSlot1.FormattingEnabled = true;
            this.cboSlot1.Items.AddRange(new object[] {
            "None",
            "Light",
            "TV",
            "Door",
            "Pc",
            "Speaker",
            "Air Conditioner"});
            this.cboSlot1.Location = new System.Drawing.Point(61, 12);
            this.cboSlot1.Name = "cboSlot1";
            this.cboSlot1.Size = new System.Drawing.Size(87, 21);
            this.cboSlot1.TabIndex = 1;
            this.cboSlot1.SelectedIndexChanged += new System.EventHandler(this.cboSlot1_SelectedIndexChanged);
            // 
            // txtStatus1
            // 
            this.txtStatus1.Location = new System.Drawing.Point(17, 41);
            this.txtStatus1.Name = "txtStatus1";
            this.txtStatus1.Size = new System.Drawing.Size(28, 20);
            this.txtStatus1.TabIndex = 1;
            // 
            // btnOn1
            // 
            this.btnOn1.Location = new System.Drawing.Point(163, 10);
            this.btnOn1.Name = "btnOn1";
            this.btnOn1.Size = new System.Drawing.Size(32, 23);
            this.btnOn1.TabIndex = 2;
            this.btnOn1.Text = "ON";
            this.btnOn1.UseVisualStyleBackColor = true;
            this.btnOn1.Click += new System.EventHandler(this.btnOn1_Click);
            // 
            // btnOFF1
            // 
            this.btnOFF1.Location = new System.Drawing.Point(201, 10);
            this.btnOFF1.Name = "btnOFF1";
            this.btnOFF1.Size = new System.Drawing.Size(37, 23);
            this.btnOFF1.TabIndex = 3;
            this.btnOFF1.Text = "OFF";
            this.btnOFF1.UseVisualStyleBackColor = true;
            this.btnOFF1.Click += new System.EventHandler(this.btnOFF1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Slot 02";
            // 
            // cboSlot2
            // 
            this.cboSlot2.FormattingEnabled = true;
            this.cboSlot2.Items.AddRange(new object[] {
            "Done",
            "Light",
            "TV",
            "Door",
            "Pc",
            "Speaker",
            "Air Conditioner"});
            this.cboSlot2.Location = new System.Drawing.Point(61, 49);
            this.cboSlot2.Name = "cboSlot2";
            this.cboSlot2.Size = new System.Drawing.Size(87, 21);
            this.cboSlot2.TabIndex = 5;
            this.cboSlot2.SelectedIndexChanged += new System.EventHandler(this.cboSlot2_SelectedIndexChanged);
            // 
            // btnON2
            // 
            this.btnON2.Location = new System.Drawing.Point(163, 47);
            this.btnON2.Name = "btnON2";
            this.btnON2.Size = new System.Drawing.Size(32, 23);
            this.btnON2.TabIndex = 6;
            this.btnON2.Text = "ON";
            this.btnON2.UseVisualStyleBackColor = true;
            this.btnON2.Click += new System.EventHandler(this.btnON2_Click);
            // 
            // btnOFF2
            // 
            this.btnOFF2.Location = new System.Drawing.Point(201, 47);
            this.btnOFF2.Name = "btnOFF2";
            this.btnOFF2.Size = new System.Drawing.Size(37, 23);
            this.btnOFF2.TabIndex = 7;
            this.btnOFF2.Text = "OFF";
            this.btnOFF2.UseVisualStyleBackColor = true;
            this.btnOFF2.Click += new System.EventHandler(this.btnOFF2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đèn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TV";
            // 
            // btnTV
            // 
            this.btnTV.Location = new System.Drawing.Point(51, 41);
            this.btnTV.Name = "btnTV";
            this.btnTV.Size = new System.Drawing.Size(48, 23);
            this.btnTV.TabIndex = 3;
            this.btnTV.Text = "TV";
            this.btnTV.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTV);
            this.groupBox1.Controls.Add(this.txtStatus1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 227);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Door";
            // 
            // btnOFF3
            // 
            this.btnOFF3.Location = new System.Drawing.Point(201, 86);
            this.btnOFF3.Name = "btnOFF3";
            this.btnOFF3.Size = new System.Drawing.Size(37, 23);
            this.btnOFF3.TabIndex = 12;
            this.btnOFF3.Text = "OFF";
            this.btnOFF3.UseVisualStyleBackColor = true;
            this.btnOFF3.Click += new System.EventHandler(this.btnOFF3_Click);
            // 
            // btnON3
            // 
            this.btnON3.Location = new System.Drawing.Point(163, 86);
            this.btnON3.Name = "btnON3";
            this.btnON3.Size = new System.Drawing.Size(32, 23);
            this.btnON3.TabIndex = 11;
            this.btnON3.Text = "ON";
            this.btnON3.UseVisualStyleBackColor = true;
            this.btnON3.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboSlot3
            // 
            this.cboSlot3.FormattingEnabled = true;
            this.cboSlot3.Items.AddRange(new object[] {
            "None",
            "Light",
            "TV",
            "Door",
            "Pc",
            "Speaker",
            "Air Conditioner"});
            this.cboSlot3.Location = new System.Drawing.Point(61, 88);
            this.cboSlot3.Name = "cboSlot3";
            this.cboSlot3.Size = new System.Drawing.Size(87, 21);
            this.cboSlot3.TabIndex = 10;
            this.cboSlot3.SelectedIndexChanged += new System.EventHandler(this.cboSlot3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Slot 03";
            // 
            // btnOFF4
            // 
            this.btnOFF4.Location = new System.Drawing.Point(201, 125);
            this.btnOFF4.Name = "btnOFF4";
            this.btnOFF4.Size = new System.Drawing.Size(37, 23);
            this.btnOFF4.TabIndex = 16;
            this.btnOFF4.Text = "OFF";
            this.btnOFF4.UseVisualStyleBackColor = true;
            this.btnOFF4.Click += new System.EventHandler(this.btnOFF4_Click);
            // 
            // btnON4
            // 
            this.btnON4.Location = new System.Drawing.Point(163, 125);
            this.btnON4.Name = "btnON4";
            this.btnON4.Size = new System.Drawing.Size(32, 23);
            this.btnON4.TabIndex = 15;
            this.btnON4.Text = "ON";
            this.btnON4.UseVisualStyleBackColor = true;
            this.btnON4.Click += new System.EventHandler(this.btnON4_Click);
            // 
            // cboSlot4
            // 
            this.cboSlot4.FormattingEnabled = true;
            this.cboSlot4.Items.AddRange(new object[] {
            "None",
            "Light",
            "TV",
            "Door",
            "Pc",
            "Speaker",
            "Air Conditioner"});
            this.cboSlot4.Location = new System.Drawing.Point(61, 127);
            this.cboSlot4.Name = "cboSlot4";
            this.cboSlot4.Size = new System.Drawing.Size(87, 21);
            this.cboSlot4.TabIndex = 14;
            this.cboSlot4.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Slot 04";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pc";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab06_RemoteControl.Properties.Resources.off_pc;
            this.pictureBox2.Location = new System.Drawing.Point(186, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab06_RemoteControl.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(105, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Speaker";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Air Conditioner";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Air Conditioner";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RemoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 389);
            this.Controls.Add(this.btnOFF4);
            this.Controls.Add(this.btnON4);
            this.Controls.Add(this.cboSlot4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOFF3);
            this.Controls.Add(this.btnON3);
            this.Controls.Add(this.cboSlot3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOFF2);
            this.Controls.Add(this.btnOFF1);
            this.Controls.Add(this.btnON2);
            this.Controls.Add(this.btnOn1);
            this.Controls.Add(this.cboSlot2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSlot1);
            this.Controls.Add(this.label1);
            this.Name = "RemoteControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSlot1;
        private System.Windows.Forms.TextBox txtStatus1;
        private System.Windows.Forms.Button btnOn1;
        private System.Windows.Forms.Button btnOFF1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSlot2;
        private System.Windows.Forms.Button btnON2;
        private System.Windows.Forms.Button btnOFF2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOFF3;
        private System.Windows.Forms.Button btnON3;
        private System.Windows.Forms.ComboBox cboSlot3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOFF4;
        private System.Windows.Forms.Button btnON4;
        private System.Windows.Forms.ComboBox cboSlot4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}

