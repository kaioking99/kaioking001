namespace Opc.Ua.Server.Controls.Function_Form
{
    partial class StatusCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TCP_Adresss_Label = new System.Windows.Forms.Label();
            this.HTTPS_Address_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.StartingTimeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateTimerCtrl = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Opc.Ua.Server.Controls.Properties.Resources.Logo_BK;
            this.pictureBox1.Location = new System.Drawing.Point(58, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPC UA Simulation Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(687, 158);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(79, 37);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Error";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "UA TCP Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "UA HTTPS Address:";
            // 
            // TCP_Adresss_Label
            // 
            this.TCP_Adresss_Label.AutoSize = true;
            this.TCP_Adresss_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCP_Adresss_Label.Location = new System.Drawing.Point(687, 206);
            this.TCP_Adresss_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TCP_Adresss_Label.Name = "TCP_Adresss_Label";
            this.TCP_Adresss_Label.Size = new System.Drawing.Size(79, 37);
            this.TCP_Adresss_Label.TabIndex = 6;
            this.TCP_Adresss_Label.Text = "Error";
            // 
            // HTTPS_Address_Label
            // 
            this.HTTPS_Address_Label.AutoSize = true;
            this.HTTPS_Address_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTTPS_Address_Label.Location = new System.Drawing.Point(687, 254);
            this.HTTPS_Address_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HTTPS_Address_Label.Name = "HTTPS_Address_Label";
            this.HTTPS_Address_Label.Size = new System.Drawing.Size(79, 37);
            this.HTTPS_Address_Label.TabIndex = 7;
            this.HTTPS_Address_Label.Text = "Error";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Server Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 349);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Server Starting Time:";
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeLabel.Location = new System.Drawing.Point(687, 302);
            this.CurrentTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(79, 37);
            this.CurrentTimeLabel.TabIndex = 10;
            this.CurrentTimeLabel.Text = "Error";
            // 
            // StartingTimeLabel
            // 
            this.StartingTimeLabel.AutoSize = true;
            this.StartingTimeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingTimeLabel.Location = new System.Drawing.Point(687, 349);
            this.StartingTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartingTimeLabel.Name = "StartingTimeLabel";
            this.StartingTimeLabel.Size = new System.Drawing.Size(79, 37);
            this.StartingTimeLabel.TabIndex = 11;
            this.StartingTimeLabel.Text = "Error";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 460);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(906, 74);
            this.label7.TabIndex = 12;
            this.label7.Text = "OPC UA";
            // 
            // UpdateTimerCtrl
            // 
            this.UpdateTimerCtrl.Interval = 1000;
            this.UpdateTimerCtrl.Tick += new System.EventHandler(this.UpdateTimerCtrl_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 598);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 37);
            this.label9.TabIndex = 14;
            this.label9.Text = "1. A - 123456";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 552);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 37);
            this.label8.TabIndex = 13;
            this.label8.Text = "Student - ID";
            // 
            // StatusCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StartingTimeLabel);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HTTPS_Address_Label);
            this.Controls.Add(this.TCP_Adresss_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatusCtrl";
            this.Size = new System.Drawing.Size(1161, 752);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TCP_Adresss_Label;
        private System.Windows.Forms.Label HTTPS_Address_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label StartingTimeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer UpdateTimerCtrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
