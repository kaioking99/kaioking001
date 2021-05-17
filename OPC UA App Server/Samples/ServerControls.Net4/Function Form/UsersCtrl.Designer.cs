namespace Opc.Ua.Server.Controls.Function_Form
{
    partial class UsersCtrl
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
            this.AnonymousCkB = new MaterialSkin.Controls.MaterialCheckBox();
            this.UserPassCkB = new MaterialSkin.Controls.MaterialCheckBox();
            this.CertificateCkb = new MaterialSkin.Controls.MaterialCheckBox();
            this.User_PasswordLV = new System.Windows.Forms.ListView();
            this.UserCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PasswordCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CertificateKeyLV = new System.Windows.Forms.ListView();
            this.CertiCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserTxB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.CertificateTxB = new System.Windows.Forms.TextBox();
            this.PasswordTxB = new System.Windows.Forms.TextBox();
            this.PrivateKeyTxB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CertificateBrowse = new System.Windows.Forms.Button();
            this.PrivateKeyBrowse = new System.Windows.Forms.Button();
            this.AddCertiBtn = new System.Windows.Forms.Button();
            this.DeleteCertiBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnonymousCkB
            // 
            this.AnonymousCkB.AutoSize = true;
            this.AnonymousCkB.Depth = 0;
            this.AnonymousCkB.Font = new System.Drawing.Font("Roboto", 10F);
            this.AnonymousCkB.Location = new System.Drawing.Point(4, 25);
            this.AnonymousCkB.Margin = new System.Windows.Forms.Padding(0);
            this.AnonymousCkB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AnonymousCkB.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnonymousCkB.Name = "AnonymousCkB";
            this.AnonymousCkB.Ripple = true;
            this.AnonymousCkB.Size = new System.Drawing.Size(103, 30);
            this.AnonymousCkB.TabIndex = 0;
            this.AnonymousCkB.Text = "Anonymous";
            this.AnonymousCkB.UseVisualStyleBackColor = true;
            // 
            // UserPassCkB
            // 
            this.UserPassCkB.AutoSize = true;
            this.UserPassCkB.Depth = 0;
            this.UserPassCkB.Font = new System.Drawing.Font("Roboto", 10F);
            this.UserPassCkB.Location = new System.Drawing.Point(124, 25);
            this.UserPassCkB.Margin = new System.Windows.Forms.Padding(0);
            this.UserPassCkB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UserPassCkB.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserPassCkB.Name = "UserPassCkB";
            this.UserPassCkB.Ripple = true;
            this.UserPassCkB.Size = new System.Drawing.Size(125, 30);
            this.UserPassCkB.TabIndex = 1;
            this.UserPassCkB.Text = "User/Password";
            this.UserPassCkB.UseVisualStyleBackColor = true;
            // 
            // CertificateCkb
            // 
            this.CertificateCkb.AutoSize = true;
            this.CertificateCkb.Depth = 0;
            this.CertificateCkb.Font = new System.Drawing.Font("Roboto", 10F);
            this.CertificateCkb.Location = new System.Drawing.Point(265, 25);
            this.CertificateCkb.Margin = new System.Windows.Forms.Padding(0);
            this.CertificateCkb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CertificateCkb.MouseState = MaterialSkin.MouseState.HOVER;
            this.CertificateCkb.Name = "CertificateCkb";
            this.CertificateCkb.Ripple = true;
            this.CertificateCkb.Size = new System.Drawing.Size(94, 30);
            this.CertificateCkb.TabIndex = 2;
            this.CertificateCkb.Text = "Certificate";
            this.CertificateCkb.UseVisualStyleBackColor = true;
            // 
            // User_PasswordLV
            // 
            this.User_PasswordLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserCh,
            this.PasswordCh});
            this.User_PasswordLV.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_PasswordLV.GridLines = true;
            this.User_PasswordLV.HideSelection = false;
            this.User_PasswordLV.Location = new System.Drawing.Point(4, 28);
            this.User_PasswordLV.Name = "User_PasswordLV";
            this.User_PasswordLV.Size = new System.Drawing.Size(318, 212);
            this.User_PasswordLV.TabIndex = 4;
            this.User_PasswordLV.UseCompatibleStateImageBehavior = false;
            this.User_PasswordLV.View = System.Windows.Forms.View.Details;
            // 
            // UserCh
            // 
            this.UserCh.Text = "User";
            this.UserCh.Width = 154;
            // 
            // PasswordCh
            // 
            this.PasswordCh.Text = "Password";
            this.PasswordCh.Width = 160;
            // 
            // CertificateKeyLV
            // 
            this.CertificateKeyLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CertiCh,
            this.KeyCh});
            this.CertificateKeyLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.CertificateKeyLV.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CertificateKeyLV.GridLines = true;
            this.CertificateKeyLV.HideSelection = false;
            this.CertificateKeyLV.Location = new System.Drawing.Point(4, 274);
            this.CertificateKeyLV.Name = "CertificateKeyLV";
            this.CertificateKeyLV.Size = new System.Drawing.Size(318, 212);
            this.CertificateKeyLV.TabIndex = 5;
            this.CertificateKeyLV.UseCompatibleStateImageBehavior = false;
            this.CertificateKeyLV.View = System.Windows.Forms.View.Details;
            // 
            // CertiCh
            // 
            this.CertiCh.Text = "Certificate Name";
            this.CertiCh.Width = 146;
            // 
            // KeyCh
            // 
            this.KeyCh.Text = "Private Key";
            this.KeyCh.Width = 163;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "User/Password List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(7, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Certificate/Key";
            // 
            // UserTxB
            // 
            this.UserTxB.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTxB.Location = new System.Drawing.Point(336, 87);
            this.UserTxB.Name = "UserTxB";
            this.UserTxB.Size = new System.Drawing.Size(280, 27);
            this.UserTxB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBtn.Location = new System.Drawing.Point(336, 199);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(102, 41);
            this.AddUserBtn.TabIndex = 12;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserBtn.Location = new System.Drawing.Point(479, 199);
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.Size = new System.Drawing.Size(102, 41);
            this.DeleteUserBtn.TabIndex = 13;
            this.DeleteUserBtn.Text = "Delete User";
            this.DeleteUserBtn.UseVisualStyleBackColor = true;
            // 
            // CertificateTxB
            // 
            this.CertificateTxB.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CertificateTxB.Location = new System.Drawing.Point(336, 328);
            this.CertificateTxB.Name = "CertificateTxB";
            this.CertificateTxB.Size = new System.Drawing.Size(280, 27);
            this.CertificateTxB.TabIndex = 14;
            // 
            // PasswordTxB
            // 
            this.PasswordTxB.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxB.Location = new System.Drawing.Point(336, 149);
            this.PasswordTxB.Name = "PasswordTxB";
            this.PasswordTxB.Size = new System.Drawing.Size(280, 27);
            this.PasswordTxB.TabIndex = 15;
            // 
            // PrivateKeyTxB
            // 
            this.PrivateKeyTxB.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivateKeyTxB.Location = new System.Drawing.Point(336, 380);
            this.PrivateKeyTxB.Name = "PrivateKeyTxB";
            this.PrivateKeyTxB.Size = new System.Drawing.Size(280, 27);
            this.PrivateKeyTxB.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Certificate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Private Key";
            // 
            // CertificateBrowse
            // 
            this.CertificateBrowse.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CertificateBrowse.Location = new System.Drawing.Point(622, 326);
            this.CertificateBrowse.Name = "CertificateBrowse";
            this.CertificateBrowse.Size = new System.Drawing.Size(30, 29);
            this.CertificateBrowse.TabIndex = 19;
            this.CertificateBrowse.Text = "...";
            this.CertificateBrowse.UseVisualStyleBackColor = true;
            // 
            // PrivateKeyBrowse
            // 
            this.PrivateKeyBrowse.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivateKeyBrowse.Location = new System.Drawing.Point(622, 378);
            this.PrivateKeyBrowse.Name = "PrivateKeyBrowse";
            this.PrivateKeyBrowse.Size = new System.Drawing.Size(30, 29);
            this.PrivateKeyBrowse.TabIndex = 20;
            this.PrivateKeyBrowse.Text = "...";
            this.PrivateKeyBrowse.UseVisualStyleBackColor = true;
            // 
            // AddCertiBtn
            // 
            this.AddCertiBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCertiBtn.Location = new System.Drawing.Point(336, 425);
            this.AddCertiBtn.Name = "AddCertiBtn";
            this.AddCertiBtn.Size = new System.Drawing.Size(136, 41);
            this.AddCertiBtn.TabIndex = 21;
            this.AddCertiBtn.Text = "Add Certificate";
            this.AddCertiBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteCertiBtn
            // 
            this.DeleteCertiBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCertiBtn.Location = new System.Drawing.Point(491, 425);
            this.DeleteCertiBtn.Name = "DeleteCertiBtn";
            this.DeleteCertiBtn.Size = new System.Drawing.Size(140, 41);
            this.DeleteCertiBtn.TabIndex = 22;
            this.DeleteCertiBtn.Text = "Delete Certificate";
            this.DeleteCertiBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ApplyBtn);
            this.panel1.Controls.Add(this.AnonymousCkB);
            this.panel1.Controls.Add(this.UserPassCkB);
            this.panel1.Controls.Add(this.CertificateCkb);
            this.panel1.Location = new System.Drawing.Point(336, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 58);
            this.panel1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "User Authentication";
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyBtn.Location = new System.Drawing.Point(372, 23);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(60, 32);
            this.ApplyBtn.TabIndex = 24;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // UsersCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteCertiBtn);
            this.Controls.Add(this.AddCertiBtn);
            this.Controls.Add(this.PrivateKeyBrowse);
            this.Controls.Add(this.CertificateBrowse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrivateKeyTxB);
            this.Controls.Add(this.PasswordTxB);
            this.Controls.Add(this.CertificateTxB);
            this.Controls.Add(this.DeleteUserBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserTxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CertificateKeyLV);
            this.Controls.Add(this.User_PasswordLV);
            this.Name = "UsersCtrl";
            this.Size = new System.Drawing.Size(774, 489);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox AnonymousCkB;
        private MaterialSkin.Controls.MaterialCheckBox UserPassCkB;
        private MaterialSkin.Controls.MaterialCheckBox CertificateCkb;
        private System.Windows.Forms.ListView User_PasswordLV;
        private System.Windows.Forms.ListView CertificateKeyLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserTxB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Button DeleteUserBtn;
        private System.Windows.Forms.ColumnHeader UserCh;
        private System.Windows.Forms.ColumnHeader PasswordCh;
        private System.Windows.Forms.TextBox CertificateTxB;
        private System.Windows.Forms.TextBox PasswordTxB;
        private System.Windows.Forms.TextBox PrivateKeyTxB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CertificateBrowse;
        private System.Windows.Forms.Button PrivateKeyBrowse;
        private System.Windows.Forms.Button AddCertiBtn;
        private System.Windows.Forms.Button DeleteCertiBtn;
        private System.Windows.Forms.ColumnHeader CertiCh;
        private System.Windows.Forms.ColumnHeader KeyCh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ApplyBtn;
    }
}
