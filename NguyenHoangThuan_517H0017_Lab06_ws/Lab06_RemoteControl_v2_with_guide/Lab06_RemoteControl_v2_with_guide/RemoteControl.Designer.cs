
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "OFF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "ON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Light",
            "TV",
            "Door",
            "Pc",
            "Speaker",
            "Air Conditioner"});
            this.comboBox1.Location = new System.Drawing.Point(61, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 10;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "OFF";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(163, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "ON";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None",
            "Light",
            "TV",
            "Door",
            "Pc",
            "Speaker",
            "Air Conditioner"});
            this.comboBox2.Location = new System.Drawing.Point(61, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(87, 21);
            this.comboBox2.TabIndex = 14;
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
            // RemoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 389);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
    }
}

