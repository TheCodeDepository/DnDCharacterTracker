namespace MainFormPreviewCtls
{
    partial class CombatPreview
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
            this.LevelingGrp = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ViewButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TotalEXP = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.CombatRecords = new System.Windows.Forms.ListView();
            this.UnitID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Experience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoldCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Loot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LevelTb = new System.Windows.Forms.TextBox();
            this.LevelLbl = new System.Windows.Forms.Label();
            this.LevelingGrp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelingGrp
            // 
            this.LevelingGrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelingGrp.AutoSize = true;
            this.LevelingGrp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LevelingGrp.Controls.Add(this.panel2);
            this.LevelingGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LevelingGrp.Location = new System.Drawing.Point(1, 2);
            this.LevelingGrp.MinimumSize = new System.Drawing.Size(374, 331);
            this.LevelingGrp.Name = "LevelingGrp";
            this.LevelingGrp.Size = new System.Drawing.Size(374, 331);
            this.LevelingGrp.TabIndex = 18;
            this.LevelingGrp.TabStop = false;
            this.LevelingGrp.Text = "Combat Results";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ViewButton);
            this.panel2.Controls.Add(this.RemoveButton);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.TotalEXP);
            this.panel2.Controls.Add(this.label118);
            this.panel2.Controls.Add(this.CombatRecords);
            this.panel2.Controls.Add(this.LevelTb);
            this.panel2.Controls.Add(this.LevelLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 306);
            this.panel2.TabIndex = 0;
            // 
            // ViewButton
            // 
            this.ViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ViewButton.Location = new System.Drawing.Point(287, 61);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(72, 23);
            this.ViewButton.TabIndex = 19;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.RemoveButton.Location = new System.Drawing.Point(287, 34);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(72, 23);
            this.RemoveButton.TabIndex = 18;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.AddButton.Location = new System.Drawing.Point(287, 7);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(72, 23);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TotalEXP
            // 
            this.TotalEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalEXP.Location = new System.Drawing.Point(86, 35);
            this.TotalEXP.Margin = new System.Windows.Forms.Padding(2);
            this.TotalEXP.Name = "TotalEXP";
            this.TotalEXP.Size = new System.Drawing.Size(69, 23);
            this.TotalEXP.TabIndex = 23;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label118.Location = new System.Drawing.Point(10, 37);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(71, 17);
            this.label118.TabIndex = 20;
            this.label118.Text = "Total Exp:";
            // 
            // CombatRecords
            // 
            this.CombatRecords.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.CombatRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CombatRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UnitID,
            this.Experience,
            this.GoldCol,
            this.Loot});
            this.CombatRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CombatRecords.FullRowSelect = true;
            this.CombatRecords.GridLines = true;
            this.CombatRecords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CombatRecords.Location = new System.Drawing.Point(3, 90);
            this.CombatRecords.Name = "CombatRecords";
            this.CombatRecords.Size = new System.Drawing.Size(362, 213);
            this.CombatRecords.TabIndex = 16;
            this.CombatRecords.UseCompatibleStateImageBehavior = false;
            this.CombatRecords.View = System.Windows.Forms.View.Details;
            this.CombatRecords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LevelingList_KeyDown);
            this.CombatRecords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LevelingList_MouseDoubleClick);
            // 
            // UnitID
            // 
            this.UnitID.Text = "Unit ID";
            this.UnitID.Width = 68;
            // 
            // Experience
            // 
            this.Experience.Text = "Exp";
            this.Experience.Width = 64;
            // 
            // GoldCol
            // 
            this.GoldCol.Text = "Gold";
            this.GoldCol.Width = 66;
            // 
            // Loot
            // 
            this.Loot.Text = "Loot";
            this.Loot.Width = 191;
            // 
            // LevelTb
            // 
            this.LevelTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LevelTb.Location = new System.Drawing.Point(86, 8);
            this.LevelTb.Margin = new System.Windows.Forms.Padding(2);
            this.LevelTb.Name = "LevelTb";
            this.LevelTb.Size = new System.Drawing.Size(69, 23);
            this.LevelTb.TabIndex = 12;
            // 
            // LevelLbl
            // 
            this.LevelLbl.AutoSize = true;
            this.LevelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LevelLbl.Location = new System.Drawing.Point(35, 11);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(46, 17);
            this.LevelLbl.TabIndex = 13;
            this.LevelLbl.Text = "Level:";
            // 
            // CombatPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.LevelingGrp);
            this.Name = "CombatPreview";
            this.Size = new System.Drawing.Size(376, 333);
            this.LevelingGrp.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LevelingGrp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox TotalEXP;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.ListView CombatRecords;
        private System.Windows.Forms.ColumnHeader UnitID;
        private System.Windows.Forms.ColumnHeader Experience;
        private System.Windows.Forms.ColumnHeader GoldCol;
        private System.Windows.Forms.ColumnHeader Loot;
        private System.Windows.Forms.TextBox LevelTb;
        private System.Windows.Forms.Label LevelLbl;
    }
}
