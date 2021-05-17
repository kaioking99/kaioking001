namespace Opc.Ua.Server.Controls.Function_Form
{
    partial class SessionCtrl
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
            this.SessionCountLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SessionsLV = new System.Windows.Forms.ListView();
            this.SessionNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SessionIdCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SessionTimeoutCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastContactTimeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsActiveCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateTimerCtrl = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SessionCountLB
            // 
            this.SessionCountLB.AutoSize = true;
            this.SessionCountLB.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionCountLB.Location = new System.Drawing.Point(143, 4);
            this.SessionCountLB.Name = "SessionCountLB";
            this.SessionCountLB.Size = new System.Drawing.Size(56, 23);
            this.SessionCountLB.TabIndex = 5;
            this.SessionCountLB.Text = "Error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sessions Count:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SessionCountLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 30);
            this.panel1.TabIndex = 6;
            // 
            // SessionsLV
            // 
            this.SessionsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SessionNameCh,
            this.UserCh,
            this.SessionIdCh,
            this.SessionTimeoutCH,
            this.LastContactTimeCh,
            this.IsActiveCh});
            this.SessionsLV.Dock = System.Windows.Forms.DockStyle.Top;
            this.SessionsLV.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionsLV.FullRowSelect = true;
            this.SessionsLV.HideSelection = false;
            this.SessionsLV.Location = new System.Drawing.Point(0, 30);
            this.SessionsLV.Name = "SessionsLV";
            this.SessionsLV.Size = new System.Drawing.Size(774, 459);
            this.SessionsLV.TabIndex = 10;
            this.SessionsLV.UseCompatibleStateImageBehavior = false;
            this.SessionsLV.View = System.Windows.Forms.View.Details;
            // 
            // SessionNameCh
            // 
            this.SessionNameCh.Text = "Session Name";
            this.SessionNameCh.Width = 225;
            // 
            // UserCh
            // 
            this.UserCh.Text = "User";
            this.UserCh.Width = 101;
            // 
            // SessionIdCh
            // 
            this.SessionIdCh.Text = "SessionId";
            this.SessionIdCh.Width = 109;
            // 
            // SessionTimeoutCH
            // 
            this.SessionTimeoutCH.Text = "Timeout (ms)";
            this.SessionTimeoutCH.Width = 102;
            // 
            // LastContactTimeCh
            // 
            this.LastContactTimeCh.Text = "Last Contact Time";
            this.LastContactTimeCh.Width = 163;
            // 
            // IsActiveCh
            // 
            this.IsActiveCh.Text = "Is Active";
            this.IsActiveCh.Width = 116;
            // 
            // UpdateTimerCtrl
            // 
            this.UpdateTimerCtrl.Tick += new System.EventHandler(this.UpdateTimerCtrl_Tick);
            // 
            // SessionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SessionsLV);
            this.Controls.Add(this.panel1);
            this.Name = "SessionCtrl";
            this.Size = new System.Drawing.Size(774, 489);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SessionCountLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView SessionsLV;
        private System.Windows.Forms.ColumnHeader SessionNameCh;
        private System.Windows.Forms.ColumnHeader UserCh;
        private System.Windows.Forms.Timer UpdateTimerCtrl;
        private System.Windows.Forms.ColumnHeader SessionIdCh;
        private System.Windows.Forms.ColumnHeader SessionTimeoutCH;
        private System.Windows.Forms.ColumnHeader LastContactTimeCh;
        private System.Windows.Forms.ColumnHeader IsActiveCh;
    }
}
