namespace UserConCollection.MainFormControls


{
    partial class InventoryPreview
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
            this.MngInvButton = new System.Windows.Forms.Button();
            this.label158 = new System.Windows.Forms.Label();
            this.FilterCbo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InventoryListBox = new System.Windows.Forms.ListView();
            this.UnitIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MngInvButton
            // 
            this.MngInvButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MngInvButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MngInvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MngInvButton.Location = new System.Drawing.Point(246, 4);
            this.MngInvButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MngInvButton.Name = "MngInvButton";
            this.MngInvButton.Size = new System.Drawing.Size(100, 30);
            this.MngInvButton.TabIndex = 31;
            this.MngInvButton.Text = "Manage";
            this.MngInvButton.UseVisualStyleBackColor = true;
            this.MngInvButton.Click += new System.EventHandler(this.MngInvButton_Click);
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label158.Location = new System.Drawing.Point(7, 10);
            this.label158.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(43, 17);
            this.label158.TabIndex = 1;
            this.label158.Text = "Filter:";
            this.label158.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterCbo
            // 
            this.FilterCbo.AutoCompleteCustomSource.AddRange(new string[] {
            "Catagory",
            "Weapon",
            "Armor",
            "Misc"});
            this.FilterCbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FilterCbo.FormattingEnabled = true;
            this.FilterCbo.Items.AddRange(new object[] {
            "Catagory",
            "Weapons",
            "Armor",
            "Misc"});
            this.FilterCbo.Location = new System.Drawing.Point(51, 7);
            this.FilterCbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilterCbo.Name = "FilterCbo";
            this.FilterCbo.Size = new System.Drawing.Size(160, 24);
            this.FilterCbo.TabIndex = 2;
            this.FilterCbo.SelectedIndexChanged += new System.EventHandler(this.FilterCbo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MngInvButton);
            this.panel1.Controls.Add(this.FilterCbo);
            this.panel1.Controls.Add(this.label158);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 320);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.InventoryListBox);
            this.panel2.Location = new System.Drawing.Point(3, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 279);
            this.panel2.TabIndex = 32;
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.InventoryListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UnitIDCol,
            this.ValueCol,
            this.NotesColumn});
            this.InventoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InventoryListBox.FullRowSelect = true;
            this.InventoryListBox.GridLines = true;
            this.InventoryListBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.InventoryListBox.Location = new System.Drawing.Point(0, 0);
            this.InventoryListBox.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(343, 279);
            this.InventoryListBox.TabIndex = 30;
            this.InventoryListBox.UseCompatibleStateImageBehavior = false;
            this.InventoryListBox.View = System.Windows.Forms.View.Details;
            // 
            // UnitIDCol
            // 
            this.UnitIDCol.Text = "Unit ID";
            this.UnitIDCol.Width = 116;
            // 
            // ValueCol
            // 
            this.ValueCol.Text = "Value";
            this.ValueCol.Width = 80;
            // 
            // NotesColumn
            // 
            this.NotesColumn.Text = "Note\'s";
            this.NotesColumn.Width = 145;
            // 
            // InventoryPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InventoryPreview";
            this.Size = new System.Drawing.Size(350, 320);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.ComboBox FilterCbo;
        private System.Windows.Forms.Button MngInvButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView InventoryListBox;
        private System.Windows.Forms.ColumnHeader UnitIDCol;
        private System.Windows.Forms.ColumnHeader ValueCol;
        private System.Windows.Forms.ColumnHeader NotesColumn;
    }
}
