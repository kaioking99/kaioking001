namespace Opc.Ua.Server.Controls.Function_Form
{
    partial class AddressSpaceCtrl
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
            this.BrowseTreeView = new System.Windows.Forms.TreeView();
            this.AttributesView = new System.Windows.Forms.ListView();
            this.NameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTypeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BrowseTreeView
            // 
            this.BrowseTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.BrowseTreeView.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseTreeView.Location = new System.Drawing.Point(0, 0);
            this.BrowseTreeView.Name = "BrowseTreeView";
            this.BrowseTreeView.Size = new System.Drawing.Size(366, 489);
            this.BrowseTreeView.TabIndex = 0;
            this.BrowseTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.BrowseTreeView_BeforeExpand);
            this.BrowseTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.BrowseTreeView_AfterSelect);
            this.BrowseTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BrowseTreeView_MouseDown);
            // 
            // AttributesView
            // 
            this.AttributesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCh,
            this.ValueCh,
            this.DataTypeCh});
            this.AttributesView.FullRowSelect = true;
            this.AttributesView.HideSelection = false;
            this.AttributesView.Location = new System.Drawing.Point(366, 0);
            this.AttributesView.Name = "AttributesView";
            this.AttributesView.Size = new System.Drawing.Size(407, 258);
            this.AttributesView.TabIndex = 1;
            this.AttributesView.UseCompatibleStateImageBehavior = false;
            this.AttributesView.View = System.Windows.Forms.View.Details;
            // 
            // NameCh
            // 
            this.NameCh.Text = "Name";
            // 
            // DataTypeCh
            // 
            this.DataTypeCh.Text = "Data Type";
            // 
            // ValueCh
            // 
            this.ValueCh.Text = "Value";
            // 
            // AddressSpaceCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AttributesView);
            this.Controls.Add(this.BrowseTreeView);
            this.Name = "AddressSpaceCtrl";
            this.Size = new System.Drawing.Size(774, 489);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView BrowseTreeView;
        private System.Windows.Forms.ListView AttributesView;
        private System.Windows.Forms.ColumnHeader NameCh;
        private System.Windows.Forms.ColumnHeader DataTypeCh;
        private System.Windows.Forms.ColumnHeader ValueCh;
    }
}
